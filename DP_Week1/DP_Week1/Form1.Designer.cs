namespace DP_Week1
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
            this.rb_FCFS = new System.Windows.Forms.RadioButton();
            this.rb_SSTF = new System.Windows.Forms.RadioButton();
            this.rb_Elevator = new System.Windows.Forms.RadioButton();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.tb_nrToBeEated = new System.Windows.Forms.TextBox();
            this.lb_numbers = new System.Windows.Forms.ListBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_FCFS
            // 
            this.rb_FCFS.AutoSize = true;
            this.rb_FCFS.Checked = true;
            this.rb_FCFS.Location = new System.Drawing.Point(6, 18);
            this.rb_FCFS.Name = "rb_FCFS";
            this.rb_FCFS.Size = new System.Drawing.Size(51, 17);
            this.rb_FCFS.TabIndex = 0;
            this.rb_FCFS.TabStop = true;
            this.rb_FCFS.Text = "FCFS";
            this.rb_FCFS.UseVisualStyleBackColor = true;
            this.rb_FCFS.Click += new System.EventHandler(this.Rb_FCFS_Click);
            // 
            // rb_SSTF
            // 
            this.rb_SSTF.AutoSize = true;
            this.rb_SSTF.Location = new System.Drawing.Point(6, 41);
            this.rb_SSTF.Name = "rb_SSTF";
            this.rb_SSTF.Size = new System.Drawing.Size(52, 17);
            this.rb_SSTF.TabIndex = 1;
            this.rb_SSTF.TabStop = true;
            this.rb_SSTF.Text = "SSTF";
            this.rb_SSTF.UseVisualStyleBackColor = true;
            this.rb_SSTF.Click += new System.EventHandler(this.Rb_FCFS_Click);
            // 
            // rb_Elevator
            // 
            this.rb_Elevator.AutoSize = true;
            this.rb_Elevator.Location = new System.Drawing.Point(6, 64);
            this.rb_Elevator.Name = "rb_Elevator";
            this.rb_Elevator.Size = new System.Drawing.Size(64, 17);
            this.rb_Elevator.TabIndex = 2;
            this.rb_Elevator.TabStop = true;
            this.rb_Elevator.Text = "Elevator";
            this.rb_Elevator.UseVisualStyleBackColor = true;
            this.rb_Elevator.Click += new System.EventHandler(this.Rb_FCFS_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(6, 87);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(6, 116);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // tb_nrToBeEated
            // 
            this.tb_nrToBeEated.Location = new System.Drawing.Point(134, 18);
            this.tb_nrToBeEated.Name = "tb_nrToBeEated";
            this.tb_nrToBeEated.Size = new System.Drawing.Size(47, 20);
            this.tb_nrToBeEated.TabIndex = 5;
            // 
            // lb_numbers
            // 
            this.lb_numbers.FormattingEnabled = true;
            this.lb_numbers.Location = new System.Drawing.Point(134, 44);
            this.lb_numbers.Name = "lb_numbers";
            this.lb_numbers.Size = new System.Drawing.Size(47, 212);
            this.lb_numbers.TabIndex = 6;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(12, 3);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar.Size = new System.Drawing.Size(45, 319);
            this.trackBar.TabIndex = 7;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Controls.Add(this.rb_FCFS);
            this.groupBox1.Controls.Add(this.rb_SSTF);
            this.groupBox1.Controls.Add(this.rb_Elevator);
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Location = new System.Drawing.Point(220, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 147);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // timer
            // 
            this.timer.Interval = 80;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Controls.Add(this.tb_nrToBeEated);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_numbers);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 329);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_FCFS;
        private System.Windows.Forms.RadioButton rb_SSTF;
        private System.Windows.Forms.RadioButton rb_Elevator;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.TextBox tb_nrToBeEated;
        private System.Windows.Forms.ListBox lb_numbers;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

