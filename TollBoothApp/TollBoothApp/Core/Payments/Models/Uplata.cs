using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Payments.Models
{
    internal abstract class Uplata
    {
        public int Id { get; set; }
        public DateOnly DatumUplate { get; set; }
        public double Iznos { get; set; }
        public ValutaEnum.Valuta Valuta { get; set; }
        public NaplatnoMesto MestoUplate { get; set; }

        protected Uplata(int id, DateOnly datumIzgradnje, double iznos, ValutaEnum.Valuta valuta, NaplatnoMesto mestoUplate)
        {
            Id = id;
            DatumUplate = datumIzgradnje;
            Iznos = iznos;
            Valuta = valuta;
            MestoUplate = mestoUplate;
        }
    }
}
