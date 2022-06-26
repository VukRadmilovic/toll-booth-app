using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Prices.Models
{
    internal class Deonica
    {
        public int Id { get; set; }
        public double Duzina { get; set; }
        public NaplatnaStanica PocetnaStanica { get; set; }
        public NaplatnaStanica ZavrsnaStanica { get; set; }

        public Deonica(int id, double duzina, NaplatnaStanica pocetnaStanica, NaplatnaStanica zavrsnaStanica)
        {
            Id = id;
            Duzina = duzina;
            PocetnaStanica = pocetnaStanica;
            ZavrsnaStanica = zavrsnaStanica;
        }
    }
}
