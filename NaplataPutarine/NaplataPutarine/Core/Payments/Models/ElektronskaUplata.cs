using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Payments.Models
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
