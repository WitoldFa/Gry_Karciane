using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gry_Karciane
{
    class Class1
    {
        public class Gracz
        {
            public string Nazwa { get; set; }
            public int LiczbaKart { get; set; }
            public int ZdobyteKarty { get; set; }
            public string AktualnaKarta { get; set; }
            public List<Karta> KartyNaRece { get; set; } = new List<Karta>();
        }
    }
}
