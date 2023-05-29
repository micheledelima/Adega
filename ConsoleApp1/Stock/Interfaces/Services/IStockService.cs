using Store.Stock.Models;

namespace Store.Stock.Interfaces.Services
{
    internal interface IStockService
    {

        public bool SetStock(StockModel stockModel);
        public bool UpdateStock(StockModel stockModel);
    }
}
