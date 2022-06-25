using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Users.Models
{
    internal class KorisnickiNalog
    {
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        public UlogaEnum.Uloga uloga { get; set; }


        public void promenaLozinke()
        {

        }

        public KorisnickiNalog(string korisnickoIme, string lozinka, UlogaEnum.Uloga uloga)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.uloga = uloga;
        }
    }
}
