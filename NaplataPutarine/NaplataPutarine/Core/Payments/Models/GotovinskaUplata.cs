using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Payments.Models
{
    internal class GotovinskaUplata : Uplata
    {
        public Radnik IzvrsniRadnik { get; set; }

        public GotovinskaUplata(int id,
                                DateOnly datumIzgradnje,
                                double iznos,
                                ValutaEnum.Valuta valuta,
                                NaplatnoMesto mestoUplate,
                                Radnik izvrsniRadnik) : base(id, datumIzgradnje, iznos, valuta, mestoUplate)
        {
            IzvrsniRadnik = izvrsniRadnik;
        }




    }
}
