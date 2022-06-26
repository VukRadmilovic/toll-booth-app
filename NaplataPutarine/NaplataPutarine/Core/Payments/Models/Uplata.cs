using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Payments.Models
{
    internal abstract class Uplata
    {
        public int Id { get; set; }
        public DateOnly DatumIzgradnje { get; set; }
        public double Iznos { get; set; }
        public ValutaEnum.Valuta Valuta { get; set; }
        public NaplatnoMesto MestoUplate { get; set; }

        protected Uplata(int id, DateOnly datumIzgradnje, double iznos, ValutaEnum.Valuta valuta, NaplatnoMesto mestoUplate)
        {
            Id = id;
            DatumIzgradnje = datumIzgradnje;
            Iznos = iznos;
            Valuta = valuta;
            MestoUplate = mestoUplate;
        }
    }
}
