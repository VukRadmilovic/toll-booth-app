using NaplataPutarine.Core.Devices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.TollStations.Models
{
    internal class NaplatnoMesto
    {
        public int Id { get; set; }
        public NaplatnaStanica MaticnaNaplatnaStanica { get; set; }
        public List<Uredjaj> Uredjaji { get; set; }

        public NaplatnoMesto(int id, NaplatnaStanica maticnaNaplatnaStanica, List<Uredjaj> uredjaji)
        {
            Id = id;
            MaticnaNaplatnaStanica = maticnaNaplatnaStanica;
            Uredjaji = uredjaji;
        }

        public void PrijaviKvarNaUredjaju(Uredjaj uredjaj)
        {

        }
    }
}
