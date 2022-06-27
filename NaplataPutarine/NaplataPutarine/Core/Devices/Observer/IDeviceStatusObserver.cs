using NaplataPutarine.Core.Devices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices.Observer
{
    internal interface IDeviceStatusObserver
    {
        public void Update(Uredjaj device);
    }
}
