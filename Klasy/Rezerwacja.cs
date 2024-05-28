using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_rezerwacji
{
    public abstract class Rezerwacja
    {
        private Klient klient;
        private Termin termin;
        private int liczba_osob;
        private Menu menu;
        private string uwagi;
        private bool czyMenu;
        private int nr_stolika;

        public Klient Klient { get => klient; set => klient = value; }
        public Termin Termin { get => termin; set => termin = value; }
        public int Liczba_osob { get => liczba_osob; set => liczba_osob = value; }
        public Menu Menu { get => menu; set => menu = value; }
        public string Uwagi { get => uwagi; set => uwagi = value; }
        public bool CzyMenu { get => czyMenu; set => czyMenu = value; }
        public int Nr_stolika { get => nr_stolika; set => nr_stolika = value; }

        public abstract string wyswietl_wynik();

        public int menuBIT()
        {
            int menu_bit = 0;

            if (CzyMenu == true)
                menu_bit = 1;
            else if (CzyMenu == false)
                menu_bit = 0;

            return menu_bit;
        }
    }
}
