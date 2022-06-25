using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Users.Models
{
    internal class Korisnik
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public KorisnickiNalog nalog { get; set; }

        public Korisnik(int id, string ime, string prezime, KorisnickiNalog nalog)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.nalog = nalog;
        }
    }
}
