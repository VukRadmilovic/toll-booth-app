using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Prices.Models
{
    internal class Cena
    {
        public double vrednost { get; set; }
        public DateOnly datumKreiranja { get; set; }
        public KategorijaVozila kategorija { get; set; }
        public Deonica deonica { get; set; }

        public Cena(double vrednost, DateOnly datumKreiranja, KategorijaVozila kategorija, Deonica deonica)
        {
            this.vrednost = vrednost;
            this.datumKreiranja = datumKreiranja;
            this.kategorija = kategorija;
            this.deonica = deonica;
        }
    }
}
