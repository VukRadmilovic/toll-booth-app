using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Prices.Models;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Devices.Models
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
