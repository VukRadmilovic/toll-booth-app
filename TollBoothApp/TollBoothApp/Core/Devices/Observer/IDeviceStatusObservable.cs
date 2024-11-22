using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Devices.Models;

namespace TollBoothApp.Core.Devices.Observer
{
    internal interface IDeviceStatusObservable
    {
        public void AddObserver(IDeviceStatusObserver observer);
        public void RemoveObserver(IDeviceStatusObserver observer);
        public void NotifyObservers(Uredjaj device);
    }
}
