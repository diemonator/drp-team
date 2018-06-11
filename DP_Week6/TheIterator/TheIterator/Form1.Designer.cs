namespace TheIterator
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
            this.tb_Check = new System.Windows.Forms.TextBox();
            this.lb_Profiles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_GetData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_LinkedIn = new System.Windows.Forms.RadioButton();
            this.Btn_GetProfiles = new System.Windows.Forms.Button();
            this.rb_Facebook = new System.Windows.Forms.RadioButton();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_AddProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Check
            // 
            this.tb_Check.Location = new System.Drawing.Point(9, 19);
            this.tb_Check.Name = "tb_Check";
            this.tb_Check.Size = new System.Drawing.Size(125, 20);
            this.tb_Check.TabIndex = 3;
            // 
            // lb_Profiles
            // 
            this.lb_Profiles.FormattingEnabled = true;
            this.lb_Profiles.Location = new System.Drawing.Point(288, 12);
            this.lb_Profiles.Name = "lb_Profiles";
            this.lb_Profiles.Size = new System.Drawing.Size(250, 355);
            this.lb_Profiles.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_GetData);
            this.groupBox1.Controls.Add(this.tb_Check);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile data by name";
            // 
            // Btn_GetData
            // 
            this.Btn_GetData.Location = new System.Drawing.Point(137, 17);
            this.Btn_GetData.Name = "Btn_GetData";
            this.Btn_GetData.Size = new System.Drawing.Size(127, 23);
            this.Btn_GetData.TabIndex = 8;
            this.Btn_GetData.Text = "Get Data";
            this.Btn_GetData.UseVisualStyleBackColor = true;
            this.Btn_GetData.Click += new System.EventHandler(this.Btn_GetData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_LinkedIn);
            this.groupBox2.Controls.Add(this.Btn_GetProfiles);
            this.groupBox2.Controls.Add(this.rb_Facebook);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 56);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Types of Profiles";
            // 
            // rb_LinkedIn
            // 
            this.rb_LinkedIn.AutoSize = true;
            this.rb_LinkedIn.Location = new System.Drawing.Point(100, 22);
            this.rb_LinkedIn.Name = "rb_LinkedIn";
            this.rb_LinkedIn.Size = new System.Drawing.Size(66, 17);
            this.rb_LinkedIn.TabIndex = 12;
            this.rb_LinkedIn.TabStop = true;
            this.rb_LinkedIn.Text = "LinkedIn";
            this.rb_LinkedIn.UseVisualStyleBackColor = true;
            this.rb_LinkedIn.CheckedChanged += new System.EventHandler(this.Rb_Facebook_CheckedChanged);
            // 
            // Btn_GetProfiles
            // 
            this.Btn_GetProfiles.Location = new System.Drawing.Point(189, 19);
            this.Btn_GetProfiles.Name = "Btn_GetProfiles";
            this.Btn_GetProfiles.Size = new System.Drawing.Size(75, 23);
            this.Btn_GetProfiles.TabIndex = 13;
            this.Btn_GetProfiles.Text = "Get Profiles";
            this.Btn_GetProfiles.UseVisualStyleBackColor = true;
            this.Btn_GetProfiles.Click += new System.EventHandler(this.Btn_GetProfiles_Click);
            // 
            // rb_Facebook
            // 
            this.rb_Facebook.AutoSize = true;
            this.rb_Facebook.Location = new System.Drawing.Point(9, 22);
            this.rb_Facebook.Name = "rb_Facebook";
            this.rb_Facebook.Size = new System.Drawing.Size(73, 17);
            this.rb_Facebook.TabIndex = 11;
            this.rb_Facebook.TabStop = true;
            this.rb_Facebook.Text = "Facebook";
            this.rb_Facebook.UseVisualStyleBackColor = true;
            this.rb_Facebook.CheckedChanged += new System.EventHandler(this.Rb_Facebook_CheckedChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(377, 373);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_AddProfile);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_Email);
            this.groupBox3.Controls.Add(this.tb_Name);
            this.groupBox3.Location = new System.Drawing.Point(12, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 103);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Profile";
            // 
            // Btn_AddProfile
            // 
            this.Btn_AddProfile.Location = new System.Drawing.Point(91, 71);
            this.Btn_AddProfile.Name = "Btn_AddProfile";
            this.Btn_AddProfile.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddProfile.TabIndex = 13;
            this.Btn_AddProfile.Text = "Add Profile";
            this.Btn_AddProfile.UseVisualStyleBackColor = true;
            this.Btn_AddProfile.Click += new System.EventHandler(this.Btn_AddProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Email Here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Name Here:";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(139, 45);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(131, 20);
            this.tb_Email.TabIndex = 3;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(6, 45);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(127, 20);
            this.tb_Name.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 93);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 416);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Profiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Check;
        private System.Windows.Forms.ListBox lb_Profiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_GetData;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.RadioButton rb_Facebook;
        private System.Windows.Forms.RadioButton rb_LinkedIn;
        private System.Windows.Forms.Button Btn_GetProfiles;
        private System.Windows.Forms.Button Btn_AddProfile;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

