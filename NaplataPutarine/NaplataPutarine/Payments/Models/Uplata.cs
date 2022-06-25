using NaplataPutarine.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Payments.Models
{
    internal abstract class Uplata
    {
        public int id { get; set; }
        public DateOnly datumIzgradnje { get; set; }
        public double iznos { get; set; }
        public ValutaEnum.Valuta valuta { get; set; }
        public NaplatnoMesto mestoUplate { get; set; }

        protected Uplata(int id, DateOnly datumIzgradnje, double iznos, ValutaEnum.Valuta valuta, NaplatnoMesto mestoUplate)
        {
            this.id = id;
            this.datumIzgradnje = datumIzgradnje;
            this.iznos = iznos;
            this.valuta = valuta;
            this.mestoUplate = mestoUplate;
        }
    }
}
