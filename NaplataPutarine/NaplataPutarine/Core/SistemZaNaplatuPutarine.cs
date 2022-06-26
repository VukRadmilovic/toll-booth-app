using NaplataPutarine.Core.Payments.Models;
using NaplataPutarine.Core.Prices.Models;
using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core
{
    internal class SistemZaNaplatuPutarine
    {
        public List<Korisnik> Korisnici { get; private set; }
        public List<Uplata> Uplate { get; private set; }
        public List<Tag> Tagovi { get; private set; }
        public List<NaplatnaStanica> NaplatneStanice { get; private set; }
        public List<Deonica> Deonice { get; private set; }
        public Cenovnik Cenovnik { get; private set; }
        public List<Kartica> Kartice { get; private set; }

        public string GenerisiIzvestaj(string type)
        {
            throw new NotImplementedException();
        }

        public NaplatnaStanica RegistrujNaplatnuStanicu()
        {
            throw new NotImplementedException();
        }

        public Deonica GetDeonica(NaplatnaStanica start, NaplatnaStanica kraj)
        {
            throw new NotImplementedException();
        }


    }
}
