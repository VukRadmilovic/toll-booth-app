using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Users.Models
{
    internal class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public KorisnickiNalog Nalog { get; set; }

        public Korisnik(int id, string ime, string prezime, KorisnickiNalog nalog)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Nalog = nalog;
        }
    }
}
