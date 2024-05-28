using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace System_rezerwacji
{
    public partial class Wybierz_termin : Form
    {
        public Wybierz_termin()
        {
            InitializeComponent();
        }

        public static Termin termin = new Termin();

        private void data_DateChanged(object sender, DateRangeEventArgs e)
        {
            label3.Text = data.SelectionStart.ToString("d");
        }

        private void godzina_ValueChanged(object sender, EventArgs e)
        {
            if (Wybierz_rodzaj.rezerwacja is Rezerwacja_Stolika)
            {
                godzina.Minimum = 12;
                godzina.Maximum = 20;
            }
            else if (Wybierz_rodzaj.rezerwacja is Rezerwacja_Przyjecia)
            {
                godzina.Minimum = 12;
                godzina.Maximum = 19;
            }
            else if (Wybierz_rodzaj.rezerwacja is Rezerwacja_Sali)
            {
                godzina.Minimum = 11;
                godzina.Maximum = 17;
            }
        }

        private void minuty_SelectedItemChanged(object sender, EventArgs e)
        {
            if (Wybierz_rodzaj.rezerwacja is Rezerwacja_Przyjecia || Wybierz_rodzaj.rezerwacja is Rezerwacja_Sali)
            {
                minuty.Items.Clear();
                minuty.Items.Add("30");
                minuty.Items.Add("00");
            }
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (godzina.Value == 0 || data.SelectionRange.Start <= DateTime.Today)
            {
                MessageBox.Show("Nieprawidłowe dane.");
                return;
            }

            termin.Data= label3.Text;
            termin.Godzina = (int)godzina.Value;
            termin.Minuty = minuty.Text;

            Wybierz_rodzaj.rezerwacja.Termin = termin;


            string connectionString = "Data Source=DESKTOP-KQETDHU\\SQLEXPRESS;Initial Catalog=RESTAURACJA;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Trusted_connection=true;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            if (Wybierz_rodzaj.rezerwacja is Rezerwacja_Sali)
            {
                string sqlQuery = "SELECT * FROM Rezerwacje WHERE rezerwacja_sali = 1 and termin = CONVERT(datetime, '" + Wybierz_rodzaj.rezerwacja.Termin.zamien_na_DateTime() + "', 105)";

                bool zarezerwowana_sala = true;
                SqlCommand sc = new SqlCommand(sqlQuery, con);
                object wynik = sc.ExecuteScalar();
                if (wynik != null)
                    zarezerwowana_sala = true;
                else
                    zarezerwowana_sala = false;
                if (zarezerwowana_sala == true)
                {
                    MessageBox.Show("Nie można dokonać rezerwacji sali w tym dniu.");
                    return;
                }
            }

            else
            {
                string sqlQuery1 = "SELECT CASE WHEN EXISTS (" +
                    "SELECT 1 " +
                    "FROM Rezerwacje " +
                    "WHERE termin >= DATEADD(HOUR, -3, CONVERT(datetime, '" + Wybierz_rodzaj.rezerwacja.Termin.zamien_na_DateTime() + "', 105)) " +
                    "AND termin <= DATEADD(HOUR, 3, CONVERT(datetime, '" + Wybierz_rodzaj.rezerwacja.Termin.zamien_na_DateTime() + "', 105)) " +
                    "AND liczba_os >= 30 " +
                    "AND rezerwacja_sali = 0) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END AS czy_istnieje_rekord;";

                bool czy_istnieje = false;
                SqlCommand sc1 = new SqlCommand(sqlQuery1, con);
                object wynik1 = sc1.ExecuteScalar();

                if (wynik1 != null)
                {
                    czy_istnieje = (bool)wynik1;
                }
                if (czy_istnieje == true)
                {
                    MessageBox.Show("Nie można dokonać rezerwacji w tym dniu.");
                    return;
                }


                string sqlQuery2 = "SELECT SUM(liczba_os) AS suma_osob " +
                    "FROM Rezerwacje " +
                    "WHERE termin >= DATEADD(HOUR, -3, CONVERT(datetime, '" + Wybierz_rodzaj.rezerwacja.Termin.zamien_na_DateTime() + "', 105)) " +
                    "AND termin <= DATEADD(HOUR, 3, CONVERT(datetime, '" + Wybierz_rodzaj.rezerwacja.Termin.zamien_na_DateTime() + "', 105)) " +
                    "AND rezerwacja_sali = 0;";

                int suma = 0;
                SqlCommand sc2 = new SqlCommand(sqlQuery2, con);
                object wynik2 = sc2.ExecuteScalar();
                if (wynik2 != null && wynik2 != DBNull.Value)
                {
                    suma = Convert.ToInt32(wynik2);
                }

                int wynik3 = suma + Wybierz_rodzaj.rezerwacja.Liczba_osob;
                if (wynik3 > 40)
                {
                    MessageBox.Show("Nie można dokonać rezerwacji o tej godzinie.");
                    return;
                }
            }
            con.Close();


            if (Wybierz_rodzaj.rezerwacja.CzyMenu == true)
            {
                this.Hide();
                Wybierz_menu wybierz_menu = new Wybierz_menu();
                wybierz_menu.Show();
            }
            else
            {
                this.Hide();
                Dodaj_uwagi dodaj_uwagi = new Dodaj_uwagi();
                dodaj_uwagi.Show();
            }
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
            Form poprzedniFormularz = Application.OpenForms[Application.OpenForms.Count - 1];
            poprzedniFormularz.Show();
        }
    }
}
