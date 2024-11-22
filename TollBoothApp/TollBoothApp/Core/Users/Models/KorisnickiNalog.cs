using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothApp.Core.Users.Models
{
    internal class KorisnickiNalog
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public UlogaEnum.Uloga Uloga { get; set; }


        public void PromenaLozinke()
        {

        }

        public KorisnickiNalog(string korisnickoIme, string lozinka, UlogaEnum.Uloga uloga)
        {
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Uloga = uloga;
        }
    }
}
