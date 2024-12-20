﻿using TollBoothApp.Core;
using TollBoothApp.Core.Database;
using TollBoothApp.Core.Login;

namespace TollBoothApp.GUI
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
                Hide();
                _loginController.Login(email, password);
            }
            catch (DatabaseConnectionException error)
            {
                MessageBox.Show(error.Message);
            }
            catch(InvalidInputException error)
            {
                MessageBox.Show(error.Message);
            }
            Show();
        }

    }
}