namespace StockMarket
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StockView = new System.Windows.Forms.ListView();
            this.NameCollum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceCollum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegionCollum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AddBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StockView
            // 
            this.StockView.AllowColumnReorder = true;
            this.StockView.AutoArrange = false;
            this.StockView.BackColor = System.Drawing.Color.Black;
            this.StockView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCollum,
            this.PriceCollum,
            this.RegionCollum});
            this.StockView.Dock = System.Windows.Forms.DockStyle.Top;
            this.StockView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockView.ForeColor = System.Drawing.SystemColors.Window;
            this.StockView.Location = new System.Drawing.Point(0, 0);
            this.StockView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StockView.Name = "StockView";
            this.StockView.Size = new System.Drawing.Size(881, 449);
            this.StockView.TabIndex = 0;
            this.StockView.UseCompatibleStateImageBehavior = false;
            this.StockView.View = System.Windows.Forms.View.Details;
            // 
            // NameCollum
            // 
            this.NameCollum.Text = "Name";
            this.NameCollum.Width = 220;
            // 
            // PriceCollum
            // 
            this.PriceCollum.Text = "Price";
            this.PriceCollum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceCollum.Width = 220;
            // 
            // RegionCollum
            // 
            this.RegionCollum.Text = "Region";
            this.RegionCollum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RegionCollum.Width = 220;
            // 
            // StockTimer
            // 
            this.StockTimer.Interval = 2000;
            this.StockTimer.Tick += new System.EventHandler(this.StockTimer_Tick);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 454);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(120, 37);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "AddObserver";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EU",
            "AS",
            "US"});
            this.comboBox1.Location = new System.Drawing.Point(247, 465);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Region";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 518);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.StockView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
          
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView StockView;
        private System.Windows.Forms.ColumnHeader PriceCollum;
        private System.Windows.Forms.ColumnHeader RegionCollum;
        public System.Windows.Forms.ColumnHeader NameCollum;
        private System.Windows.Forms.Timer StockTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

