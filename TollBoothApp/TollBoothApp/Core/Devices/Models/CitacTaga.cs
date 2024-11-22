using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Payments.Models;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Devices.Models
{
    internal class CitacTaga : Uredjaj
    {
        public CitacTaga(int id, bool ispravan, NaplatnoMesto mesto) : base(id, ispravan, mesto)
        {

        }

        public CitacTaga() : base()
        {

        }

        public List<Tag> Tagovi { get; private set; }

        public Tag OcitajTag()
        {
            throw new NotImplementedException();
        }


    }
}
