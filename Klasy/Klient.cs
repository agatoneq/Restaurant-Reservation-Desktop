using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_rezerwacji
{
    public class Klient : Uzytkownik
    {
        private string adres_email;
        private string nr_tel;

        public string Adres_email { get => adres_email; set => adres_email = value; }
        public string Nr_tel { get => nr_tel; set => nr_tel = value; }

        public bool SprawdzPoprawnoscEmail(string email)
        {
            Regex wzorzec = new Regex("([\\w&#_]{1,10}@[a-z0-9]{2,10}\\.[a-z0-9]{2,3})");
            Match match = wzorzec.Match(email);
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

        public bool SprawdzPoprawnoscNrTel(string nr_tel)
        {
            Regex wzorzec = new Regex("^(\\+48)?[4-9]\\d{8}$");
            Match match = wzorzec.Match(nr_tel);
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
