using NaplataPutarine.Payments.Models;
using NaplataPutarine.Prices.Models;
using NaplataPutarine.TollStations.Models;
using NaplataPutarine.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core
{
    internal class SistemZaNaplatuPutarine
    {
        public List<Korisnik> korisnici { get; private set; }
        public List<Uplata> uplate { get; private set; }
        public List<Tag> tagovi { get; private set; }
        public List<NaplatnaStanica> naplatneStanice { get; private set; }
        public List<Deonica> deonice { get; private set; }
        public Cenovnik cenovnik { get; private set; }
        public List<Kartica> kartice { get; private set; }

        public string generisiIzvestaj(string type)
        {
            throw new NotImplementedException();
        }

        public NaplatnaStanica registrujNaplatnuStanicu()
        {
            throw new NotImplementedException();
        }

        public Deonica getDeonica(NaplatnaStanica start, NaplatnaStanica kraj)
        {
            throw new NotImplementedException();
        }


    }
}
