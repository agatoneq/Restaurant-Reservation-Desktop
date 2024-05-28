using System;
using System.Windows.Forms;

namespace System_rezerwacji
{
    public partial class Podaj_dane : Form
    {
        public Podaj_dane()
        {
            InitializeComponent();
        }

        public static Klient klient = new Klient();

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            klient.Imie = imie.Text;
            klient.Nazwisko = nazwisko.Text;
            klient.Adres_email = mail.Text;
            klient.Nr_tel = nr_tel.Text;

            if (!klient.SprawdzPoprawnoscImienia(klient.Imie))
            {
                MessageBox.Show("Niepoprawne imię.");
            }
            else if (!klient.SprawdzPoprawnoscNazwiska(klient.Nazwisko))
            {
                MessageBox.Show("Niepoprawne nazwisko.");
            }
            else if (!klient.SprawdzPoprawnoscEmail(klient.Adres_email))
            {
                MessageBox.Show("Niepoprawny adres e-mail.");
            }
            else if (!klient.SprawdzPoprawnoscNrTel(klient.Nr_tel))
            {
                MessageBox.Show("Niepoprawny numer telefonu.");
            }
            else 
            {
                this.Hide();
                Wybierz_rodzaj wybierz_rodzaj = new Wybierz_rodzaj();
                wybierz_rodzaj.Show();
            }
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
            Form poprzedniFormularz = Application.OpenForms[Application.OpenForms.Count - 1];
            poprzedniFormularz.Show();
        }

        private void imie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
