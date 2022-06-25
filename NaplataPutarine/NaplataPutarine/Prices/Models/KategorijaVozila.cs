using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Prices.Models
{
    internal class KategorijaVozila
    {
        public int id { get; set; }
        public string naziv { get; set; }

        public KategorijaVozila(int id, string naziv)
        {
            this.id = id;
            this.naziv = naziv;
        }
    }
}
