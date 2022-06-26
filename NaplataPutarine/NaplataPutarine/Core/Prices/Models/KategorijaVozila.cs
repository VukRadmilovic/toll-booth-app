using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Prices.Models
{
    internal class KategorijaVozila
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public KategorijaVozila(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }
    }
}
