using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothApp.Core.Payments.Models
{
    internal class Kartica
    {
        public DateTime datumVremeIzdavanja { get; set; }
        public string registarskaOznakaVozila { get; set; }
        public int naplatnoMesto { get; set; }

        public Kartica(DateTime datumVremeIzdavanja, string registarskaOznakaVozila, int naplatnoMesto)
        {
            this.datumVremeIzdavanja = datumVremeIzdavanja;
            this.registarskaOznakaVozila = registarskaOznakaVozila;
            this.naplatnoMesto = naplatnoMesto;
        }
    }
}
