using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.TollStations.Models
{
    internal class Kartica
    {
        public int id { get; set; }
        public DateTime datumVremeIzdavanja { get; set; }
        public string registarskaOznakaVozila { get; set; }
        public NaplatnoMesto mestoNaplate { get; set; }

        public Kartica(int id, DateTime datumVremeIzdavanja, string registarskaOznakaVozila, NaplatnoMesto mestoNaplate)
        {
            this.id = id;
            this.datumVremeIzdavanja = datumVremeIzdavanja;
            this.registarskaOznakaVozila = registarskaOznakaVozila;
            this.mestoNaplate = mestoNaplate;
        }
    }
}
