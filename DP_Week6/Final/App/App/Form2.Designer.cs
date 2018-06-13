namespace App
{
    partial class Form2
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
            this.lb_items = new System.Windows.Forms.ListBox();
            this.Btn_GetAll = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_GetNext = new System.Windows.Forms.Button();
            this.Btn_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_items
            // 
            this.lb_items.FormattingEnabled = true;
            this.lb_items.Location = new System.Drawing.Point(34, 14);
            this.lb_items.Name = "lb_items";
            this.lb_items.Size = new System.Drawing.Size(202, 238);
            this.lb_items.TabIndex = 0;
            this.lb_items.SelectedIndexChanged += new System.EventHandler(this.Lb_items_SelectedIndexChanged);
            // 
            // Btn_GetAll
            // 
            this.Btn_GetAll.Location = new System.Drawing.Point(57, 258);
            this.Btn_GetAll.Name = "Btn_GetAll";
            this.Btn_GetAll.Size = new System.Drawing.Size(75, 23);
            this.Btn_GetAll.TabIndex = 1;
            this.Btn_GetAll.Text = "Get All";
            this.Btn_GetAll.UseVisualStyleBackColor = true;
            this.Btn_GetAll.Click += new System.EventHandler(this.Btn_GetAll_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(57, 287);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 2;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_GetNext
            // 
            this.Btn_GetNext.Location = new System.Drawing.Point(138, 258);
            this.Btn_GetNext.Name = "Btn_GetNext";
            this.Btn_GetNext.Size = new System.Drawing.Size(75, 23);
            this.Btn_GetNext.TabIndex = 3;
            this.Btn_GetNext.Text = "Get Next";
            this.Btn_GetNext.UseVisualStyleBackColor = true;
            this.Btn_GetNext.Click += new System.EventHandler(this.Btn_GetNext_Click);
            // 
            // Btn_GoBack
            // 
            this.Btn_GoBack.Location = new System.Drawing.Point(138, 287);
            this.Btn_GoBack.Name = "Btn_GoBack";
            this.Btn_GoBack.Size = new System.Drawing.Size(75, 23);
            this.Btn_GoBack.TabIndex = 4;
            this.Btn_GoBack.Text = "Go Back";
            this.Btn_GoBack.UseVisualStyleBackColor = true;
            this.Btn_GoBack.Click += new System.EventHandler(this.Btn_GoBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 339);
            this.Controls.Add(this.Btn_GoBack);
            this.Controls.Add(this.Btn_GetNext);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_GetAll);
            this.Controls.Add(this.lb_items);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_items;
        private System.Windows.Forms.Button Btn_GetAll;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_GetNext;
        private System.Windows.Forms.Button Btn_GoBack;
    }
}