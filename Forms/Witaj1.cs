using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace System_rezerwacji
{
    public partial class Witaj : Form
    {
        public Witaj()
        {
            InitializeComponent();
        }

        private void pracownik_log_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
        }

        private void klient_log_Click(object sender, EventArgs e)
        {
            this.Hide();
            Podaj_dane podaj_dane = new Podaj_dane();
            podaj_dane.Show();
        }
    }
}
