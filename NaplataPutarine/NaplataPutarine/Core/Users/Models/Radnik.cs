using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Users.Models
{
    internal class Radnik : Korisnik
    {
        public Radnik(int id) : base(id)
        {
        }

        public Radnik(int id,
                      string ime,
                      string prezime,
                      KorisnickiNalog nalog,
                      NaplatnaStanica mestoRada) : base(id, ime, prezime, nalog)
        {
            MestoRada = mestoRada;
        }



        public NaplatnaStanica? MestoRada { get; set; }


    }
}
