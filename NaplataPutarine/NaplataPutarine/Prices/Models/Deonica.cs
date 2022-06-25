using NaplataPutarine.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Prices.Models
{
    internal class Deonica
    {
        public int id { get; set; }
        public double duzina { get; set; }
        public NaplatnaStanica pocetnaStanica { get; set; }
        public NaplatnaStanica zavrsnaStanica { get; set; }

        public Deonica(int id, double duzina, NaplatnaStanica pocetnaStanica, NaplatnaStanica zavrsnaStanica)
        {
            this.id = id;
            this.duzina = duzina;
            this.pocetnaStanica = pocetnaStanica;
            this.zavrsnaStanica = zavrsnaStanica;
        }
    }
}
