using NaplataPutarine.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.TollStations.Models
{
    internal class NaplatnaStanica
    {
        public int id { get; set; }
        public string naziv { get; set; }
        public string mesto { get; set; }
        public DateOnly datumIzgradnje { get; set; }
        public Radnik sefStanice { get; set; }
        List<Radnik> radnici { get; set; }
        List<NaplatnoMesto> naplatnaMesta { get; set; }

        public NaplatnaStanica(int id,
                               string naziv,
                               string mesto,
                               DateOnly datumIzgradnje,
                               Radnik sefStanice,
                               List<Radnik> radnici,
                               List<NaplatnoMesto> naplatnaMesta)
        {
            this.id = id;
            this.naziv = naziv;
            this.mesto = mesto;
            this.datumIzgradnje = datumIzgradnje;
            this.sefStanice = sefStanice;
            this.radnici = radnici;
            this.naplatnaMesta = naplatnaMesta;
        }

        public NaplatnoMesto registrujNaplatnoMesto()
        {
            throw new NotImplementedException();
        }
         
    }
}
