using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_rezerwacji
{
    public class Rezerwacja_Stolika : Rezerwacja
    {
        public override string wyswietl_wynik()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Zarezerwowano stolik. ");
            sb.AppendLine();
            sb.AppendLine("Imię rezerwującego: " + Klient.Imie);
            sb.AppendLine();
            sb.AppendLine("Nazwisko: " + Klient.Nazwisko);
            sb.AppendLine();
            sb.AppendLine("Numer telefonu: " + Klient.Nr_tel);
            sb.AppendLine();
            sb.AppendLine("Adres e-mail: " + Klient.Adres_email);
            sb.AppendLine();
            sb.AppendLine("Termin: " + Termin.wyswietl());
            sb.AppendLine("Liczba osób: " + Liczba_osob);
            sb.AppendLine();
            if (CzyMenu == true)
                sb.AppendLine(Menu.wyswietl());
            if (Uwagi != "")
                sb.AppendLine("Uwagi: " + Uwagi);
            else
                sb.AppendLine("Uwagi: Brak");

            return sb.ToString();
        }
    }
}
