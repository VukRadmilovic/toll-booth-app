using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Devices.Models;

namespace TollBoothApp.Core.Devices.Observer
{
    internal interface IDeviceStatusObserver
    {
        public void Update(Uredjaj device);
    }
}
