using TollBoothApp.Core.Devices;
using TollBoothApp.Core.Devices.Models;
using TollBoothApp.Core.Devices.Observer;
using TollBoothApp.Core.TollStations.Models;
using TollBoothApp.Core.Utilities;

namespace TollBoothApp.GUI.Worker
{
    internal partial class Uredjaji : Form, IDeviceStatusObserver
    {
        private readonly NaplatnaStanica _stanica;
        private readonly DeviceStateController _controller;

        public Uredjaji(NaplatnaStanica stanica)
        {
            InitializeComponent();
            _stanica = stanica;
            _controller = new DeviceStateController(this);
        }

        public void Update(Uredjaj device)
        {
            uredjajiTable.SelectedRows[0].Cells["Ispravan"].Value = device.Ispravan;
            if (device.Ispravan)
                MessageBoxUtilities.ShowInformationMessage($"Uređaj sa ID {device.Id} je sada ispravan.");
            else
                MessageBoxUtilities.ShowInformationMessage($"Uređaj sa ID {device.Id} je sada neispravan.");
        }

        private void PromeniStatusButton_Click(object sender, EventArgs e)
        {
            if (uredjajiTable.SelectedRows.Count == 0)
            {
                MessageBoxUtilities.ShowErrorMessage("Morate odabrati uređaj čiji status menjate.");
                return;
            }
            bool trenutniStatus = Convert.ToBoolean(UIUtilities.GetCellValue(uredjajiTable, "Ispravan"));
            bool novStatus = ispravanRadioButton.Checked;
            int idUredjaja = Convert.ToInt32(UIUtilities.GetCellValue(uredjajiTable, "Id"));
            
            if (trenutniStatus == novStatus)
            {
                MessageBoxUtilities.ShowErrorMessage("Nov status uređaja mora biti drugačiji od trenutnog statusa da bi se promenio.");
                return;
            }

            _controller.ChangeDeviceStatus(_stanica, idUredjaja, novStatus);
        }

        private void Uredjaji_Load(object sender, EventArgs e)
        {
            List<Uredjaj> uredjaji = _controller.GetDevices(_stanica);
            foreach (Uredjaj uredjaj in uredjaji)
            {
                uredjajiTable.Rows.Add(uredjaj.Id, uredjaj.GetType().Name, uredjaj.NaplatnoMestoUredjaja.Id, uredjaj.Ispravan);
            }
        }
    }
}
