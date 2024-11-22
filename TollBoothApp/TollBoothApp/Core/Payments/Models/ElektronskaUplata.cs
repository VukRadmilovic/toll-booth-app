using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Payments.Models
{
    internal class ElektronskaUplata : Uplata
    {

        public Tag Tag { get; set; }

        public ElektronskaUplata(int id,
                                 DateOnly datumIzgradnje,
                                 double iznos,
                                 ValutaEnum.Valuta valuta,
                                 NaplatnoMesto mestoUplate,
                                 Tag tag) : base(id, datumIzgradnje, iznos, valuta, mestoUplate)
        {
            Tag = tag;
        }

    }
}
