using NaplataPutarine.Core;
using NaplataPutarine.Core.Devices;
using NaplataPutarine.Core.Devices.Models;
using NaplataPutarine.Core.Devices.Observer;
using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.GUI.TollStationChief.Controllers
{
    internal class DeviceStateController
    {
        private readonly UredjajService _uredjajService;
        public DeviceStateController(IDeviceStatusObserver view)
        {
            _uredjajService = new UredjajService();
            _uredjajService.AddObserver(view);
        }

        public void ChangeDeviceStatus(NaplatnaStanica current, int deviceId, bool status)
        {
            _uredjajService.ChangeDeviceStatus(current, deviceId, status);
        }

        public List<Uredjaj> GetDevices(NaplatnaStanica station)
        {
            return _uredjajService.GetDevices(station);
        }

    }
}
