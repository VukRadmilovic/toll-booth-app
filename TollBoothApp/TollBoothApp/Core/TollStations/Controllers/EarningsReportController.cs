using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.TollStations.Controllers
{
    internal class EarningsReportController
    {
        private readonly SistemZaNaplatuPutarine _system;

        public EarningsReportController()
        {
            _system = SistemZaNaplatuPutarine.GetInstance();
        }

        public string GetReport(NaplatnaStanica station, string reportType, DateOnly start)
        {
            return _system.GenerisiIzvestajZaStanicu(station, reportType, start);
        }
    }
}
