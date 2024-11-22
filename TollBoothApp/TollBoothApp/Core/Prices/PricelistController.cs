using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothApp.Core.Prices.Models;

namespace TollBoothApp.Core.Prices
{
    internal class PricelistController
    {
        private readonly PricelistService pricelistService;

        public PricelistController()
        {
            pricelistService = new PricelistService();
        }

        public List<Price> GetPricelist()
        {
            return pricelistService.GetPricelist();
        }

        
    }
}
