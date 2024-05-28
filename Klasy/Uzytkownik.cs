using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_rezerwacji
{
    public class Uzytkownik
    {
        private string imie;
        private string nazwisko;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }

        public bool SprawdzPoprawnoscImienia(string imie)
        {
            Regex wzorzec = new Regex("^[A-Z][a-z]{2,19}$");
            Match match = wzorzec.Match(imie);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SprawdzPoprawnoscNazwiska(string nazwisko)
        {
            Regex wzorzec = new Regex(@"^[A-Z][a-z]{2,19}(-[A-Z][a-z]{2,19})?$"); 
            Match match = wzorzec.Match(nazwisko);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
