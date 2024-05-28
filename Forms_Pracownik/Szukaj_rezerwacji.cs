using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace System_rezerwacji
{
    public partial class Szukaj_rezerwacji : Form
    {
        public Szukaj_rezerwacji()
        {
            InitializeComponent();
        }
        public static Termin termin = new Termin();

        private StringBuilder sbGlowne;
        private StringBuilder sbSala;
        bool czyObie = false;

        private void szukaj_gl_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wybrana data")
            {
                MessageBox.Show("Wybór daty jest obowiązkowy.");
                return;
            }

            czyObie = false;
            sbGlowne = new StringBuilder();
            Thread threadGlowne = new Thread(SzukajGlowne);
            threadGlowne.Start();
        }

        private void szukaj_sala_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wybrana data")
            {
                MessageBox.Show("Wybór daty jest obowiązkowy.");
                return;
            }

            czyObie = false;
            sbSala = new StringBuilder();
            Thread threadSala = new Thread(SzukajSale);
            threadSala.Start();
        }

        private void szukaj_obu_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Wybrana data")
            {
                MessageBox.Show("Wybór daty jest obowiązkowy.");
                return;
            }

            czyObie = true;
            sbGlowne = new StringBuilder();
            sbSala = new StringBuilder();

            Thread threadGlowne = new Thread(SzukajGlowne);
            Thread threadSala = new Thread(SzukajSale);

            threadGlowne.Start();
            threadSala.Start();

            threadGlowne.Join();
            threadSala.Join();

            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    dane.Text = $"Rezerwacje główne:\n\n{sbGlowne}\nRezerwacje sali:\n\n{sbSala}";
                }));
            }
            else
                dane.Text = $"Rezerwacje główne:\n\n{sbGlowne}\nRezerwacje sali:\n\n{sbSala}";
        }

        private void SzukajGlowne()
        {
            termin.Data = label1.Text;

            string connectionString = "Data Source=DESKTOP-KQETDHU\\SQLEXPRESS;Initial Catalog=RESTAURACJA;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Trusted_connection=true;";
            string sqlQuery = "";

            if (!string.IsNullOrEmpty(TextBoxNazwisko.Text))
               sqlQuery = "select * from rezerwacje r join klienci k on r.nr_kl = k.nr_kl where rezerwacja_sali = 0 and CAST(r.termin AS date) = CONVERT(datetime, '" + termin.zamien_na_DateTime() + "', 105) and k.nazwisko = '" + TextBoxNazwisko.Text + "';";
            else
                sqlQuery = "select * from rezerwacje r join klienci k on r.nr_kl = k.nr_kl where rezerwacja_sali = 0 and CAST(r.termin AS date) = CONVERT(datetime, '" + termin.zamien_na_DateTime() + "', 105);";
           
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = sc.ExecuteReader();

            while (reader.Read())
            {
                int nr_rez = reader.GetInt32(0);
                DateTime termin = reader.GetDateTime(1);
                int liczba_os = reader.GetInt32(2);
                bool menu = reader.GetBoolean(3);
                string uwagi = reader.GetString(4);
                int nr_kl = reader.GetInt32(5);
                string imie = reader.GetString(8);
                string nazwisko = reader.GetString(9);
                string nr_tel = reader.GetString(10);
                string email = reader.GetString(11);

                sbGlowne.AppendLine($"Numer rezerwacji: {nr_rez}");
                sbGlowne.AppendLine($"Termin: {termin}");
                sbGlowne.AppendLine($"Liczba osób: {liczba_os}");
                sbGlowne.AppendLine($"Menu: {(menu ? "Tak" : "Nie")}");
                sbGlowne.AppendLine($"Uwagi: {uwagi}");
                sbGlowne.AppendLine($"Numer klienta: {nr_kl}");
                sbGlowne.AppendLine($"Imię: {imie}");
                sbGlowne.AppendLine($"Nazwisko: {nazwisko}");
                sbGlowne.AppendLine($"Numer telefonu: {nr_tel}");
                sbGlowne.AppendLine($"Email: {email}");
                sbGlowne.AppendLine();

            }

            reader.Close();
            con.Close();

            if (czyObie == false)
                dane.Invoke(new Action(() => dane.Text = sbGlowne.ToString()));
        }

        private void SzukajSale()
        {
            termin.Data = label1.Text;

            string connectionString = "Data Source=DESKTOP-KQETDHU\\SQLEXPRESS;Initial Catalog=RESTAURACJA;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;Trusted_connection=true;";
            
            string sqlQuery = "";

            if (!string.IsNullOrEmpty(TextBoxNazwisko.Text))
                sqlQuery = "select * from rezerwacje r join klienci k on r.nr_kl = k.nr_kl where rezerwacja_sali = 1 and CAST(r.termin AS date) = CONVERT(datetime, '" + termin.zamien_na_DateTime() + "', 105) and k.nazwisko = '" + TextBoxNazwisko.Text + "';";
            else
                sqlQuery = "select * from rezerwacje r join klienci k on r.nr_kl = k.nr_kl where rezerwacja_sali = 1 and CAST(r.termin AS date) = CONVERT(datetime, '" + termin.zamien_na_DateTime() + "', 105);";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = sc.ExecuteReader();

            while (reader.Read())
            {
                int nr_rez = reader.GetInt32(0);
                DateTime termin = reader.GetDateTime(1);
                int liczba_os = reader.GetInt32(2);
                bool menu = reader.GetBoolean(3);
                string uwagi = reader.GetString(4);
                int nr_kl = reader.GetInt32(5);
                string imie = reader.GetString(8);
                string nazwisko = reader.GetString(9);
                string nr_tel = reader.GetString(10);
                string email = reader.GetString(11);

                sbSala.AppendLine($"Numer rezerwacji: {nr_rez}");
                sbSala.AppendLine($"Termin: {termin}");
                sbSala.AppendLine($"Liczba osób: {liczba_os}");
                sbSala.AppendLine($"Menu: {(menu ? "Tak" : "Nie")}");
                sbSala.AppendLine($"Uwagi: {uwagi}");
                sbSala.AppendLine($"Numer klienta: {nr_kl}");
                sbSala.AppendLine($"Imię: {imie}");
                sbSala.AppendLine($"Nazwisko: {nazwisko}");
                sbSala.AppendLine($"Numer telefonu: {nr_tel}");
                sbSala.AppendLine($"Email: {email}");
                sbSala.AppendLine();
            }

            reader.Close();
            con.Close();

            if (czyObie == false) 
                dane.Invoke(new Action(() => dane.Text = sbSala.ToString()));
        }

        private void zakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dane_MouseClick(object sender, MouseEventArgs e)
        {
            dane.Text = Wybierz_rodzaj.rezerwacja.wyswietl_wynik();
        }

        private void data_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = data.SelectionStart.ToString("d");
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
            Form poprzedniFormularz = Application.OpenForms[Application.OpenForms.Count - 1];
            poprzedniFormularz.Show();
        }
    }
}
