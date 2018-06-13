namespace App
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
            this.Btn_Change = new System.Windows.Forms.Button();
            this.Rb_LinkedIn = new System.Windows.Forms.RadioButton();
            this.Rb_facebook = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Btn_Change
            // 
            this.Btn_Change.Location = new System.Drawing.Point(37, 35);
            this.Btn_Change.Name = "Btn_Change";
            this.Btn_Change.Size = new System.Drawing.Size(130, 23);
            this.Btn_Change.TabIndex = 5;
            this.Btn_Change.Text = "Change Profile Type";
            this.Btn_Change.UseVisualStyleBackColor = true;
            this.Btn_Change.Click += new System.EventHandler(this.Btn_Change_Click);
            // 
            // Rb_LinkedIn
            // 
            this.Rb_LinkedIn.AutoSize = true;
            this.Rb_LinkedIn.Location = new System.Drawing.Point(123, 12);
            this.Rb_LinkedIn.Name = "Rb_LinkedIn";
            this.Rb_LinkedIn.Size = new System.Drawing.Size(66, 17);
            this.Rb_LinkedIn.TabIndex = 4;
            this.Rb_LinkedIn.TabStop = true;
            this.Rb_LinkedIn.Text = "LinkedIn";
            this.Rb_LinkedIn.UseVisualStyleBackColor = true;
            this.Rb_LinkedIn.CheckedChanged += new System.EventHandler(this.Rb_Changed);
            // 
            // Rb_facebook
            // 
            this.Rb_facebook.AutoSize = true;
            this.Rb_facebook.Location = new System.Drawing.Point(12, 12);
            this.Rb_facebook.Name = "Rb_facebook";
            this.Rb_facebook.Size = new System.Drawing.Size(73, 17);
            this.Rb_facebook.TabIndex = 3;
            this.Rb_facebook.TabStop = true;
            this.Rb_facebook.Text = "Facebook";
            this.Rb_facebook.UseVisualStyleBackColor = true;
            this.Rb_facebook.CheckedChanged += new System.EventHandler(this.Rb_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 93);
            this.Controls.Add(this.Btn_Change);
            this.Controls.Add(this.Rb_LinkedIn);
            this.Controls.Add(this.Rb_facebook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Change;
        private System.Windows.Forms.RadioButton Rb_LinkedIn;
        private System.Windows.Forms.RadioButton Rb_facebook;
    }
}

