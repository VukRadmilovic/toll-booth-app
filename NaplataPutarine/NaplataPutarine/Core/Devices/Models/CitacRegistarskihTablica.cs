using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices.Models
{
    internal class CitacRegistarskihTablica : Uredjaj
    {
        public CitacRegistarskihTablica(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {

        }

        public void OcitajTablicu()
        {

        }
    }
}
