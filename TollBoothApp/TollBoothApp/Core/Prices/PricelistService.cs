using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Prices.Models;

namespace TollBoothApp.Core.Prices
{
    internal class PricelistService
    {
        private readonly PricelistRepository pricelistRepository;
        public PricelistService()
        {
            pricelistRepository = new PricelistRepository();
        }

        public List<Price> GetPricelist()
        {
            return pricelistRepository.GetCenovnik();
        }
    }
}
