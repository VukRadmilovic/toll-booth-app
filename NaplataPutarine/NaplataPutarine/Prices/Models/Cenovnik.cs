using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Prices.Models
{
    internal class Cenovnik
    {
        public List<Cena> cene { get; set; }

        public void izmeniCenu(Cena cena)
        {

        }

        public Cena getCena(Deonica d, KategorijaVozila kv)
        {
            throw new NotImplementedException();
        }
    }
}
