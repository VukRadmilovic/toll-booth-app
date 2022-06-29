using NaplataPutarine.Core.Devices;
using NaplataPutarine.Core.Devices.Models;
using NaplataPutarine.Core.Devices.Observer;
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

namespace NaplataPutarine.GUI.TollStationChief.Forms
{
    internal partial class DeviceStates : Form, IDeviceStatusObserver
    {
        private readonly NaplatnaStanica _current;
        private readonly DeviceStateController _deviceController;

        public DeviceStates(NaplatnaStanica current)
        {
            InitializeComponent();
            _current = current;
            _deviceController = new DeviceStateController(this);
        }

        public void Update(Uredjaj device)
        {
            deviceStatusTable.SelectedRows[0].Cells["Ispravan"].Value = device.Ispravan;
        }

        private void FixButton_Click(object sender, EventArgs e)
        {
            _deviceController.ChangeDeviceStatus(_current, Convert.ToInt32(UIUtilities.GetCellValue(deviceStatusTable, "Id")), true);
            MessageBoxUtilities.ShowSuccessMessage("Uređaj uspešno popravljen!");
            fixButton.Enabled = false;
        }

        private void DeviceStates_Load(object sender, EventArgs e)
        {
            List<Uredjaj> stationDevices = _deviceController.GetDevices(_current);
            foreach (Uredjaj stationDevice in stationDevices)
            {
                deviceStatusTable.Rows.Add(stationDevice.Id,stationDevice.GetType().Name, stationDevice.NaplatnoMestoUredjaja.Id, stationDevice.Ispravan);
            }
        }

        private void DeviceStatusTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(UIUtilities.GetCellValue(deviceStatusTable,"Ispravan").ToString()) != false)
            {
                fixButton.Enabled = false;
                return;
            }
            fixButton.Enabled = true;
        }
    }
}
