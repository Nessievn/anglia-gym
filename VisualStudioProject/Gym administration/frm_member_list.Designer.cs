namespace Gym_administration
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
            this.label_firstName = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label_dob = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.txt_dob = new System.Windows.Forms.MaskedTextBox();
            this.label_dateformat = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_lblNumberOfPeople = new System.Windows.Forms.Label();
            this.label_numberOfPeople = new System.Windows.Forms.Label();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_addNewMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_members)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_members
            // 
            this.dg_members.AllowUserToAddRows = false;
            this.dg_members.AllowUserToDeleteRows = false;
            this.dg_members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_members.Location = new System.Drawing.Point(16, 156);
            this.dg_members.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_members.Name = "dg_members";
            this.dg_members.RowTemplate.Height = 24;
            this.dg_members.Size = new System.Drawing.Size(855, 375);
            this.dg_members.TabIndex = 10;
            this.dg_members.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_members_CellDoubleClick);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(532, 21);
            this.button_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(135, 28);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(13, 50);
            this.label_firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(76, 17);
            this.label_firstName.TabIndex = 5;
            this.label_firstName.Text = "First Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(16, 71);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(235, 22);
            this.txt_firstName.TabIndex = 3;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(261, 50);
            this.label_lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(76, 17);
            this.label_lastName.TabIndex = 7;
            this.label_lastName.Text = "Last Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(265, 71);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(235, 22);
            this.txt_lastName.TabIndex = 4;
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(13, 98);
            this.label_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(87, 17);
            this.label_dob.TabIndex = 9;
            this.label_dob.Text = "Date of Birth";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(265, 119);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(235, 22);
            this.txt_email.TabIndex = 6;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(261, 98);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(47, 17);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "E-Mail";
            // 
            // txt_dob
            // 
            this.txt_dob.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_dob.Location = new System.Drawing.Point(16, 119);
            this.txt_dob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dob.Mask = "00/00/0000";
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(235, 22);
            this.txt_dob.TabIndex = 5;
            this.txt_dob.ValidatingType = typeof(System.DateTime);
            // 
            // label_dateformat
            // 
            this.label_dateformat.AutoSize = true;
            this.label_dateformat.Location = new System.Drawing.Point(159, 98);
            this.label_dateformat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dateformat.Name = "label_dateformat";
            this.label_dateformat.Size = new System.Drawing.Size(92, 17);
            this.label_dateformat.TabIndex = 13;
            this.label_dateformat.Text = "(dd/mm/yyyy)";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "All",
            "Individual",
            "Group",
            "Family",
            "Student",
            "Company",
            "Over 60",
            "Society",
            "Sports Team",
            "Other"});
            this.cmb_type.Location = new System.Drawing.Point(265, 23);
            this.cmb_type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(235, 24);
            this.cmb_type.TabIndex = 2;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(261, 4);
            this.label_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(121, 17);
            this.label_type.TabIndex = 48;
            this.label_type.Text = "Membership Type";
            // 
            // label_lblNumberOfPeople
            // 
            this.label_lblNumberOfPeople.AutoSize = true;
            this.label_lblNumberOfPeople.Location = new System.Drawing.Point(528, 128);
            this.label_lblNumberOfPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lblNumberOfPeople.Name = "label_lblNumberOfPeople";
            this.label_lblNumberOfPeople.Size = new System.Drawing.Size(215, 17);
            this.label_lblNumberOfPeople.TabIndex = 49;
            this.label_lblNumberOfPeople.Text = "Number of people on current list:";
            // 
            // label_numberOfPeople
            // 
            this.label_numberOfPeople.AutoSize = true;
            this.label_numberOfPeople.Location = new System.Drawing.Point(749, 128);
            this.label_numberOfPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_numberOfPeople.Name = "label_numberOfPeople";
            this.label_numberOfPeople.Size = new System.Drawing.Size(16, 17);
            this.label_numberOfPeople.TabIndex = 50;
            this.label_numberOfPeople.Text = "0";
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(532, 62);
            this.button_copy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(135, 54);
            this.button_copy.TabIndex = 9;
            this.button_copy.Text = "Copy all selected cells to clipboard";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_addNewMember
            // 
            this.button_addNewMember.Location = new System.Drawing.Point(729, 21);
            this.button_addNewMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_addNewMember.Name = "button_addNewMember";
            this.button_addNewMember.Size = new System.Drawing.Size(135, 28);
            this.button_addNewMember.TabIndex = 8;
            this.button_addNewMember.Text = "Add New Member";
            this.button_addNewMember.UseVisualStyleBackColor = true;
            this.button_addNewMember.Click += new System.EventHandler(this.button_addNewMember_Click);
            // 
            // frm_member_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 542);
            this.Controls.Add(this.button_addNewMember);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.label_numberOfPeople);
            this.Controls.Add(this.label_lblNumberOfPeople);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label_dateformat);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_dob);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dg_members);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.MaskedTextBox txt_dob;
        private System.Windows.Forms.Label label_dateformat;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_lblNumberOfPeople;
        private System.Windows.Forms.Label label_numberOfPeople;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_addNewMember;
    }
}