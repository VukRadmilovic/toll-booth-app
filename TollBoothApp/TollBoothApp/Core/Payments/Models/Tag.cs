using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Prices.Models;
using TollBoothApp.Core.TollStations.Models;
using TollBoothApp.Core.Users.Models;

namespace TollBoothApp.Core.Payments.Models
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

        public Tag(int id)
        {
            Id = id;
        }
    }
}
