using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Devices.Models
{
    internal class StampacKartice : Uredjaj
    {
        public StampacKartice(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {

        }

        public StampacKartice() : base()
        {

        }

        public void OdstampajKarticu()
        {

        }
    }
}
