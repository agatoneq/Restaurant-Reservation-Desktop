using System;
using System.Windows.Forms;

namespace System_rezerwacji
{
    public partial class Dodaj_uwagi : Form
    {
        public Dodaj_uwagi()
        {
            InitializeComponent();
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            Wybierz_rodzaj.rezerwacja.Uwagi = uwagi.Text;

            this.Hide();
            Koniec koniec = new Koniec();
            koniec.Show();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
            Form poprzedniFormularz = Application.OpenForms[Application.OpenForms.Count - 1];
            poprzedniFormularz.Show();
        }
    }
}
