using NaplataPutarine.TollStations.Models;
using NaplataPutarine.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Payments.Models
{
    internal class GotovinskaUplata : Uplata
    {
        public Radnik izvrsniRadnik { get; set; }

        public GotovinskaUplata(int id,
                                DateOnly datumIzgradnje,
                                double iznos,
                                ValutaEnum.Valuta valuta,
                                NaplatnoMesto mestoUplate,
                                Radnik izvrsniRadnik) : base(id, datumIzgradnje, iznos, valuta, mestoUplate)
        {
            this.izvrsniRadnik = izvrsniRadnik;
        }

       

        
    }
}
