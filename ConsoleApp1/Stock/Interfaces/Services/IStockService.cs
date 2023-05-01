using Adega.Stock.Models;

namespace Adega.Stock.Interfaces.Services
{
    internal interface IStockService
    {

        public bool SetStock(StockModel stockModel);
        public bool UpdateStock(StockModel stockModel);
    }
}
