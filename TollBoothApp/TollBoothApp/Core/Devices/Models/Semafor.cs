using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Devices.Models
{
    internal class Semafor : Uredjaj
    {
        public Semafor(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {

        }

        public Semafor() : base()
        {

        }

        public void UpaliCrveno()
        {

        }

        public void UpaliZeleno()
        {

        }
    }
}
