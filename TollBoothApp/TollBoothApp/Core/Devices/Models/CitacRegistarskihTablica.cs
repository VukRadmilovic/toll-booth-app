using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Devices.Models
{
    internal class CitacRegistarskihTablica : Uredjaj
    {
        public CitacRegistarskihTablica(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {

        }
        
        public CitacRegistarskihTablica() : base()
        {

        }

        public void OcitajTablicu()
        {

        }
    }
}
