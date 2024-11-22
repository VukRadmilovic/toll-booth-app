using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Prices.Models;
using TollBoothApp.Core.Payments.Models;
using TollBoothApp.Core.TollStations.Models;

namespace TollBoothApp.Core.Payments
{
    internal class PaymentController
    {
        private readonly PaymentService service;

        public PaymentController()
        {
            service = new PaymentService();
        }

        public List<EnhancedComboBoxItem> GetCat()
        {
            return service.GetCat();
        }
        public List<Core.Payments.Models.Kartica> GetCards()
        {
            return service.GetCards();
        }
        public double AvgSpeed(Core.Payments.Models.Kartica start, NaplatnaStanica stanica, DateTime stop)
        {
            return service.AvgSpeed(start, stanica, stop);
        }
        public double Kurs(Core.Payments.Models.Kartica start, NaplatnaStanica stanica, int type)
        {
            return service.Kurs(start, stanica, type);
        }
    }
}
