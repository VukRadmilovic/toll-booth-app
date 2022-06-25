using NaplataPutarine.Prices.Models;
using NaplataPutarine.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Devices.Models
{
    internal class Displej : Uredjaj
    {
        public Displej(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {

        }

        public void prikaziCenu(Cena cena)
        {

        }

        public void ocistiPrikaz()
        {

        }
    }
}
