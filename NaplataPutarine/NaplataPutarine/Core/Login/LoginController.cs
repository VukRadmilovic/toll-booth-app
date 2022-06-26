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
        private readonly LoginService loginService;
        
        public LoginController()
        {
            loginService = new LoginService();
        }

        public string? ValidateLoginCredentials(string email, string password)
        {
            string error_message = null;

            if (string.IsNullOrEmpty(email))
            {
                error_message = "Korisničko ime nije uneto!";
            }

            else if (string.IsNullOrEmpty(password))
            {

                error_message = "Lozinka nije uneta!";
            }

            /*else if (userService.GetByEmail(email) == null)
            {
                error_message = "There is no user with specified email!";
            }

            else if (!userService.GetByEmail(email).password.Equals(password))
            {
                error_message = "Password does not match email!";
            }*/

            return error_message;

        }

        public void Login(string email, string password)
        {
            loginService.Login(email, password);
        }
    }
}
