using NaplataPutarine.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Devices.Models
{
    internal abstract class Uredjaj
    {
        public int id { get; set; }
        public bool ispravan { get; set; }
        public NaplatnoMesto naplatnoMestoUredjaja { get; set; }

        protected Uredjaj(int id, bool ispravan, NaplatnoMesto mesto)
        {
            this.id = id;
            this.ispravan = ispravan;
            naplatnoMestoUredjaja = mesto;
        }


        public void izmeniStanjeIspravnosti(bool ispravnost)
        {
            ispravan = ispravnost;
        }
    }
}
