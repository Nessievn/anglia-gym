﻿namespace Gym_administration
{
    partial class frm_staff_list
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
            this.txt_dob = new System.Windows.Forms.MaskedTextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_dob = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.dg_staff = new System.Windows.Forms.DataGridView();
            this.button_addstaffmember = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_dateformat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(11, 65);
            this.txt_dob.Mask = "00/00/0000";
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(177, 20);
            this.txt_dob.TabIndex = 2;
            this.txt_dob.ValidatingType = typeof(System.DateTime);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(194, 49);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(36, 13);
            this.label_email.TabIndex = 23;
            this.label_email.Text = "E-Mail";
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(11, 49);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(66, 13);
            this.label_dob.TabIndex = 22;
            this.label_dob.Text = "Date of Birth";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(197, 65);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(177, 20);
            this.txt_email.TabIndex = 3;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(194, 13);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(58, 13);
            this.label_lastName.TabIndex = 20;
            this.label_lastName.Text = "Last Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(197, 26);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(177, 20);
            this.txt_lastName.TabIndex = 0;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(11, 13);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(57, 13);
            this.label_firstName.TabIndex = 18;
            this.label_firstName.Text = "First Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(11, 26);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(177, 20);
            this.txt_firstName.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(389, 63);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dg_staff
            // 
            this.dg_staff.AllowUserToAddRows = false;
            this.dg_staff.AllowUserToDeleteRows = false;
            this.dg_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_staff.Location = new System.Drawing.Point(10, 97);
            this.dg_staff.Name = "dg_staff";
            this.dg_staff.RowTemplate.Height = 24;
            this.dg_staff.Size = new System.Drawing.Size(641, 305);
            this.dg_staff.TabIndex = 6;
            this.dg_staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_staff_CellDoubleClick);
            // 
            // button_addstaffmember
            // 
            this.button_addstaffmember.Location = new System.Drawing.Point(535, 62);
            this.button_addstaffmember.Name = "button_addstaffmember";
            this.button_addstaffmember.Size = new System.Drawing.Size(116, 23);
            this.button_addstaffmember.TabIndex = 5;
            this.button_addstaffmember.Text = "Add Staff Member";
            this.button_addstaffmember.UseVisualStyleBackColor = true;
            this.button_addstaffmember.Click += new System.EventHandler(this.button_addstaffmember_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(532, 410);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(116, 23);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_dateformat
            // 
            this.label_dateformat.AutoSize = true;
            this.label_dateformat.Location = new System.Drawing.Point(119, 49);
            this.label_dateformat.Name = "label_dateformat";
            this.label_dateformat.Size = new System.Drawing.Size(71, 13);
            this.label_dateformat.TabIndex = 27;
            this.label_dateformat.Text = "(dd/mm/yyyy)";
            // 
            // frm_staff_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 445);
            this.Controls.Add(this.label_dateformat);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_addstaffmember);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_dob);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dg_staff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frm_staff_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff List";
            ((System.ComponentModel.ISupportInitialize)(this.dg_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_dob;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView dg_staff;
        private System.Windows.Forms.Button button_addstaffmember;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_dateformat;
    }
}