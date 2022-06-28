using NaplataPutarine.Core.Users.Models;
using NaplataPutarine.GUI.TollStationChief.Forms;
using NaplataPutarine.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaplataPutarine.GUI.TollStationChief
{
    internal partial class Main : Form
    {
        private readonly Radnik _logged;
        public Main(Radnik logged)
        {
            InitializeComponent();
            _logged = logged;
            stationInfo.Text = logged.MestoRada.Naziv + " ( ID: " + logged.MestoRada.Id + ")";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            new LoginPage().Show();
        }

        private void DeviceStateButton_Click(object sender, EventArgs e)
        {
            new DeviceStates(_logged.MestoRada).Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            new EarningsReport(_logged.MestoRada).Show(); 
        }
    }
}
