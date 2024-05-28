using System;
using System.IO;
using System.Windows.Forms;

namespace System_rezerwacji
{
    public partial class Wybierz_menu : Form
    {
        public Wybierz_menu()
        {
            InitializeComponent();
        }

        public static Menu menu = new Menu();

        private void rozpocznij_Click(object sender, EventArgs e)
        {
            menu.wczytaj_plik("C:\\Users\\agata\\source\\repos\\450231ff-gr12-repo\\Projekt\\System rezerwacji\\Menu.txt");

            checkedListZupy.DataSource = menu.Zupy;
            checkedListGoraceDanie1.DataSource = menu.Gorace_danie1;
            checkedListGoraceDanie2.DataSource = menu.Gorace_danie2;
            checkedListPrzekaski.DataSource = menu.Przekaski;
            checkedListDeser.DataSource = menu.Deser;
            checkedListTort.DataSource = menu.Tort;
            checkedListNapoje.DataSource = menu.Napoje;

            label1.Visible = true;
            checkedListZupy.Visible = true;
            label2.Visible = true;
            checkedListGoraceDanie1.Visible = true;
            label3.Visible = true;
            checkedListGoraceDanie2.Visible = true;
            label4.Visible = true;
            checkedListPrzekaski.Visible = true;
            label5.Visible = true;
            checkedListDeser.Visible = true;
            label6.Visible = true;
            checkedListTort.Visible = true;
            label7.Visible = true;
            checkedListNapoje.Visible = true;
        }

        public static Menu wybrane_menu = new Menu();

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (checkedListZupy.CheckedItems.Count == 0 || checkedListGoraceDanie1.CheckedItems.Count == 0 || checkedListDeser.CheckedItems.Count == 0 || checkedListTort.CheckedItems.Count == 0 || checkedListNapoje.CheckedItems.Count == 0)
            {
                MessageBox.Show("Wybranie opcji z sekcji: \"zupy\", \"I gorące danie\", \"deser\", \"tort\" lub \"napoje\" jest obwiązkowe.");
                return;
            }

            foreach (object element in checkedListZupy.CheckedItems)
                wybrane_menu.Zupy.Add(element.ToString());

            foreach (object element in checkedListGoraceDanie1.CheckedItems)
                wybrane_menu.Gorace_danie1.Add(element.ToString());

            foreach (object element in checkedListGoraceDanie2.CheckedItems)
                wybrane_menu.Gorace_danie2.Add(element.ToString());

            foreach (object element in checkedListPrzekaski.CheckedItems)
                wybrane_menu.Przekaski.Add(element.ToString());

            foreach (object element in checkedListDeser.CheckedItems)
                wybrane_menu.Deser.Add(element.ToString());

            foreach (object element in checkedListTort.CheckedItems)
                wybrane_menu.Tort.Add(element.ToString());

            foreach (object element in checkedListNapoje.CheckedItems)
                wybrane_menu.Napoje.Add(element.ToString());

            Wybierz_rodzaj.rezerwacja.Menu = wybrane_menu;

            this.Hide();
            Dodaj_uwagi dodaj_uwagi = new Dodaj_uwagi();
            dodaj_uwagi.Show();
        }

        private void checkedListZupy_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Sprawdzanie, czy dodanie kolejnego elementu spowoduje przekroczenie limitu
            if (e.NewValue == CheckState.Checked && checkedListZupy.CheckedItems.Count >= 1)
                e.NewValue = CheckState.Unchecked; // Anulowanie zaznaczenia
        }

        private void checkedListGoraceDanie1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListGoraceDanie1.CheckedItems.Count >= 4)
                e.NewValue = CheckState.Unchecked;
        }

        private void checkedListGoraceDanie2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListGoraceDanie2.CheckedItems.Count >= 1)
                e.NewValue = CheckState.Unchecked;
        }

        private void checkedListPrzekaski_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListPrzekaski.CheckedItems.Count >= 8)
                e.NewValue = CheckState.Unchecked;
        }

        private void checkedListDeser_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListDeser.CheckedItems.Count >= 1)
                e.NewValue = CheckState.Unchecked;
        }

        private void checkedListTort_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListTort.CheckedItems.Count >= 1)
                e.NewValue = CheckState.Unchecked;
        }

        private void info_Click(object sender, EventArgs e)
        {
            Wybierz_rodzaj.rezerwacja.CzyMenu = false;

            this.Hide();
            Dodaj_uwagi dodaj_uwagi = new Dodaj_uwagi();
            dodaj_uwagi.Show();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
            Form poprzedniFormularz = Application.OpenForms[Application.OpenForms.Count - 1];
            poprzedniFormularz.Show();
        }
    }
}
