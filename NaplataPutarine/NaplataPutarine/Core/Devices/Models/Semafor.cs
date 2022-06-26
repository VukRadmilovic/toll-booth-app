using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices.Models
{
    internal class Semafor : Uredjaj
    {
        public Semafor(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
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
