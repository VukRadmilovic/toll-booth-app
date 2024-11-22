using TollBoothApp.Core.TollStations.Controllers;
using TollBoothApp.Core.TollStations.Models;
using TollBoothApp.Core.Utilities;

namespace TollBoothApp.GUI.Administrator
{
    public partial class NaplatnaStanicaCRUD : Form
    {
        private NaplatnaStanicaController _controller;

        public NaplatnaStanicaCRUD()
        {
            InitializeComponent();
            _controller = new NaplatnaStanicaController();
        }

        private void RefreshTable()
        {
            List<NaplatnaStanica> stanice = _controller.GetNaplatneStanice();
            staniceTable.Rows.Clear();
            foreach (NaplatnaStanica stanica in stanice)
            {
                staniceTable.Rows.Add(stanica.Id, stanica.Naziv, stanica.Mesto, stanica.DatumIzgradnje);
            }
            staniceTable.Refresh();
        }

        private void NaplatnaStanicaCRUD_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void NaplatnaStanicaCRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.RefreshSistem();
        }

        private void StaniceTable_SelectionChanged(object sender, EventArgs e)
        {
            if (staniceTable.SelectedRows.Count == 0)
                return;
            try
            {
                nazivTextBox.Text = UIUtilities.GetCellValue(staniceTable, "naziv").ToString();
                mestoTextBox.Text = UIUtilities.GetCellValue(staniceTable, "mesto").ToString();
                izgradnjaDatePicker.Value = ((DateOnly)UIUtilities.GetCellValue(staniceTable, "DatumIzgradnje")).ToDateTime(TimeOnly.Parse("12:00"));
            }
            catch(Exception)
            {

            }
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Add(nazivTextBox.Text, mestoTextBox.Text, izgradnjaDatePicker.Value);
                RefreshTable();
                MessageBoxUtilities.ShowSuccessMessage("Uspešno dodata stanica.");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.ShowErrorMessage(ex.Message);
            }
        }

        private void AzurirajButton_Click(object sender, EventArgs e)
        {
            if (staniceTable.SelectedRows.Count == 0)
            {
                MessageBoxUtilities.ShowErrorMessage("Morate odabrati stanicu za ažuriranje iz tabele.");
                return;
            }
            int id = Convert.ToInt32(UIUtilities.GetCellValue(staniceTable, "id"));

            try
            {
                _controller.Update(id, nazivTextBox.Text, mestoTextBox.Text, izgradnjaDatePicker.Value);
                RefreshTable();
                MessageBoxUtilities.ShowSuccessMessage("Uspešno ažurirana stanica.");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.ShowErrorMessage(ex.Message);
            }
        }

        private void ObrisiButton_Click(object sender, EventArgs e)
        {
            if (staniceTable.SelectedRows.Count == 0)
            {
                MessageBoxUtilities.ShowErrorMessage("Morate odabrati stanicu za brisanje iz tabele.");
                return;
            }
            int id = Convert.ToInt32(UIUtilities.GetCellValue(staniceTable, "id"));

            try
            {
                _controller.Delete(id);
                RefreshTable();
                MessageBoxUtilities.ShowSuccessMessage("Uspešno obrisana stanica.");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.ShowErrorMessage(ex.Message);
            }
        }

        private void MestaButton_Click(object sender, EventArgs e)
        {
            if (staniceTable.SelectedRows.Count == 0)
            {
                MessageBoxUtilities.ShowErrorMessage("Morate odabrati stanicu iz tabele za pregled njenih naplatnih mesta.");
                return;
            }
            int id;
            try
            {
                id = Convert.ToInt32(UIUtilities.GetCellValue(staniceTable, "id"));
            }
            catch (Exception)
            {
                MessageBoxUtilities.ShowErrorMessage("Morate odabrati stanicu iz tabele za pregled njenih naplatnih mesta.");
                return;
            }

            new NaplatnoMestoCRUD(id).ShowDialog();
        }
    }
}
