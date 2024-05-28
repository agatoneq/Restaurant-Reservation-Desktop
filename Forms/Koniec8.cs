using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace System_rezerwacji
{
    public partial class Koniec : Form
    {
        public Koniec()
        {
            InitializeComponent();
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-KQETDHU\\SQLEXPRESS;Initial Catalog=RESTAURACJA;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Trusted_connection=true;";
            string sqlQuery = "";
            if (Wybierz_rodzaj.rezerwacja is Rezerwacja_Sali)
            {
                sqlQuery = "INSERT INTO Klienci(imie, nazwisko, email, nr_tel) VALUES('" + Wybierz_rodzaj.rezerwacja.Klient.Imie + "', '" + Wybierz_rodzaj.rezerwacja.Klient.Nazwisko + "', '" + Wybierz_rodzaj.rezerwacja.Klient.Adres_email + "', " + Wybierz_rodzaj.rezerwacja.Klient.Nr_tel + ");" +
                "DECLARE @ostatni_nr_kl INT;\r\n" +
                "SELECT @ostatni_nr_kl = SCOPE_IDENTITY();\r\n" +
             "INSERT INTO Rezerwacje(nr_kl, termin, liczba_os, menu, rezerwacja_sali, uwagi) VALUES(@ostatni_nr_kl, CONVERT(datetime, '" + Wybierz_rodzaj.rezerwacja.Termin.zamien_na_DateTime() + "', 105), '" + Wybierz_rodzaj.rezerwacja.Liczba_osob + "', '" + Wybierz_rodzaj.rezerwacja.menuBIT() + "', '" + 1 + "', '" + Wybierz_rodzaj.rezerwacja.Uwagi + "');";
            }
            else
            {
                sqlQuery = "INSERT INTO Klienci(imie, nazwisko, email, nr_tel) VALUES('" + Wybierz_rodzaj.rezerwacja.Klient.Imie + "', '" + Wybierz_rodzaj.rezerwacja.Klient.Nazwisko + "', '" + Wybierz_rodzaj.rezerwacja.Klient.Adres_email + "', " + Wybierz_rodzaj.rezerwacja.Klient.Nr_tel + ");" +
                "DECLARE @ostatni_nr_kl INT;\r\n" +
                "SELECT @ostatni_nr_kl = SCOPE_IDENTITY();\r\n" +
             "INSERT INTO Rezerwacje(nr_kl, termin, liczba_os, menu, rezerwacja_sali, uwagi) VALUES(@ostatni_nr_kl, CONVERT(datetime, '" + Wybierz_rodzaj.rezerwacja.Termin.zamien_na_DateTime() + "', 105), '" + Wybierz_rodzaj.rezerwacja.Liczba_osob + "', '" + Wybierz_rodzaj.rezerwacja.menuBIT() + "', '" + 0 + "', '" + Wybierz_rodzaj.rezerwacja.Uwagi + "');";
            }
       

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();

            Application.Exit();
        }

        private void dane_MouseClick(object sender, MouseEventArgs e)
        {
            dane.Text = Wybierz_rodzaj.rezerwacja.wyswietl_wynik();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
            Form poprzedniFormularz = Application.OpenForms[Application.OpenForms.Count - 1];
            poprzedniFormularz.Show();
        }
    }
}
