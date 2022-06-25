using NaplataPutarine.Payments.Models;
using NaplataPutarine.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Devices.Models
{
    internal class CitacTaga : Uredjaj
    {
        public CitacTaga(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {
        }

        public List<Tag> tagovi { get; set; }

        public Tag ocitajTag()
        {
            throw new NotImplementedException();
        }


    }
}
