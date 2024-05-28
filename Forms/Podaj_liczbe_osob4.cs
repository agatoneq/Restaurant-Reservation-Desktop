using System;
using System.Windows.Forms;

namespace System_rezerwacji
{
    public partial class Podaj_liczbe_osob : Form
    {
        public Podaj_liczbe_osob()
        {
            InitializeComponent();
        }

        private void liczba_osob_ValueChanged(object sender, EventArgs e)
        {
            if (Wybierz_rodzaj.rezerwacja is Rezerwacja_Stolika)
            {
                liczba_osob.Minimum = 1;
                liczba_osob.Maximum = 10;
            }
            else if (Wybierz_rodzaj.rezerwacja is Rezerwacja_Przyjecia)
            {
                liczba_osob.Minimum = 8;
                liczba_osob.Maximum = 50;
            }
            else if (Wybierz_rodzaj.rezerwacja is Rezerwacja_Sali)
            {
                liczba_osob.Minimum = 20;
                liczba_osob.Maximum = 36;
            }
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (liczba_osob.Value == 0)
            {
                MessageBox.Show("Nieprawidłowe dane.");
                return;
            }

            Wybierz_rodzaj.rezerwacja.Liczba_osob = (int)liczba_osob.Value;

            if (Wybierz_rodzaj.rezerwacja.Liczba_osob > 10)
            {
                Wybierz_rodzaj.rezerwacja.CzyMenu = true;
            }

            this.Hide();
            Wybierz_termin wybierz_termin = new Wybierz_termin();
            wybierz_termin.Show();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
            Form poprzedniFormularz = Application.OpenForms[Application.OpenForms.Count - 1];
            poprzedniFormularz.Show();
        }
    }
}
