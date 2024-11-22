using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Devices.Models
{
    internal abstract class Uredjaj
    {
        
        public int Id { get; set; }
        public bool Ispravan { get; set; }
        public NaplatnoMesto NaplatnoMestoUredjaja { get; set; }

        protected Uredjaj(int id, bool ispravan, NaplatnoMesto mesto)
        {
            Id = id;
            Ispravan = ispravan;
            NaplatnoMestoUredjaja = mesto;
        }

        protected Uredjaj()
        {

        }
    }
}
