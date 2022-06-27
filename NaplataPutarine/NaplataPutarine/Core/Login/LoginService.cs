using NaplataPutarine.Core.Users.Models;
using NaplataPutarine.GUI.TollStationChief;

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
                    new Main(logged).Show();break;
            }
        }

        public Radnik? GetByKorisnickoIme(string korisnickoIme)
        {
            return _system.Radnici.FirstOrDefault(radnik => radnik.Nalog.KorisnickoIme.Equals(korisnickoIme));
        }

    }
}
