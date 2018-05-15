using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
   public interface ISubject
    {
        void AddObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void SetStockPrice(int id, double value);

        List<Stock> GetStocks();

        void Notify();

        Stock GetStockById(int id);


        void AddStock(Stock s);

      List<Stock> GetStocksByRegion(string region);

    }
}
