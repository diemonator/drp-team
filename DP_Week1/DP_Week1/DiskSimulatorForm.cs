using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Week1
{
    public partial class DiskSimulatorForm : Form
    {
        DiskScheduler scheduler;
        private int number;
        public DiskSimulatorForm()
        {
            InitializeComponent();
            scheduler = new DiskScheduler();
            SetButtonsStatus();
            UpdateListBox();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            UpdateOnRunTime();
            ((Button)sender).Enabled = false;
            BtnStop.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SetButtonsStatus();
        }

        private void Rb_FCFS_Click(object sender, EventArgs e)
        {
            ScanType type;
            if (rb_FCFS.Checked)
                type = ScanType.FCFS;
            else if (rb_SSTF.Checked)
                type = ScanType.SSTF;
            else
                type = ScanType.ELEVATOR;
            scheduler.AlgorithumChanged(type);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (number > trackBar.Value)
            {
                trackBar.Value++;
            }
            else if (number < trackBar.Value)
            {
                trackBar.Value--;
            }
            else
            {
                scheduler.NumberConsumed(number);
                UpdateOnRunTime();
            }
        }

        private void UpdateListBox()
        {
            lb_numbers.Items.Clear();
            foreach (int i in scheduler.GetList())
            {
                lb_numbers.Items.Add(i);
            }
        }

        private void UpdateOnRunTime()
        {
            number = scheduler.StartAlgorithum();
            tb_nrToBeEated.Text = number.ToString();
            UpdateListBox();
            lb_numbers.Items.Remove(number);
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar.Value.ToString();
        }

        private void SetButtonsStatus()
        {
            BtnStop.Enabled = false;
            BtnStart.Enabled = true;
        }
    }
}
