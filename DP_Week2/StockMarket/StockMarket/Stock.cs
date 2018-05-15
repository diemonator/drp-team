using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    public  class Stock
    {
        private int id;
        private static int unique_id = 0;
        private string name;
        private double currentPrice;
        private double previousPrice;
        private string region;

        public Stock(string name,double cp,string rn)
        {
            this.name = name;
            this.currentPrice = cp;
            this.previousPrice = 0;
            this.region = rn;
            this.id = unique_id;
            unique_id++;
        }

        public string GetName()
        {
            return this.name;
        }
        public double GetCurrentPrice()
        {
            return this.currentPrice;
        }
        public double GetPreviousPrice()
        {
            return this.previousPrice;
        }
        public void setPrice(double price)
        {
            this.previousPrice = this.currentPrice;
            this.currentPrice = price;
        }
        public string GetRegion()
        {
            return this.region;
        }
        public int GetId()
        {
            return this.id;
        }
        public bool GetPriceDifference()
        {
            if(this.currentPrice > this.previousPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
