using NaplataPutarine.Devices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.TollStations.Models
{
    internal class NaplatnoMesto
    {
        public int id { get; set; }
        public NaplatnaStanica maticnaNaplatnaStanica { get; set; }
        public List<Uredjaj> uredjaji { get; set; }

        public NaplatnoMesto(int id, NaplatnaStanica maticnaNaplatnaStanica, List<Uredjaj> uredjaji)
        {
            this.id = id;
            this.maticnaNaplatnaStanica = maticnaNaplatnaStanica;
            this.uredjaji = uredjaji;
        }

        public void prijaviKvarNaUredjaju(Uredjaj uredjaj)
        {

        }
    }
}
