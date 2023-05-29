using Loja.Stock.Models;

namespace Loja.Stock.Interfaces.Services
{
    internal interface IStockService
    {

        public bool SetStock(StockModel stockModel);
        public bool UpdateStock(StockModel stockModel);
    }
}
