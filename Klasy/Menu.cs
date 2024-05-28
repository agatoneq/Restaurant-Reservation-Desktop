using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_rezerwacji
{
    public class Menu
    {
        private List<string> zupy = new List<string>();
        private List<string> gorace_danie1 = new List<string>();
        private List<string> gorace_danie2 = new List<string>();
        private List<string> przekaski = new List<string>();
        private List<string> deser = new List<string>();
        private List<string> tort = new List<string>();
        private List<string> napoje = new List<string>();

        public List<string> Zupy { get => zupy; set => zupy = value; }
        public List<string> Gorace_danie1 { get => gorace_danie1; set => gorace_danie1 = value; }
        public List<string> Gorace_danie2 { get => gorace_danie2; set => gorace_danie2 = value; }
        public List<string> Przekaski { get => przekaski; set => przekaski = value; }
        public List<string> Deser { get => deser; set => deser = value; }
        public List<string> Tort { get => tort; set => tort = value; }
        public List<string> Napoje { get => napoje; set => napoje = value; }

        public void wczytaj_plik(string plik)
        {
            List<string> linie = File.ReadAllLines(plik).ToList();

            int index = 0;
            while (index < linie.Count)
            {
                if (linie[index].StartsWith("Zupy:"))
                {
                    zupy = wczytaj_sekcje(linie, index + 1);
                    index += zupy.Count + 1;
                }
                else if (linie[index].StartsWith("I Danie gorące:"))
                {
                    gorace_danie1 = wczytaj_sekcje(linie, index + 1);
                    index += gorace_danie1.Count + 1;
                }
                else if (linie[index].StartsWith("II Danie gorące:"))
                {
                    gorace_danie2 = wczytaj_sekcje(linie, index + 1);
                    index += gorace_danie2.Count + 1;
                }
                else if (linie[index].StartsWith("Przekąski zimne:"))
                {
                    przekaski = wczytaj_sekcje(linie, index + 1);
                    index += przekaski.Count + 1;
                }
                else if (linie[index].StartsWith("Deser:"))
                {
                    deser = wczytaj_sekcje(linie, index + 1);
                    index += deser.Count + 1;
                }
                else if (linie[index].StartsWith("Tort:"))
                {
                    tort = wczytaj_sekcje(linie, index + 1);
                    index += tort.Count + 1;
                }
                else if (linie[index].StartsWith("Stolik kawowy:"))
                {
                    napoje = wczytaj_sekcje(linie, index + 1);
                    index += napoje.Count + 1;
                }
                else
                {
                    index++;
                }
            }
        }

        private List<string> wczytaj_sekcje(List<string> linie, int poczatek)
        {
            List<string> sekcja = new List<string>();

            for (int i = poczatek; i < linie.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(linie[i]))
                {
                    break; //Koniec sekcji
                }

                sekcja.Add(linie[i]);
            }

            return sekcja;
        }
        public string wyswietl()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Menu:");

            sb.AppendLine("Zupy:");
            foreach (string zupa in Zupy)
                sb.AppendLine(zupa);

            sb.AppendLine("I Danie gorące:");
            foreach (string danie in Gorace_danie1)
                sb.AppendLine(danie);

            sb.AppendLine("II Danie gorące:");
            foreach (string danie in Gorace_danie2)
                sb.AppendLine(danie);

            sb.AppendLine("Przekąski zimne:");
            foreach (string przekaska in Przekaski)
                sb.AppendLine(przekaska);

            sb.AppendLine("Deser:");
            foreach (string deser in Deser)
                sb.AppendLine(deser);

            sb.AppendLine("Tort:");
            foreach (string tort in Tort)
                sb.AppendLine(tort);

            sb.AppendLine("Stolik kawowy:");
            foreach (string napoj in Napoje)
                sb.AppendLine(napoj);

            return sb.ToString();
        }

    }
}
