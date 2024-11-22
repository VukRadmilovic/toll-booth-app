using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.TollStations.Models;
using TollBoothApp.Core.Users.Models;

namespace TollBoothApp.Core.Payments.Models
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
