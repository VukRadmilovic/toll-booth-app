using NaplataPutarine.Core.Devices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices.Observer
{
    internal interface IDeviceStatusObservable
    {
        public void AddObserver(IDeviceStatusObserver observer);
        public void RemoveObserver(IDeviceStatusObserver observer);
        public void NotifyObservers(Uredjaj device);
    }
}
