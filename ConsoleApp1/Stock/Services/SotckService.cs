using Store.Stock.Interfaces.Repositories;
using Store.Stock.Models;

namespace Store.Stock.Services
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
