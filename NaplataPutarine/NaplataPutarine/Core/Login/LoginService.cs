using NaplataPutarine.Core.Users.Models;

namespace NaplataPutarine.Core.Login
{
    internal class LoginService
    {
        private readonly SistemZaNaplatuPutarine _system;
        public LoginService()
        {
            _system = SistemZaNaplatuPutarine.GetInstance();
        }

        public void Login(string username, string password)
        {
            Radnik logged = GetByKorisnickoIme(username);
            switch(logged.Nalog.Uloga)
            {
                case UlogaEnum.Uloga.SEF_STANICE:
                    new GUI.TollStationChief.Main(logged).Show(); break;
                case UlogaEnum.Uloga.MENADZER:
                    new GUI.GeneralManager.Main(logged).Show(); break;
                case UlogaEnum.Uloga.RADNIK_MESTA:
                    new GUI.Worker.Main(logged).Show(); break;
            }
        }

        public Radnik? GetByKorisnickoIme(string korisnickoIme)
        {
            return _system.Radnici.FirstOrDefault(radnik => radnik.Nalog.KorisnickoIme.Equals(korisnickoIme));
        }

    }
}
