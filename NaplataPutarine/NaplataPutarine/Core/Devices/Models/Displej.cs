using NaplataPutarine.Core.Prices.Models;
using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices.Models
{
    internal class Displej : Uredjaj
    {
        public Displej(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {

        }

        public Displej() : base()
        {

        }

        public void PrikaziCenu(Cena cena)
        {

        }

        public void OcistiPrikaz()
        {

        }
    }
}
