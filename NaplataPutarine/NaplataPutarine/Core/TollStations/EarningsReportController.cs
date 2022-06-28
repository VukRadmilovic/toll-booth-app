using NaplataPutarine.Core;
using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplataPutarine.Core.TollStations
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
