using NaplataPutarine.Core.Devices.Models;
using NaplataPutarine.Core.Devices.Observer;
using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices
{
    internal class UredjajService : IDeviceStatusObservable
    {
        private readonly UredjajRepository _uredjajRepo;
        private readonly SistemZaNaplatuPutarine _system;
        private readonly List<IDeviceStatusObserver> _observers;
        public UredjajService()
        {
            _uredjajRepo = new UredjajRepository();
            _system = SistemZaNaplatuPutarine.GetInstance();
            _observers = new List<IDeviceStatusObserver>();
        }

        public void AddObserver(IDeviceStatusObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers(Uredjaj device)
        {
            foreach(IDeviceStatusObserver observer in _observers)
            {
                observer.Update(device);
            }
        }

        public void RemoveObserver(IDeviceStatusObserver observer)
        {
            _observers.Remove(observer);
        }

        public void ChangeDeviceStatus(NaplatnaStanica currentStation, int deviceId, bool status)
        {
            List<Uredjaj> stationDevices = GetDevices(currentStation);
            foreach (Uredjaj device in stationDevices)
            {
                if (device.Id != deviceId) continue;

                device.Ispravan = status;
                _uredjajRepo.ChangeDeviceStatus(deviceId,status);
                NotifyObservers(device);
                return;
            }
        }

        public List<Uredjaj>? GetDevices(NaplatnaStanica currentStation)
        {
            List<Uredjaj> stationDevices = new List<Uredjaj>();
            foreach(NaplatnaStanica station in _system.NaplatneStanice)
            {
                if (station.Id != currentStation.Id) continue;

                foreach (NaplatnoMesto tollBooth in station.NaplatnaMesta)
                {
                    stationDevices.AddRange(tollBooth.Uredjaji);
                }
            }
            return stationDevices;
        }

    }
}
