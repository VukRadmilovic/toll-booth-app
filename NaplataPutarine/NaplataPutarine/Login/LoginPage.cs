using NaplataPutarine.Core.Database;
using NaplataPutarine.Core.Utilities;
using NaplataPutarine.Login.Services;

namespace NaplataPutarine
{
    public partial class LoginPage : Form
    {
        private readonly LoginService loginService;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e) => TryLogin();

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void TryLogin()
        {
            try
            {
                string error_message = ValidateLoginCredentials(usernameField.Text.Trim(), passwordField.Text.Trim());
                
                if (error_message != null)
                {
                    MessageBoxUtilities.ShowErrorMessage(error_message);
                    return;
                }
                loginService.Login(usernameField.Text.Trim(), passwordField.Text.Trim());
                Hide();
            }
            catch (DatabaseConnectionException error)
            {
                MessageBox.Show(error.Message);
            }
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
    }
}