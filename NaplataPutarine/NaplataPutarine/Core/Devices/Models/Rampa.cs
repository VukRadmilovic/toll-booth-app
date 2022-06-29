using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices.Models
{
    internal class Rampa : Uredjaj
    {
        public Rampa(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {

        }

        public Rampa() : base()
        {

        }

        public void PodigniRampu()
        {

        }

        public void SpustiRampu()
        {

        }
    }
}
