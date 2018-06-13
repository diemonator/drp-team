using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form2 : Form
    {
        ISocialNetwork sn;
        IProfileIterator iterator;
        internal Form2(ISocialNetwork sn)
        {
            InitializeComponent();
            this.sn = sn;
            iterator = sn.CreateIterator();
        }

        private void Btn_GetAll_Click(object sender, EventArgs e)
        {
            lb_items.Items.Clear();
            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                lb_items.Items.Add(iterator.CurrentProfile().Name);
            }
            iterator.First();
        }

        private void Btn_GetNext_Click(object sender, EventArgs e)
        {
            if (sn.Count == lb_items.Items.Count)
            {
                lb_items.Items.Clear();
            }
            if (!iterator.IsDone())
            {
                lb_items.Items.Add(iterator.CurrentProfile().Name);
                iterator.Next();
            }
            else
            {
                MessageBox.Show("You have reached the end of the profile list the profiles will be reset", "Warrning");
                iterator.First();
                lb_items.Items.Clear();
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            lb_items.Items.Clear();
        }

        private void Btn_GoBack_Click(object sender, EventArgs e)
        {
            EnterParentForm();
            Close();
        }

        private void Lb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(sn[lb_items.SelectedIndex].Name + "'s email is " + sn[lb_items.SelectedIndex].Email, "Additional Info");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnterParentForm();
        }

        private void EnterParentForm()
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Form1);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }
    }
}
