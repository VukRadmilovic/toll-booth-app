using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.TollStations.Models
{
    internal class Kartica
    {
        public int Id { get; set; }
        public DateTime DatumVremeIzdavanja { get; set; }
        public string RegistarskaOznakaVozila { get; set; }
        public NaplatnoMesto MestoNaplate { get; set; }

        public Kartica(int id, DateTime datumVremeIzdavanja, string registarskaOznakaVozila, NaplatnoMesto mestoNaplate)
        {
            Id = id;
            DatumVremeIzdavanja = datumVremeIzdavanja;
            RegistarskaOznakaVozila = registarskaOznakaVozila;
            MestoNaplate = mestoNaplate;
        }
    }
}
