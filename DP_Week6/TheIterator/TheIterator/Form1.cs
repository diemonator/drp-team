using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheIterator
{
    public partial class Form1 : Form
    {
        private IProfileIterator _iterator;
        private SocialNetwork _socialNetwork;
        private Facebook facebook;
        private LinkedIn linkedIn;
        private string profileType = null;

        public Form1()
        {
            InitializeComponent();
            facebook = new Facebook();
            linkedIn = new LinkedIn();
            rb_Facebook.Checked = true;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            lb_Profiles.Items.Clear();
        }

        private void Rb_Facebook_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Facebook.Checked)
            { 
                _iterator = facebook.CreateIterator();
                _socialNetwork = facebook;
                profileType = "Facebook";
            }
            else
            { 
                _iterator = linkedIn.CreateIterator();
                _socialNetwork = linkedIn;
                profileType = "LinkedIn";
            }
        }

        private void Btn_GetProfiles_Click(object sender, EventArgs e)
        {
            Profile myprofile = _iterator.First();
            lb_Profiles.Items.Add("**********"+ profileType +"*********");
            while (!_iterator.IsDone())
            {
                lb_Profiles.Items.Add(myprofile.Name + " and email " + myprofile.Email);
                myprofile = _iterator.Next();
            }
            lb_Profiles.Items.Add("*********END*********");
        }

        private void Btn_GetData_Click(object sender, EventArgs e)
        {
            for (Profile p = _iterator.First(); !_iterator.IsDone(); p = _iterator.Next())
            {
                if (p.Name == tb_Check.Text && !String.IsNullOrWhiteSpace(tb_Check.Text))
                { 
                    MessageBox.Show(p.Name + " " + p.Email, profileType + "Profile" );
                }
            }
        }

        private void Btn_AddProfile_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tb_Name.Text) || !String.IsNullOrWhiteSpace(tb_Email.Text))
            {
                _socialNetwork[_socialNetwork.Count] = new Profile(tb_Name.Text,tb_Email.Text);
            }
        }
    }
}
