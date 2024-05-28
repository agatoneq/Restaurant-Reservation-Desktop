using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_rezerwacji
{
    public class Pracownik : Uzytkownik
    {
        private string login;
        private string haslo;

        public string Login { get => login; set => login = value; }
        public string Haslo { get => haslo; set => haslo = value; }

        public Pracownik(string im, string nazw, string log, string has)
        {
            Imie = im;
            Nazwisko = nazw;
            Login = log;
            Haslo = has;
        }
    }
}
