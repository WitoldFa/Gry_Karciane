using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gry_Karciane
{
    public class Talia
    {
        private List<Karta> karty;
        private static readonly string[] Kolory = { "Kier", "Pik", "Trefl", "Karo" };
        private static readonly string[] Wartosc = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        public Talia()
        {
            karty = new List<Karta>();
            foreach (var kolor in Kolory)
            {
                foreach (var wartosc in Wartosc)
                {
                    karty.Add(new Karta { Kolor = kolor, Wartosc = wartosc });
                }
            }
            Potasuj();
        }

        public void Potasuj()
        {
            var random = new Random();
            karty = karty.OrderBy(x => random.Next()).ToList();
        }

        public Karta RozdajKarte()
        {
            if (karty.Count == 0)
                throw new InvalidOperationException("Talia jest pusta!");
            var karta = karty[0];
            karty.RemoveAt(0);
            return karta;
        }
    }
}
