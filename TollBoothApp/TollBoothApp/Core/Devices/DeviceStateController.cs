using TollBoothApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Devices.Models;
using TollBoothApp.Core.Devices.Observer;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Devices
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
