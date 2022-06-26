using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Prices.Models
{
    internal class Cena
    {
        public double Vrednost { get; set; }
        public DateOnly DatumKreiranja { get; set; }
        public KategorijaVozila Kategorija { get; set; }
        public Deonica Deonica { get; set; }

        public Cena(double vrednost, DateOnly datumKreiranja, KategorijaVozila kategorija, Deonica deonica)
        {
            Vrednost = vrednost;
            DatumKreiranja = datumKreiranja;
            Kategorija = kategorija;
            Deonica = deonica;
        }
    }
}
