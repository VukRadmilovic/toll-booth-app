using NaplataPutarine.Core.Devices.Models;
using NaplataPutarine.Core.TollStations.Models;
using System.Data;

namespace NaplataPutarine.Core.Devices
{
    internal class UredjajRepository : Repository
    {
        private readonly Dictionary<string, int> _vrstaUredjajaToIDTipa;

        public UredjajRepository()
        {
            _vrstaUredjajaToIDTipa = new Dictionary<string, int>()
            {
                { "CitacRegistarskihTablica", 7 },
                { "CitacTaga", 2 },
                { "Displej", 1 },
                { "Rampa", 4 },
                { "Semafor", 3 },
                { "SkenerKartice", 5 },
                { "StampacKartice", 6 }
            };
        }

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

        public void Add(int mestoID, List<Uredjaj> uredjaji)
        {
            foreach (Uredjaj uredjaj in uredjaji)
            {
                string uredjajQuery = "INSERT INTO [Uredjaj] " +
                                        "(IdNaplatnoMesto, IdTipUredjaja, Ispravan, IsDeleted) " +
                                        "values(@idMesto, @idTip, 1, 0)";
                database.ExecuteNonQueryCommand(uredjajQuery, ("@idMesto", mestoID),
                                               ("@idTip", _vrstaUredjajaToIDTipa[uredjaj.GetType().ToString().Split(".").Last()]));
            }
        }

        public void Delete(int id)
        {
            try
            {
                string query = "UPDATE [Uredjaj] " +
                                "SET isDeleted = 1 " +
                                "WHERE Id = @id";
                database.ExecuteNonQueryCommand(query, ("@id", id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}