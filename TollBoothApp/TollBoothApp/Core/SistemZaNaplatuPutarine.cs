using System.Globalization;
using TollBoothApp.Core.Payments.Models;
using TollBoothApp.Core.Payments.Repositories;
using TollBoothApp.Core.Prices.Models;
using TollBoothApp.Core.TollStations.Models;
using TollBoothApp.Core.TollStations.Repositories;
using TollBoothApp.Core.Users;
using TollBoothApp.Core.Users.Models;
using Kartica = TollBoothApp.Core.TollStations.Models.Kartica;

namespace TollBoothApp.Core
{
    internal class SistemZaNaplatuPutarine
    {
        public List<Korisnik> Korisnici { get; private set; }
        public List<Radnik> Radnici { get; private set; }
        public List<Uplata> Uplate { get; private set; }
        public List<Tag> Tagovi { get; private set; }
        public List<NaplatnaStanica> NaplatneStanice { get; private set; }
        public List<Deonica> Deonice { get; private set; }
        public Cenovnik Cenovnik { get; private set; }
        public List<Kartica> Kartice { get; private set; }

        private readonly KorisnikRepository _korisnikRepo;
        private readonly NaplatnaStanicaRepository _stanicaRepo;
        private readonly UplataRepository _uplataRepo;
        private static SistemZaNaplatuPutarine? instance;

        public static SistemZaNaplatuPutarine GetInstance()
        {
            if (instance == null)
            {
                instance = new SistemZaNaplatuPutarine();
            }
            return instance;
        }

        private SistemZaNaplatuPutarine()
        {
            _korisnikRepo = new KorisnikRepository();
            _stanicaRepo = new NaplatnaStanicaRepository();
            _uplataRepo = new UplataRepository();
            Radnici = _korisnikRepo.GetAllWorkers();
            NaplatneStanice = _stanicaRepo.GetAllTollStations();
            Uplate = _uplataRepo.GetAllPayments();
        }
        
        public string GenerisiIzvestajZaStanicu(NaplatnaStanica? station,string reportType,DateOnly start)
        {
            string report = "----FINANSIJSKI IZVEŠTAJ----\n";
            
            double rsd = 0, eur = 0, usd = 0;
            int cashCount = 0,electronicCount = 0;
            DateOnly? end = null;

            switch(reportType)
            {
                case "day":
                    end = start;
                    report += "Dan: " + start + "\n"; break;
                case "month":
                    end = start.AddDays(DateTime.DaysInMonth(start.Day, start.Month) - 1);
                    report += "Mesec: " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(start.Month) + "\n"; break;
                default:
                    end = new DateOnly(start.Year, 12, 31);
                    report += "Godina: " + start.Year + "\n"; break;
            }

            foreach(Uplata payment in Uplate)
            {
                if (payment.DatumUplate < start || payment.DatumUplate > end) continue;
                if (station == null)
                {
                    if (payment is GotovinskaUplata)
                    {
                        cashCount++;
                    }
                    else
                    {
                        electronicCount++;
                    }
                }
                foreach (NaplatnaStanica tollStation in NaplatneStanice)
                {
                    if (station != null && tollStation.Id != station.Id) continue;


                    foreach (NaplatnoMesto tollBooth in tollStation.NaplatnaMesta)
                    {
                        if (payment.MestoUplate.Id != tollBooth.Id) continue;

                        if (station != null)
                        {
                            if (payment is GotovinskaUplata)
                            {
                                cashCount++;
                            }
                            else
                            {
                                electronicCount++;
                            }
                        }
                        switch (payment.Valuta)
                        {
                            case ValutaEnum.Valuta.RSD:
                                rsd += payment.Iznos;break;

                            case ValutaEnum.Valuta.EUR:
                                eur += payment.Iznos;break;

                            default:
                                usd += payment.Iznos;break;
                        }
                    }
                }
            }

            report += "UKUPNO (RSD): " + rsd + "\n";
            report += "UKUPNO (EUR): " + eur + "\n";
            report += "UKUPNO (USD): " + usd + "\n";
            report += "----------------------------\n";
            report += "UKUPNO UPLATA (GOTOVINA): " + cashCount + "\n";
            report += "UKUPNO UPLATA (ELEKTRONSKI): " + electronicCount + "\n";
            return report;

        }

        public string GenerisiIzvestajZaSveStanice(string reportType, DateOnly start)
        {
            return GenerisiIzvestajZaStanicu(null,reportType,start);
        }

        public void Refresh()
        {
            Radnici = _korisnikRepo.GetAllWorkers();
            NaplatneStanice = _stanicaRepo.GetAllTollStations();
            Uplate = _uplataRepo.GetAllPayments();
        }

        public Deonica GetDeonica(NaplatnaStanica start, NaplatnaStanica kraj)
        {
            throw new NotImplementedException();
        }
    }
}
