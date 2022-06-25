using NaplataPutarine.Prices.Models;
using NaplataPutarine.TollStations.Models;
using NaplataPutarine.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Payments.Models
{
    internal class Tag
    {
        public int id { get; set; }
        public ValutaEnum.Valuta valuta { get; set; }
        public double trenutnoStanje { get; set; }
        public Korisnik vlasnik { get; set; }
        public KategorijaVozila kategorijaVozila { get; set; }
        public NaplatnaStanica poslednjaStanica { get; set; }

        public void skiniIznos(double iznos)
        {

        }

        public Tag(int id,
                   ValutaEnum.Valuta valuta,
                   double trenutnoStanje,
                   Korisnik vlasnik,
                   KategorijaVozila kategorija,
                   NaplatnaStanica poslednjaStanica)
        {
            this.id = id;
            this.valuta = valuta;
            this.trenutnoStanje = trenutnoStanje;
            this.vlasnik = vlasnik;
            this.kategorijaVozila = kategorija;
            this.poslednjaStanica = poslednjaStanica;
        }
    }
}
