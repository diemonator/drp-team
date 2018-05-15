using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public class StockMarket : ISubject
    {
        //variables

        private List<Stock> stocks;
        private List<IObserver> observers;

        //constructor

        public StockMarket()
        {
            this.stocks = new List<Stock>();
            this.observers = new List<IObserver>();
        }
        //methods

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }



        public List<Stock> GetStocks()
        {
            return this.stocks;
        }
        public List<Stock> GetStocksByRegion(string region)
        {
            List<Stock> StocksFromRegion = new List<Stock>();
            foreach (Stock s in stocks)
            {
                if (s.GetRegion() == region)
                {
                    StocksFromRegion.Add(s);
                }
            }
            return StocksFromRegion;
        }



        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }



        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

  

        public void SetStockPrice(int id, double value)
        {
            foreach (Stock stock in stocks)
            {
                if (stock.GetId() == id)
                {
                    stock.setPrice(value);
                }
            }
            Notify();
        }
        public void AddStock(Stock s)
        {
            stocks.Add(s);

        }
        public Stock GetStockById(int id)
        {
            foreach (Stock item in this.stocks)
            {
                if(item.GetId() == id)
                {
                    return item;
                }
            }
            return null;
        }


    }

}
