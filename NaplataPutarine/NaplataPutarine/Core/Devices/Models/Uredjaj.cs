using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices.Models
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
