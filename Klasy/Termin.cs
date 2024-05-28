using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_rezerwacji
{
    public class Termin
    {
        private string data;
        private int godzina=00;
        private string minuty="00";

        public string Data { get => data; set => data = value; }
        public int Godzina { get => godzina; set => godzina = value; }
        public string Minuty { get => minuty; set => minuty = value; }

        public string wyswietl()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(data + " " + godzina.ToString() + ":" + minuty);

            return sb.ToString();
        }

        public DateTime zamien_na_DateTime()
        {
            DateTime term = DateTime.Parse(wyswietl());
            return term;
        }

    }
}
