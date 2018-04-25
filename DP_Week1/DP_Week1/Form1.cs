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
    public partial class Form1 : Form
    {
        private List<int> listOfNumbers;
        private IAlgorithm algorithm;
        Random randomNumber;
        public Form1()
        {
            InitializeComponent();
            listOfNumbers = new List<int>();
            randomNumber = new Random();
            GenerateNumbers();
            UpdateListBox();
        }

        private void GenerateNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                listOfNumbers.Add(randomNumber.Next(0, 100));
            }
        }

        private void UpdateListBox()
        {
            lb_numbers.Items.Clear();
            foreach (int i in listOfNumbers)
            {
                lb_numbers.Items.Add(i);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Rb_FCFS_Click(object sender, EventArgs e)
        {
            RadioButtonChecker();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void RadioButtonChecker()
        {
            if (rb_FCFS.Checked)
            {
                algorithm = new FCFS();
                tb_nrToBeEated.Text = listOfNumbers[0].ToString();
                listOfNumbers = algorithm.StartAlgorithm(listOfNumbers);
            }
            else if (rb_SSTF.Checked)
            {
                algorithm = new SSTF();
            }
            else
            {
                algorithm = new Elevator();
                tb_nrToBeEated.Text = listOfNumbers[0].ToString();
                listOfNumbers = algorithm.StartAlgorithm(listOfNumbers);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RadioButtonChecker();
            UpdateListBox();
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar.Value.ToString();
        }
    }
}
