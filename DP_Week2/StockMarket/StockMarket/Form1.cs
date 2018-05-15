using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class Form1 : Form
    {

       static StockMarket StaticMarket = new StockMarket();
        StockMarket sm;


        public Form1()
        {
            InitializeComponent();
            sm = StaticMarket;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddStocks();
            RefreshList();
            StockTimer.Start();

        }
        public void AddStocks()
        {
            Stock temp = new Stock("Apple inc.", 195.55, "US");
            sm.AddStock(temp);
            Stock temp2 = new Stock(" Audi Motors.", 150.11, "EU");
            sm.AddStock(temp2);
            Stock temp3 = new Stock(" Samsung Electronics.", 192.23, "AS");
            sm.AddStock(temp3);
            Stock temp4 = new Stock("Huawei.", 50.25, "AS");
            sm.AddStock(temp4);
            Stock temp5 = new Stock(" Amazon", 98.12, "US");
            sm.AddStock(temp5);
            Stock temp6 = new Stock("Nokia Military Cellular Technology.", 500.12, "EU");
            sm.AddStock(temp6);
            Stock temp7 = new Stock("General Motors", 320.22, "US");
            sm.AddStock(temp7);
            Stock temp8 = new Stock("ING", 111.11, "EU");
            sm.AddStock(temp8);
            Stock temp9 = new Stock("Nintendo", 999.99, "AS");
            sm.AddStock(temp9);
            Stock temp10 = new Stock("Ubisoft Entertainmnent", 19.23, "US");
            sm.AddStock(temp10);
            Stock temp11 = new Stock("Hema", 12.12, "EU");
            sm.AddStock(temp11);
            Stock temp12 = new Stock("Canon", 250.12, "AS");
            sm.AddStock(temp12);

        }
        public void RefreshList()
        {
            StockView.Items.Clear();
            foreach (Stock item in sm.GetStocks())
            {
                ListViewItem i = new ListViewItem(item.GetName());
                i.SubItems.Add(item.GetCurrentPrice().ToString());
                i.SubItems.Add(item.GetRegion());
                StockView.Items.Add(i);
            }
        }

        private void StockTimer_Tick(object sender, EventArgs e)
        {
            //TODO make this method efficient using getStockName and the setValuse Method in the StockMarketClass so updates to observers can happen
            //TODO Create observers with a button click and add forms for each of them give them data and initialize their forms with lists 
            //TODO let observers have the functionality of chanign stock colour to red or green based on price
            
            Random r = new Random();
            
            int stockIndex = r.Next(1,12);
            double stockChangeRate = r.Next(-10, 10);
            Stock subject = sm.GetStockById(stockIndex);
            sm.SetStockPrice(stockIndex, subject.GetCurrentPrice() + (stockChangeRate / 10));
            RefreshList();
            if (sm.GetStockById(stockIndex).GetPriceDifference())
            {
                StockView.FindItemWithText(subject.GetName()).ForeColor = Color.Green;
            }
            else if (!sm.GetStockById(stockIndex).GetPriceDifference())
            {
                StockView.FindItemWithText(subject.GetName()).ForeColor = Color.Red;
            }
            




        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Please choose a region");
            }
            else
            {
               
                {
                    Observer observer = new Observer(sm, comboBox1.Text.ToString());
                    var form = new SpecialForm(observer);
                    form.Owner = this;
                    form.Show();
                }
            }
           
        }

       
    }
}
