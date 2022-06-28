using NaplataPutarine.Core.Users.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaplataPutarine.GUI.Worker
{
    internal partial class Main : Form
    {
        private readonly Radnik _radnik;

        public Main(Radnik radnik)
        {
            InitializeComponent();
            _radnik = radnik;
        }

        private void UredjajiButton_Click(object sender, EventArgs e)
        {
            new Uredjaji(_radnik.MestoRada).Show();
        }
    }
}
