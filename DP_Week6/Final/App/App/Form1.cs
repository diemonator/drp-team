﻿using System;
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
    public partial class Form1 : Form
    {
        ISocialNetwork sn;
        public Form1()
        {
            InitializeComponent();
            Rb_facebook.Checked = true;
        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(sn);
            form.Show();
            Hide();
        }

        private void Rb_Changed(object sender, EventArgs e)
        {
            if (Rb_facebook.Checked)
                sn = new Facebook();
            else
                sn = new LinkedIn();
        }
    }
}
