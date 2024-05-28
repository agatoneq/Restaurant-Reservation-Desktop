using System;
using System.Windows.Forms;

namespace System_rezerwacji
{
    public partial class Wybierz_rodzaj: Form
    {
        public Wybierz_rodzaj()
        {
            InitializeComponent();
        }

        private void rStolika_CheckedChanged(object sender, EventArgs e)
        {
            if (rStolika.Checked)
            {
                rPrzyjecia.Checked = false;
                rSali.Checked = false;
            }
        }

        private void rPrzyjecia_CheckedChanged(object sender, EventArgs e)
        {
            if (rPrzyjecia.Checked)
            {
                rStolika.Checked = false;
                rSali.Checked = false;
            }
        }

        private void rSali_CheckedChanged(object sender, EventArgs e)
        {
            if (rSali.Checked)
            {
                rStolika.Checked = false;
                rPrzyjecia.Checked = false;
            }
        }

        public static Rezerwacja rezerwacja;

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (rStolika.Checked == false && rPrzyjecia.Checked == false && rSali.Checked == false)
            {
                MessageBox.Show("Proszę wybrać rodzaj rezerwacji.");
                return;
            }

            if (rStolika.Checked)
            {
                rezerwacja = new Rezerwacja_Stolika();
                rezerwacja.CzyMenu = false;
            }
            else if (rPrzyjecia.Checked)
            {
                rezerwacja = new Rezerwacja_Przyjecia();
                rezerwacja.CzyMenu = false;
            }
            else if (rSali.Checked)
            {
                rezerwacja = new Rezerwacja_Sali();
                rezerwacja.CzyMenu = true;
            }

            rezerwacja.Klient = Podaj_dane.klient;

            this.Hide();
            Podaj_liczbe_osob podaj_liczbe_osob = new Podaj_liczbe_osob();
            podaj_liczbe_osob.Show();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
            Form poprzedniFormularz = Application.OpenForms[Application.OpenForms.Count - 1];
            poprzedniFormularz.Show();
        }
    }
}
