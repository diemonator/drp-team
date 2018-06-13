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
    public partial class Form1 : Form
    {
        private ISocialNetwork network;
        private IProfileIterator iterator;
        internal Form1(ISocialNetwork serviceProvider)
        {
            InitializeComponent();
            network = serviceProvider;
            iterator = network.CreateIterator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                listBox1.Items.Add(iterator.CurrentProfile().Name);
            }
        }
    }
}
