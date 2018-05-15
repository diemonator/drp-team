using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class Observer : IObserver
    {
        private string region;
        private List<Stock> stocks;
        private StockMarket Market;

        public Observer(StockMarket sm,string region)
        {
            stocks = new List<Stock>();
            this.region = region;
            this.Market = sm;
            Market.AddObserver(this);
            Update();
        }

        public void Unsubscribe()
        {
            Market.RemoveObserver(this);
           
        }

        public void Update()
        {
            this.stocks = Market.GetStocksByRegion(region);
        }
        public string GetRegion()
        {
            return this.region;
        }
        public List<Stock> GetStocks()
        {
            return this.stocks;
        }
    }
}
