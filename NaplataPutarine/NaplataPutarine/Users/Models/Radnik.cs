using NaplataPutarine.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Users.Models
{
    internal class Radnik : Korisnik
    {
        public Radnik(int id,
                      string ime,
                      string prezime,
                      KorisnickiNalog nalog,
                      NaplatnaStanica mestoRada) : base(id, ime, prezime, nalog)
        {
            this.mestoRada = mestoRada;
        }

        public NaplatnaStanica mestoRada { get; set; }


    }
}
