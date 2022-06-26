using NaplataPutarine.Core.Database;
using NaplataPutarine.Core.Login;
using NaplataPutarine.Core.Utilities;

namespace NaplataPutarine.Login
{
    public partial class LoginPage : Form
    {
        private readonly LoginController loginController;
        public LoginPage()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void LoginButton_Click(object sender, EventArgs e) => TryLogin(usernameField.Text.Trim(),passwordField.Text.Trim());

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void TryLogin(string email, string password)
        {
            try
            {
                string error_message = loginController.ValidateLoginCredentials(email, password);

                if (error_message != null)
                {
                    MessageBoxUtilities.ShowErrorMessage(error_message);
                    return;
                }
                loginController.Login(email, password);
                Hide();
            }
            catch (DatabaseConnectionException error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}