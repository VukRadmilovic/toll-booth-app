using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Prices.Models
{
    internal class Cenovnik
    {
        public List<Cena> Cene { get; set; }

        public void IzmeniCenu(Cena cena)
        {

        }

        public Cena GetCena(Deonica d, KategorijaVozila kv)
        {
            throw new NotImplementedException();
        }
    }
}
