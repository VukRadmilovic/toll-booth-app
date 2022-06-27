using NaplataPutarine.Core.Database;
using NaplataPutarine.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Login
{
    internal class LoginController
    {
        private readonly LoginService _loginService;
        
        public LoginController()
        {
            _loginService = new LoginService();
        }

        public string? ValidateLoginCredentials(string username, string password)
        {
            string error_message = null;

            if (string.IsNullOrEmpty(username))
            {
                error_message = "Korisničko ime nije uneto!";
            }

            else if (string.IsNullOrEmpty(password))
            {

                error_message = "Lozinka nije uneta!";
            }

            else if (_loginService.GetByKorisnickoIme(username) == null)
            {
                error_message = "Ne postoji korisnik sa unetim korisničkim imenom!";
            }

            else if (!_loginService.GetByKorisnickoIme(username).Nalog.Lozinka.Equals(password))
            {
                error_message = "Lozinka neispravna!";
            }

            return error_message;

        }

        public void Login(string email, string password)
        {
            string errorMessage = ValidateLoginCredentials(email, password);
            if (errorMessage != null)
            {
                throw new InvalidInputException(errorMessage);
            }
            _loginService.Login(email, password);
        }
    }
}
