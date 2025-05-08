using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gry_Karciane
{
    class Karta
    {
        public string Kolor { get; set; }
        public string Wartosc { get; set; }
        public int WartoscNumeryczna { get; set; }

        public override string ToString()
        {
            return $"{Wartosc}{Kolor}";
        }
    }
}
