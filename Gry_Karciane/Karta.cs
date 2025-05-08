using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gry_Karciane
{
    public class Karta
    {
        public string Kolor { get; set; } // np. "Kier", "Pik", "Trefl", "Karo"
        public string Wartosc { get; set; } // np. "2", "3", ..., "K", "A"

        public int PobierzWartosc()
        {
            if (int.TryParse(Wartosc, out int wartoscNumeryczna))
                return wartoscNumeryczna; // Dla kart 2-10
            if (Wartosc == "A")
                return 11; // As domyślnie ma wartość 11
            return 10; // Dla figur (J, Q, K)
        }

        public override string ToString()
        {
            return $"{Wartosc} {Kolor}";
        }
    }
}
