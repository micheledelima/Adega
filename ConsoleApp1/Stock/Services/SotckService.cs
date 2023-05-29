using Loja.Stock.Interfaces.Repositories;
using Loja.Stock.Models;

namespace Loja.Stock.Services
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
