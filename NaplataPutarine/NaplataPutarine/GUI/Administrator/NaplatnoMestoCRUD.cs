using NaplataPutarine.Core.Devices.Models;
using NaplataPutarine.Core.TollStations.Controllers;
using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaplataPutarine.GUI.Administrator
{
    public partial class NaplatnoMestoCRUD : Form
    {
        private int _stanicaID;
        private readonly NaplatnoMestoController _controller;
        private readonly Dictionary<string, CheckBox> _tipUredjajaToCheckBox;

        public NaplatnoMestoCRUD(int stanicaID)
        {
            _stanicaID = stanicaID;
            _controller = new NaplatnoMestoController(_stanicaID);
            InitializeComponent();
            _tipUredjajaToCheckBox = new Dictionary<string, CheckBox>() {
                { "CitacRegistarskihTablica", citacTablicaCheckBox },
                { "CitacTaga", citacTagaCheckBox },
                { "Displej", displejCheckBox },
                { "Rampa", rampaCheckBox },
                { "Semafor", semaforCheckBox },
                { "SkenerKartice", skenerKarticeCheckBox },
                { "StampacKartice", stampacKarticeCheckBox }
            };
        }

        private void RefreshComboBox()
        {
            try
            {
                List<NaplatnoMesto> mesta = _controller.GetNaplatnaMesta();
                if (mesta.Count == 0)
                {
                    MessageBoxUtilities.ShowErrorMessage("Ova stanica trenutno nema ni jedno naplatno mesto.");
                }
                naplatnaMestaComboBox.Items.Clear();
                foreach (NaplatnoMesto mesto in mesta)
                {
                    naplatnaMestaComboBox.Items.Add(mesto);
                }
            }
            catch(Exception)
            {

            }
        }

        private void UncheckCheckBoxes()
        {
            foreach (Control box in uredjajiGroupBox.Controls)
            {
                if (box is CheckBox)
                {
                    ((CheckBox)box).Checked = false;
                }
            }
        }

        private void NaplatnoMestoCRUD_Load(object sender, EventArgs e)
        {
            UncheckCheckBoxes();
            RefreshComboBox();
        }

        private void NaplatnaMestaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshCheckBoxes();
            }
            catch (Exception)
            {
                UncheckCheckBoxes();
            }
        }

        private void RefreshCheckBoxes()
        {
            UncheckCheckBoxes();
            NaplatnoMesto odabranoMesto = naplatnaMestaComboBox.SelectedItem as NaplatnoMesto;
            foreach (Uredjaj uredjaj in odabranoMesto.Uredjaji)
            {
                _tipUredjajaToCheckBox[uredjaj.GetType().ToString().Split(".").Last()].Checked = true;
            }
        }

        private List<Uredjaj> GetSelectedUredjaji()
        {
            List<Uredjaj> uredjaji = new List<Uredjaj>();
            if (citacTablicaCheckBox.Checked)
                uredjaji.Add(new CitacRegistarskihTablica());
            if (citacTagaCheckBox.Checked)
                uredjaji.Add(new CitacTaga());
            if (displejCheckBox.Checked)
                uredjaji.Add(new Displej());
            if (rampaCheckBox.Checked)
                uredjaji.Add(new Rampa());
            if (semaforCheckBox.Checked)
                uredjaji.Add(new Semafor());
            if (skenerKarticeCheckBox.Checked)
                uredjaji.Add(new SkenerKartice());
            if (stampacKarticeCheckBox.Checked)
                uredjaji.Add(new StampacKartice());
            return uredjaji;
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Add(_stanicaID, GetSelectedUredjaji());
                RefreshComboBox();
                MessageBoxUtilities.ShowSuccessMessage("Uspešno izvršeno dodavanje.");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.ShowErrorMessage(ex.Message);
                return;
            }
        }

        private void AzurirajButton_Click(object sender, EventArgs e)
        {
            if (naplatnaMestaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Morate odabrati naplatno mesto.");
                return;
            }
            NaplatnoMesto odabranoMesto = naplatnaMestaComboBox.SelectedItem as NaplatnoMesto;
            try
            {
                _controller.Update(odabranoMesto.Id, GetSelectedUredjaji());
                RefreshComboBox();
                MessageBoxUtilities.ShowSuccessMessage("Uspešno izvršeno ažuriranje.");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.ShowErrorMessage(ex.Message);
                return;
            }
        }

        private void ObrisiButton_Click(object sender, EventArgs e)
        {
            if (naplatnaMestaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Morate odabrati naplatno mesto.");
                return;
            }
            NaplatnoMesto odabranoMesto = naplatnaMestaComboBox.SelectedItem as NaplatnoMesto;
            try
            {
                _controller.Delete(odabranoMesto.Id);
                naplatnaMestaComboBox.Text = "";
                RefreshComboBox();
                MessageBoxUtilities.ShowSuccessMessage("Uspešno izvršeno brisanje.");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.ShowErrorMessage(ex.Message);
                return;
            }
        }
    }
}