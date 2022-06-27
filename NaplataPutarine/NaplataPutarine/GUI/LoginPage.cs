using NaplataPutarine.Core.Database;
using NaplataPutarine.Core.Login;
using NaplataPutarine.Core.Utilities;

namespace NaplataPutarine.Login
{
    public partial class LoginPage : Form
    {
        private readonly LoginController _loginController;
        public LoginPage()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }

        private void LoginButton_Click(object sender, EventArgs e) => TryLogin(usernameField.Text.Trim(),passwordField.Text.Trim());

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        private void TryLogin(string email, string password)
        {
            try
            {
                _loginController.Login(email, password);
                Hide();
            }
            catch (DatabaseConnectionException error)
            {
                MessageBox.Show(error.Message);
            }
            catch(InvalidInputException error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}