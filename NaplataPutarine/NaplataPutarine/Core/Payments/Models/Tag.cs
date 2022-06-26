using NaplataPutarine.Core.Prices.Models;
using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Payments.Models
{
    internal class Tag
    {
        public int Id { get; set; }
        public ValutaEnum.Valuta Valuta { get; set; }
        public double TrenutnoStanje { get; set; }
        public Korisnik Vlasnik { get; set; }
        public KategorijaVozila KategorijaVozila { get; set; }
        public NaplatnaStanica PoslednjaStanica { get; set; }

        public void SkiniIznos(double iznos)
        {

        }

        public Tag(int id,
                   ValutaEnum.Valuta valuta,
                   double trenutnoStanje,
                   Korisnik vlasnik,
                   KategorijaVozila kategorija,
                   NaplatnaStanica poslednjaStanica)
        {
            Id = id;
            Valuta = valuta;
            TrenutnoStanje = trenutnoStanje;
            Vlasnik = vlasnik;
            KategorijaVozila = kategorija;
            PoslednjaStanica = poslednjaStanica;
        }
    }
}
