using NaplataPutarine.Core.Devices;
using NaplataPutarine.Core.Devices.Models;
using NaplataPutarine.Core.TollStations.Models;
using NaplataPutarine.Core.Users;
using NaplataPutarine.Core.Users.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.TollStations.Repositories
{
    internal class NaplatnoMestoRepository : Repository
    {
        private readonly UredjajRepository _uredjajRepo;

        public NaplatnoMestoRepository()
        {
            _uredjajRepo = new UredjajRepository();
        }

        public List<NaplatnoMesto> GetAllTollBooths()
        {
            List<NaplatnoMesto> tollBooths = new List<NaplatnoMesto>();
            List<Uredjaj> allDevices = _uredjajRepo.GetAllDevices();
            string getQuery = "SELECT [NaplatnoMesto].* " +
                              "FROM [NaplatnoMesto] " +
                              "WHERE IsDeleted = 0";
            foreach (DataRow row in database.CreateTableOfData(getQuery).Rows)
            {
                int tollBoothId = Convert.ToInt32(row["Id"]);
                List<Uredjaj> tollBoothDevices = new List<Uredjaj>();
                foreach (Uredjaj device in allDevices)
                {
                    if (device.NaplatnoMestoUredjaja.Id == tollBoothId)
                    {
                        tollBoothDevices.Add(device);
                    }
                }
                tollBooths.Add(new NaplatnoMesto(tollBoothId, new NaplatnaStanica(Convert.ToInt32(row["IdNaplatnaStanica"])), tollBoothDevices));
            }
            return tollBooths;
        }
    }
}
