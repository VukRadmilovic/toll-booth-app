using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices.Models
{
    internal class SkenerKartice : Uredjaj
    {
        public SkenerKartice(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {
            //TODO: ucitati listu izdatih kartica 
        }

        public SkenerKartice() : base()
        {

        }

        public List<Kartica> Kartice { get; private set; }

        public Kartica SkenirajKarticu()
        {
            throw new NotImplementedException(); //TODO: menjati na random dobijanje iz liste
        }
    }
}
