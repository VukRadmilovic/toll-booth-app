using NaplataPutarine.Core.Devices.Models;
using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.Devices
{
    internal class UredjajRepository : Repository
    {
        public List<Uredjaj> GetAllDevices()
        {
            List<Uredjaj> devices = new List<Uredjaj>();
            string getQuery = "SELECT [Uredjaj].*, [TipUredjaja].Naziv AS Tip, [NaplatnoMesto].Id AS NMId,[NaplatnoMesto].idNaplatnaStanica AS NSId " +
                              "FROM Uredjaj " +
                              "LEFT OUTER JOIN [NaplatnoMesto] ON [NaplatnoMesto].Id = [Uredjaj].IdNaplatnoMesto " +
                              "LEFT OUTER JOIN [TipUredjaja] ON [Uredjaj].idTipUredjaja = [TipUredjaja].Id " +
                              "WHERE [Uredjaj].IsDeleted = 0";
             foreach(DataRow row in database.CreateTableOfData(getQuery).Rows)
             {
                NaplatnoMesto parent = new NaplatnoMesto(Convert.ToInt32(row["NMId"]),
                                                         new NaplatnaStanica(Convert.ToInt32(row["NSId"])),
                                                         new List<Uredjaj>()
                                                         );
                Uredjaj device = null;
                int deviceId = Convert.ToInt32(row["Id"]);
                bool ispravan = Convert.ToBoolean(row["Ispravan"]);
                switch(row["Tip"].ToString())
                {
                    case "DISPLEJ":
                        device = new Displej(deviceId, ispravan, parent);break;
                    case "CITAC_TAGA":
                        device = new CitacTaga(deviceId, ispravan, parent);break;
                    case "SEMAFOR":
                        device = new Semafor(deviceId, ispravan, parent);break;
                    case "RAMPA":
                        device = new Rampa(deviceId, ispravan, parent);break;
                    case "SKENER_KARTICE":
                        device = new SkenerKartice(deviceId, ispravan, parent);break;
                    case "STAMPAC_KARTICE":
                        device = new StampacKartice(deviceId,ispravan, parent);break;
                    default:
                        device = new CitacRegistarskihTablica(deviceId, ispravan, parent);break;
                }
                devices.Add(device);
             }

            return devices;
        }

        public void ChangeDeviceStatus(int deviceId, bool status)
        {
            string changeQuery = "UPDATE [Uredjaj] SET Ispravan = @status " +
                                 "WHERE Id = @id";
            database.ExecuteNonQueryCommand(changeQuery, ("@id", deviceId), ("@status", status));
        }
    }
}
