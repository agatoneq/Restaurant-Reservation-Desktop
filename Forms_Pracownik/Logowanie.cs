using System;
using System.Windows.Forms;

namespace System_rezerwacji
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        public static Pracownik administrator = new Pracownik("Jan", "Kowalski", "jk121278", "x123");

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (login.Text == administrator.Login && haslo.Text == administrator.Haslo)
            {
                this.Hide();
                Szukaj_rezerwacji szukaj_rezerwacji = new Szukaj_rezerwacji();
                szukaj_rezerwacji.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form poprzedniFormularz = Application.OpenForms[Application.OpenForms.Count - 1];
            poprzedniFormularz.Show();
        }
    }
}
