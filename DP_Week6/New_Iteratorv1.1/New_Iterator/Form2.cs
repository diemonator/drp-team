using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Iterator
{
    public partial class Form2 : Form
    {
        ISocialNetwork sn;
        IProfileIterator iterator;
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sn = new Facebook();
            }
            else
            {
                sn = new LinkedIn();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sn == null)
                sn = new Facebook();
            Form1 form = new Form1(sn);
            form.Show();
            Close();
        }
    }
}
