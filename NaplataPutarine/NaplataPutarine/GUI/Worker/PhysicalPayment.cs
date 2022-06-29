using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NaplataPutarine.Core;
using NaplataPutarine.Core.Payments;
using NaplataPutarine.Core.Payments.Models;
using NaplataPutarine.Core.Devices;
using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.Devices.Models;
using NaplataPutarine.Core.Utilities;

namespace NaplataPutarine.GUI.Worker
{
    internal partial class PhysicalPayment : Form
    {
        List<Core.Payments.Models.Kartica> cards;
        private readonly NaplatnaStanica naplatnaStanica;
        PaymentController paymentController;
        UredjajService service;
        DateTime stop;

        public PhysicalPayment(NaplatnaStanica mestoRada)
        {
            service = new UredjajService();
            naplatnaStanica = mestoRada;
            paymentController = new PaymentController();
            InitializeComponent();
        }

        private void PhysicalPayment_Load(object sender, EventArgs e)
        {
            cards = paymentController.GetCards();
            mestoBox.Text = naplatnaStanica.Id.ToString();
            catCombo.Items.Clear();
            foreach (EnhancedComboBoxItem item in paymentController.GetCat())
            {
                catCombo.Items.Add(item);
            }
            ReLoad();
        }

        private void checkDevices()
        {
            List<Uredjaj> devices = service.GetDevices(naplatnaStanica);
            if(devices.Any(x => !x.Ispravan))
            {
                uredjajLabel.Text = uredjajLabel.Text.Split(":")[0] + ": Pokvareno";
                kursButton.Enabled = false;
                nextButton.Enabled = false;
            }
            else
            {
                uredjajLabel.Text = uredjajLabel.Text.Split(":")[0] + ": Radi";
                kursButton.Enabled = true;
                nextButton.Enabled = true;
            }
        }

        private void ReLoad()
        {
            brLabel.Text = brLabel.Text.Split(":")[0] + ": " + cards[0].registarskaOznakaVozila;
            rampLabel.Text = rampLabel.Text.Split(":")[0] + ": Zatvorena";
            checkDevices();
            stop = DateTime.Now;
            speedBox.Text = "";
            kursBox.Text = "";
            vremeBox.Text = stop.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cards.RemoveAt(0);
            if(cards.Count != 0)
            {
                ReLoad();
            }
            else
            {
                MessageBoxUtilities.ShowErrorMessage("Nema vise automobila");
            }
        }

        private void speedButton_Click(object sender, EventArgs e)
        {
            double temp = Math.Round(paymentController.AvgSpeed(cards[0], naplatnaStanica, stop), 2);
            if(temp >= 0)
            {
                speedBox.Text = temp.ToString();
            }
            else
            {
                speedBox.Text = "Greska";
            }
        }

        private void kursButton_Click(object sender, EventArgs e)
        {
            double temp = Math.Round(paymentController.Kurs(cards[0], naplatnaStanica, (int)((EnhancedComboBoxItem)catCombo.SelectedItem).value), 2);
            if (temp >= 0)
            {
                kursBox.Text = temp.ToString();
            }
            else
            {
                kursBox.Text = "Cena ne postoji";
            }
        }
    }
}
