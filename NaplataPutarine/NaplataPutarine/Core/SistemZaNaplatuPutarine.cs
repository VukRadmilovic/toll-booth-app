using NaplataPutarine.Core.Devices;
using NaplataPutarine.Core.Payments.Models;
using NaplataPutarine.Core.Prices.Models;
using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.TollStations.Repositories;
using NaplataPutarine.Core.Users;
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
        public List<Radnik> Radnici { get; private set; }
        public List<Uplata> Uplate { get; private set; }
        public List<Tag> Tagovi { get; private set; }
        public List<NaplatnaStanica> NaplatneStanice { get; private set; }
        public List<Deonica> Deonice { get; private set; }
        public Cenovnik Cenovnik { get; private set; }
        public List<Kartica> Kartice { get; private set; }

        private readonly KorisnikRepository _korisnikRepo;
        private readonly NaplatnaStanicaRepository _stanicaRepo;
        private static SistemZaNaplatuPutarine? instance;

        public static SistemZaNaplatuPutarine GetInstance()
        {
            if (instance == null)
            {
                instance = new SistemZaNaplatuPutarine();
            }
            return instance;
        }

        private SistemZaNaplatuPutarine()
        {
            _korisnikRepo = new KorisnikRepository();
            _stanicaRepo = new NaplatnaStanicaRepository();
            Radnici = _korisnikRepo.GetAllWorkers();
            NaplatneStanice = _stanicaRepo.GetAllTollStations();
        }
        
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
