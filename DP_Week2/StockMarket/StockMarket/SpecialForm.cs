using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
    class SpecialForm: Form
    {
        Observer observer = null;
        ListView StockList = null;
        private Timer timer2;
        private System.ComponentModel.IContainer components;
        Timer timer1 = null;

        public SpecialForm(Observer o)
        {
            InitializeComponent();
            this.observer = o;
            this.StockList = new ListView();
            timer1 = new Timer();
            this.Text = observer.GetRegion() + " Observer";
            this.Controls.Add(StockList);
            StockList.ForeColor = System.Drawing.Color.White;
            StartObserver();
            timer2.Start();
          

            


        }

        public void StartObserver()
        {
            StockList.Columns.Add("Name", 100, HorizontalAlignment.Center);
            StockList.Columns.Add("Price", 100, HorizontalAlignment.Center);
            StockList.Columns.Add("Region", 100, HorizontalAlignment.Center);
            StockList.View = View.Details;
            this.Size = new System.Drawing.Size(400, 300);
            StockList.Size = new System.Drawing.Size(300, 300);
            StockList.Dock = DockStyle.Top;
            StockList.BackColor = System.Drawing.Color.Black;
           
        
        }

       
        public void RefreshList()
        {
            StockList.Items.Clear();
            foreach (Stock item in observer.GetStocks())
            {
                ListViewItem i = new ListViewItem(item.GetName());
                i.SubItems.Add(item.GetCurrentPrice().ToString());
                i.SubItems.Add(item.GetRegion());
                i.ForeColor = System.Drawing.Color.White;
                StockList.Items.Add(i);
            }
        }

        private void SpecialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            observer.Unsubscribe();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // SpecialForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "SpecialForm";
            this.ResumeLayout(false);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
