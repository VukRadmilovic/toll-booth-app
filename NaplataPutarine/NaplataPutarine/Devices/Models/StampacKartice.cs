using NaplataPutarine.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Devices.Models
{
    internal class StampacKartice : Uredjaj
    {
        public StampacKartice(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {

        }

        public void odstampajKarticu()
        {

        }
    }
}
