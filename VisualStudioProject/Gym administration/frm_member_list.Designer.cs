﻿namespace Gym_administration
{
    partial class frm_member_list
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
            this.dg_members = new System.Windows.Forms.DataGridView();
            this.button_search = new System.Windows.Forms.Button();
            this.txt_membernum = new System.Windows.Forms.TextBox();
            this.label_membernum = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label_dob = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.txt_dob = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_members)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_members
            // 
            this.dg_members.AllowUserToAddRows = false;
            this.dg_members.AllowUserToDeleteRows = false;
            this.dg_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_members.Location = new System.Drawing.Point(16, 156);
            this.dg_members.Margin = new System.Windows.Forms.Padding(4);
            this.dg_members.Name = "dg_members";
            this.dg_members.RowTemplate.Height = 24;
            this.dg_members.Size = new System.Drawing.Size(855, 375);
            this.dg_members.TabIndex = 0;
            this.dg_members.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_members_CellDoubleClick);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(401, 22);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 28);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // txt_membernum
            // 
            this.txt_membernum.Location = new System.Drawing.Point(17, 25);
            this.txt_membernum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_membernum.Name = "txt_membernum";
            this.txt_membernum.Size = new System.Drawing.Size(235, 22);
            this.txt_membernum.TabIndex = 2;
            // 
            // label_membernum
            // 
            this.label_membernum.AutoSize = true;
            this.label_membernum.Location = new System.Drawing.Point(17, 9);
            this.label_membernum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_membernum.Name = "label_membernum";
            this.label_membernum.Size = new System.Drawing.Size(113, 17);
            this.label_membernum.TabIndex = 3;
            this.label_membernum.Text = "Member Number";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(17, 53);
            this.label_firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(76, 17);
            this.label_firstName.TabIndex = 5;
            this.label_firstName.Text = "First Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(17, 69);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(235, 22);
            this.txt_firstName.TabIndex = 4;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(261, 53);
            this.label_lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(76, 17);
            this.label_lastName.TabIndex = 7;
            this.label_lastName.Text = "Last Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(265, 69);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(235, 22);
            this.txt_lastName.TabIndex = 6;
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(17, 97);
            this.label_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(87, 17);
            this.label_dob.TabIndex = 9;
            this.label_dob.Text = "Date of Birth";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(265, 117);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(235, 22);
            this.txt_email.TabIndex = 8;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(261, 97);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(47, 17);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "E-Mail";
            // 
            // txt_dob
            // 
            this.txt_dob.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_dob.Location = new System.Drawing.Point(17, 117);
            this.txt_dob.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dob.Mask = "00/00/0000";
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(235, 22);
            this.txt_dob.TabIndex = 12;
            this.txt_dob.ValidatingType = typeof(System.DateTime);
            // 
            // frm_member_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 542);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_dob);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label_membernum);
            this.Controls.Add(this.txt_membernum);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dg_members);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_member_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members List Form";
            this.Load += new System.EventHandler(this.frm_member_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_members)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_members;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox txt_membernum;
        private System.Windows.Forms.Label label_membernum;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.MaskedTextBox txt_dob;
    }
}