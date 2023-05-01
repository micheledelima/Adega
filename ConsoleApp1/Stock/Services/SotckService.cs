using Adega.Stock.Interfaces.Repositories;
using Adega.Stock.Models;

namespace Adega.Stock.Services
{
    public class SotckService : IStockRepository
    {
        public bool setStock(StockModel stockModel)
        {
            if (stockModel != null)
            {
                return true;
            }
            return false;
        }

        public bool updateStock(StockModel stockModel)
        {
            if (stockModel != null)
            {
                return true;
            }
            return false;
        }
    }
}
