﻿namespace Gym_administration
{
    partial class frm_staff
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
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.label_position = new System.Windows.Forms.Label();
            this.cmb_contract = new System.Windows.Forms.ComboBox();
            this.txt_pc = new System.Windows.Forms.MaskedTextBox();
            this.label_contract = new System.Windows.Forms.Label();
            this.label_pc = new System.Windows.Forms.Label();
            this.txt_county = new System.Windows.Forms.TextBox();
            this.label_county = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_saveStay = new System.Windows.Forms.Button();
            this.txt_medical_notes = new System.Windows.Forms.TextBox();
            this.label_medical_notes = new System.Windows.Forms.Label();
            this.txt_dob = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_emerg_mobile = new System.Windows.Forms.TextBox();
            this.label_emerg_mobile = new System.Windows.Forms.Label();
            this.txt_emerg_telephone = new System.Windows.Forms.TextBox();
            this.label_emerg_telephone = new System.Windows.Forms.Label();
            this.txt_allergies = new System.Windows.Forms.TextBox();
            this.label_allergies = new System.Windows.Forms.Label();
            this.txt_emerg_relation = new System.Windows.Forms.TextBox();
            this.label_emerg_relation = new System.Windows.Forms.Label();
            this.txt_doctor_phone = new System.Windows.Forms.TextBox();
            this.label_doctor_phone = new System.Windows.Forms.Label();
            this.txt_doctor_name = new System.Windows.Forms.TextBox();
            this.label_doctor_name = new System.Windows.Forms.Label();
            this.txt_emerg_name = new System.Windows.Forms.TextBox();
            this.label_emerg_name = new System.Windows.Forms.Label();
            this.label_emergencycontact = new System.Windows.Forms.Label();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.label_address2 = new System.Windows.Forms.Label();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.label_address1 = new System.Windows.Forms.Label();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.label_telephone = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_dob = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.label_staffinfo = new System.Windows.Forms.Label();
            this.txt_qualifications = new System.Windows.Forms.TextBox();
            this.label_qualifications = new System.Windows.Forms.Label();
            this.label_mobile = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_natinsnumb = new System.Windows.Forms.TextBox();
            this.label_natinsnumb = new System.Windows.Forms.Label();
            this.txt_contract_start = new System.Windows.Forms.MaskedTextBox();
            this.label_contract_start = new System.Windows.Forms.Label();
            this.txt_contract_finish = new System.Windows.Forms.MaskedTextBox();
            this.label_contract_finish = new System.Windows.Forms.Label();
            this.button_equipmentbooking = new System.Windows.Forms.Button();
            this.dg_currentborrows = new System.Windows.Forms.DataGridView();
            this.label_currentborrows = new System.Windows.Forms.Label();
            this.label_dateformat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_saveClose = new System.Windows.Forms.Button();
            this.button_saveOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_currentborrows)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_position
            // 
            this.cmb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Items.AddRange(new object[] {
            "Instructor",
            "Reception",
            "Manager"});
            this.cmb_position.Location = new System.Drawing.Point(229, 332);
            this.cmb_position.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(160, 24);
            this.cmb_position.TabIndex = 16;
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(226, 313);
            this.label_position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(58, 17);
            this.label_position.TabIndex = 104;
            this.label_position.Text = "Position";
            // 
            // cmb_contract
            // 
            this.cmb_contract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_contract.FormattingEnabled = true;
            this.cmb_contract.Items.AddRange(new object[] {
            "Casual",
            "Temporary",
            "Part-time",
            "Full-time"});
            this.cmb_contract.Location = new System.Drawing.Point(229, 285);
            this.cmb_contract.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_contract.Name = "cmb_contract";
            this.cmb_contract.Size = new System.Drawing.Size(160, 24);
            this.cmb_contract.TabIndex = 15;
            // 
            // txt_pc
            // 
            this.txt_pc.Location = new System.Drawing.Point(13, 285);
            this.txt_pc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pc.Mask = ">LCCC 9LL";
            this.txt_pc.Name = "txt_pc";
            this.txt_pc.Size = new System.Drawing.Size(132, 22);
            this.txt_pc.TabIndex = 8;
            // 
            // label_contract
            // 
            this.label_contract.AutoSize = true;
            this.label_contract.Location = new System.Drawing.Point(226, 264);
            this.label_contract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_contract.Name = "label_contract";
            this.label_contract.Size = new System.Drawing.Size(121, 17);
            this.label_contract.TabIndex = 119;
            this.label_contract.Text = "Employment Type";
            // 
            // label_pc
            // 
            this.label_pc.AutoSize = true;
            this.label_pc.Location = new System.Drawing.Point(10, 264);
            this.label_pc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pc.Name = "label_pc";
            this.label_pc.Size = new System.Drawing.Size(73, 17);
            this.label_pc.TabIndex = 120;
            this.label_pc.Text = "Post Code";
            // 
            // txt_county
            // 
            this.txt_county.Location = new System.Drawing.Point(229, 238);
            this.txt_county.Margin = new System.Windows.Forms.Padding(4);
            this.txt_county.Name = "txt_county";
            this.txt_county.Size = new System.Drawing.Size(183, 22);
            this.txt_county.TabIndex = 7;
            // 
            // label_county
            // 
            this.label_county.AutoSize = true;
            this.label_county.Location = new System.Drawing.Point(226, 217);
            this.label_county.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_county.Name = "label_county";
            this.label_county.Size = new System.Drawing.Size(52, 17);
            this.label_county.TabIndex = 101;
            this.label_county.Text = "County";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(13, 238);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(183, 22);
            this.txt_city.TabIndex = 6;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(10, 217);
            this.label_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(31, 17);
            this.label_city.TabIndex = 121;
            this.label_city.Text = "City";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(13, 500);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(116, 32);
            this.button_cancel.TabIndex = 26;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_saveStay
            // 
            this.button_saveStay.Location = new System.Drawing.Point(618, 500);
            this.button_saveStay.Margin = new System.Windows.Forms.Padding(4);
            this.button_saveStay.Name = "button_saveStay";
            this.button_saveStay.Size = new System.Drawing.Size(116, 32);
            this.button_saveStay.TabIndex = 29;
            this.button_saveStay.Text = "Save and Stay";
            this.button_saveStay.UseVisualStyleBackColor = true;
            this.button_saveStay.Click += new System.EventHandler(this.button_saveStay_Click);
            // 
            // txt_medical_notes
            // 
            this.txt_medical_notes.Location = new System.Drawing.Point(461, 285);
            this.txt_medical_notes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_medical_notes.Multiline = true;
            this.txt_medical_notes.Name = "txt_medical_notes";
            this.txt_medical_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_medical_notes.Size = new System.Drawing.Size(397, 73);
            this.txt_medical_notes.TabIndex = 24;
            // 
            // label_medical_notes
            // 
            this.label_medical_notes.AutoSize = true;
            this.label_medical_notes.Location = new System.Drawing.Point(459, 264);
            this.label_medical_notes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_medical_notes.Name = "label_medical_notes";
            this.label_medical_notes.Size = new System.Drawing.Size(97, 17);
            this.label_medical_notes.TabIndex = 122;
            this.label_medical_notes.Text = "Medical Notes";
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(229, 50);
            this.txt_dob.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dob.Mask = "00/00/0000";
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(132, 22);
            this.txt_dob.TabIndex = 12;
            this.txt_dob.ValidatingType = typeof(System.DateTime);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(457, 141);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 20);
            this.label19.TabIndex = 123;
            this.label19.Text = "Medical Information:";
            // 
            // txt_emerg_mobile
            // 
            this.txt_emerg_mobile.Location = new System.Drawing.Point(675, 97);
            this.txt_emerg_mobile.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emerg_mobile.Name = "txt_emerg_mobile";
            this.txt_emerg_mobile.Size = new System.Drawing.Size(183, 22);
            this.txt_emerg_mobile.TabIndex = 20;
            // 
            // label_emerg_mobile
            // 
            this.label_emerg_mobile.AutoSize = true;
            this.label_emerg_mobile.Location = new System.Drawing.Point(672, 76);
            this.label_emerg_mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emerg_mobile.Name = "label_emerg_mobile";
            this.label_emerg_mobile.Size = new System.Drawing.Size(49, 17);
            this.label_emerg_mobile.TabIndex = 124;
            this.label_emerg_mobile.Text = "Mobile";
            // 
            // txt_emerg_telephone
            // 
            this.txt_emerg_telephone.Location = new System.Drawing.Point(461, 97);
            this.txt_emerg_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emerg_telephone.Name = "txt_emerg_telephone";
            this.txt_emerg_telephone.Size = new System.Drawing.Size(183, 22);
            this.txt_emerg_telephone.TabIndex = 19;
            // 
            // label_emerg_telephone
            // 
            this.label_emerg_telephone.AutoSize = true;
            this.label_emerg_telephone.Location = new System.Drawing.Point(458, 76);
            this.label_emerg_telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emerg_telephone.Name = "label_emerg_telephone";
            this.label_emerg_telephone.Size = new System.Drawing.Size(76, 17);
            this.label_emerg_telephone.TabIndex = 125;
            this.label_emerg_telephone.Text = "Telephone";
            // 
            // txt_allergies
            // 
            this.txt_allergies.Location = new System.Drawing.Point(462, 238);
            this.txt_allergies.Margin = new System.Windows.Forms.Padding(4);
            this.txt_allergies.Name = "txt_allergies";
            this.txt_allergies.Size = new System.Drawing.Size(183, 22);
            this.txt_allergies.TabIndex = 23;
            // 
            // label_allergies
            // 
            this.label_allergies.AutoSize = true;
            this.label_allergies.Location = new System.Drawing.Point(458, 217);
            this.label_allergies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_allergies.Name = "label_allergies";
            this.label_allergies.Size = new System.Drawing.Size(62, 17);
            this.label_allergies.TabIndex = 126;
            this.label_allergies.Text = "Allergies";
            // 
            // txt_emerg_relation
            // 
            this.txt_emerg_relation.Location = new System.Drawing.Point(675, 50);
            this.txt_emerg_relation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emerg_relation.Name = "txt_emerg_relation";
            this.txt_emerg_relation.Size = new System.Drawing.Size(183, 22);
            this.txt_emerg_relation.TabIndex = 18;
            // 
            // label_emerg_relation
            // 
            this.label_emerg_relation.AutoSize = true;
            this.label_emerg_relation.Location = new System.Drawing.Point(672, 29);
            this.label_emerg_relation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emerg_relation.Name = "label_emerg_relation";
            this.label_emerg_relation.Size = new System.Drawing.Size(60, 17);
            this.label_emerg_relation.TabIndex = 127;
            this.label_emerg_relation.Text = "Relation";
            // 
            // txt_doctor_phone
            // 
            this.txt_doctor_phone.Location = new System.Drawing.Point(675, 191);
            this.txt_doctor_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doctor_phone.Name = "txt_doctor_phone";
            this.txt_doctor_phone.Size = new System.Drawing.Size(183, 22);
            this.txt_doctor_phone.TabIndex = 22;
            // 
            // label_doctor_phone
            // 
            this.label_doctor_phone.AutoSize = true;
            this.label_doctor_phone.Location = new System.Drawing.Point(672, 170);
            this.label_doctor_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_doctor_phone.Name = "label_doctor_phone";
            this.label_doctor_phone.Size = new System.Drawing.Size(76, 17);
            this.label_doctor_phone.TabIndex = 128;
            this.label_doctor_phone.Text = "Telephone";
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Location = new System.Drawing.Point(461, 191);
            this.txt_doctor_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(183, 22);
            this.txt_doctor_name.TabIndex = 21;
            // 
            // label_doctor_name
            // 
            this.label_doctor_name.AutoSize = true;
            this.label_doctor_name.Location = new System.Drawing.Point(458, 170);
            this.label_doctor_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_doctor_name.Name = "label_doctor_name";
            this.label_doctor_name.Size = new System.Drawing.Size(91, 17);
            this.label_doctor_name.TabIndex = 129;
            this.label_doctor_name.Text = "Doctor Name";
            // 
            // txt_emerg_name
            // 
            this.txt_emerg_name.Location = new System.Drawing.Point(461, 50);
            this.txt_emerg_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emerg_name.Name = "txt_emerg_name";
            this.txt_emerg_name.Size = new System.Drawing.Size(183, 22);
            this.txt_emerg_name.TabIndex = 17;
            // 
            // label_emerg_name
            // 
            this.label_emerg_name.AutoSize = true;
            this.label_emerg_name.Location = new System.Drawing.Point(458, 29);
            this.label_emerg_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emerg_name.Name = "label_emerg_name";
            this.label_emerg_name.Size = new System.Drawing.Size(45, 17);
            this.label_emerg_name.TabIndex = 130;
            this.label_emerg_name.Text = "Name";
            // 
            // label_emergencycontact
            // 
            this.label_emergencycontact.AutoSize = true;
            this.label_emergencycontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emergencycontact.Location = new System.Drawing.Point(457, 9);
            this.label_emergencycontact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emergencycontact.Name = "label_emergencycontact";
            this.label_emergencycontact.Size = new System.Drawing.Size(161, 20);
            this.label_emergencycontact.TabIndex = 83;
            this.label_emergencycontact.Text = "Emergency Contact:";
            // 
            // txt_address2
            // 
            this.txt_address2.Location = new System.Drawing.Point(229, 191);
            this.txt_address2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(183, 22);
            this.txt_address2.TabIndex = 5;
            // 
            // label_address2
            // 
            this.label_address2.AutoSize = true;
            this.label_address2.Location = new System.Drawing.Point(226, 170);
            this.label_address2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_address2.Name = "label_address2";
            this.label_address2.Size = new System.Drawing.Size(72, 17);
            this.label_address2.TabIndex = 131;
            this.label_address2.Text = "Address 2";
            // 
            // txt_address1
            // 
            this.txt_address1.Location = new System.Drawing.Point(13, 191);
            this.txt_address1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(183, 22);
            this.txt_address1.TabIndex = 4;
            // 
            // label_address1
            // 
            this.label_address1.AutoSize = true;
            this.label_address1.Location = new System.Drawing.Point(10, 170);
            this.label_address1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_address1.Name = "label_address1";
            this.label_address1.Size = new System.Drawing.Size(72, 17);
            this.label_address1.TabIndex = 132;
            this.label_address1.Text = "Address 1";
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(229, 144);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(183, 22);
            this.txt_telephone.TabIndex = 14;
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(226, 123);
            this.label_telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(76, 17);
            this.label_telephone.TabIndex = 133;
            this.label_telephone.Text = "Telephone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(13, 144);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(183, 22);
            this.txt_email.TabIndex = 3;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(10, 123);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(53, 17);
            this.label_email.TabIndex = 134;
            this.label_email.Text = "E-Mail";
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dob.Location = new System.Drawing.Point(226, 29);
            this.label_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(100, 17);
            this.label_dob.TabIndex = 136;
            this.label_dob.Text = "Date of Birth";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(13, 97);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(183, 22);
            this.txt_lastName.TabIndex = 2;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(10, 76);
            this.label_lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(76, 17);
            this.label_lastName.TabIndex = 137;
            this.label_lastName.Text = "Last Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(13, 50);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(183, 22);
            this.txt_firstName.TabIndex = 1;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(10, 29);
            this.label_firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(76, 17);
            this.label_firstName.TabIndex = 138;
            this.label_firstName.Text = "First Name";
            // 
            // label_staffinfo
            // 
            this.label_staffinfo.AutoSize = true;
            this.label_staffinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staffinfo.Location = new System.Drawing.Point(13, 9);
            this.label_staffinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_staffinfo.Name = "label_staffinfo";
            this.label_staffinfo.Size = new System.Drawing.Size(152, 20);
            this.label_staffinfo.TabIndex = 139;
            this.label_staffinfo.Text = "GYM STAFF INFO:";
            // 
            // txt_qualifications
            // 
            this.txt_qualifications.Location = new System.Drawing.Point(461, 401);
            this.txt_qualifications.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qualifications.Multiline = true;
            this.txt_qualifications.Name = "txt_qualifications";
            this.txt_qualifications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_qualifications.Size = new System.Drawing.Size(397, 91);
            this.txt_qualifications.TabIndex = 25;
            // 
            // label_qualifications
            // 
            this.label_qualifications.AutoSize = true;
            this.label_qualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qualifications.Location = new System.Drawing.Point(457, 375);
            this.label_qualifications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_qualifications.Name = "label_qualifications";
            this.label_qualifications.Size = new System.Drawing.Size(116, 20);
            this.label_qualifications.TabIndex = 118;
            this.label_qualifications.Text = "Qualifications:";
            // 
            // label_mobile
            // 
            this.label_mobile.AutoSize = true;
            this.label_mobile.Location = new System.Drawing.Point(226, 76);
            this.label_mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mobile.Name = "label_mobile";
            this.label_mobile.Size = new System.Drawing.Size(49, 17);
            this.label_mobile.TabIndex = 135;
            this.label_mobile.Text = "Mobile";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(229, 97);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(183, 22);
            this.txt_mobile.TabIndex = 13;
            // 
            // txt_natinsnumb
            // 
            this.txt_natinsnumb.Location = new System.Drawing.Point(13, 332);
            this.txt_natinsnumb.Margin = new System.Windows.Forms.Padding(4);
            this.txt_natinsnumb.Name = "txt_natinsnumb";
            this.txt_natinsnumb.Size = new System.Drawing.Size(183, 22);
            this.txt_natinsnumb.TabIndex = 9;
            // 
            // label_natinsnumb
            // 
            this.label_natinsnumb.AutoSize = true;
            this.label_natinsnumb.Location = new System.Drawing.Point(10, 311);
            this.label_natinsnumb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_natinsnumb.Name = "label_natinsnumb";
            this.label_natinsnumb.Size = new System.Drawing.Size(180, 17);
            this.label_natinsnumb.TabIndex = 117;
            this.label_natinsnumb.Text = "National Insurance Number";
            // 
            // txt_contract_start
            // 
            this.txt_contract_start.Location = new System.Drawing.Point(13, 379);
            this.txt_contract_start.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contract_start.Mask = "00/00/0000";
            this.txt_contract_start.Name = "txt_contract_start";
            this.txt_contract_start.Size = new System.Drawing.Size(132, 22);
            this.txt_contract_start.TabIndex = 10;
            this.txt_contract_start.ValidatingType = typeof(System.DateTime);
            // 
            // label_contract_start
            // 
            this.label_contract_start.AutoSize = true;
            this.label_contract_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contract_start.Location = new System.Drawing.Point(10, 358);
            this.label_contract_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_contract_start.Name = "label_contract_start";
            this.label_contract_start.Size = new System.Drawing.Size(109, 17);
            this.label_contract_start.TabIndex = 116;
            this.label_contract_start.Text = "Contract Start";
            // 
            // txt_contract_finish
            // 
            this.txt_contract_finish.Location = new System.Drawing.Point(13, 426);
            this.txt_contract_finish.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contract_finish.Mask = "00/00/0000";
            this.txt_contract_finish.Name = "txt_contract_finish";
            this.txt_contract_finish.Size = new System.Drawing.Size(132, 22);
            this.txt_contract_finish.TabIndex = 11;
            this.txt_contract_finish.ValidatingType = typeof(System.DateTime);
            // 
            // label_contract_finish
            // 
            this.label_contract_finish.AutoSize = true;
            this.label_contract_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contract_finish.Location = new System.Drawing.Point(10, 405);
            this.label_contract_finish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_contract_finish.Name = "label_contract_finish";
            this.label_contract_finish.Size = new System.Drawing.Size(117, 17);
            this.label_contract_finish.TabIndex = 115;
            this.label_contract_finish.Text = "Contract Finish";
            // 
            // button_equipmentbooking
            // 
            this.button_equipmentbooking.Location = new System.Drawing.Point(229, 500);
            this.button_equipmentbooking.Name = "button_equipmentbooking";
            this.button_equipmentbooking.Size = new System.Drawing.Size(164, 32);
            this.button_equipmentbooking.TabIndex = 27;
            this.button_equipmentbooking.Text = "Equipment Booking";
            this.button_equipmentbooking.UseVisualStyleBackColor = true;
            this.button_equipmentbooking.Click += new System.EventHandler(this.button_equipmentbooking_Click);
            // 
            // dg_currentborrows
            // 
            this.dg_currentborrows.AllowUserToAddRows = false;
            this.dg_currentborrows.AllowUserToDeleteRows = false;
            this.dg_currentborrows.AllowUserToResizeColumns = false;
            this.dg_currentborrows.AllowUserToResizeRows = false;
            this.dg_currentborrows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_currentborrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_currentborrows.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg_currentborrows.Location = new System.Drawing.Point(229, 381);
            this.dg_currentborrows.Margin = new System.Windows.Forms.Padding(4);
            this.dg_currentborrows.Name = "dg_currentborrows";
            this.dg_currentborrows.RowHeadersVisible = false;
            this.dg_currentborrows.RowTemplate.Height = 24;
            this.dg_currentborrows.Size = new System.Drawing.Size(193, 112);
            this.dg_currentborrows.TabIndex = 31;
            this.dg_currentborrows.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_currentborrows_CellDoubleClick);
            // 
            // label_currentborrows
            // 
            this.label_currentborrows.AutoSize = true;
            this.label_currentborrows.Location = new System.Drawing.Point(226, 360);
            this.label_currentborrows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_currentborrows.Name = "label_currentborrows";
            this.label_currentborrows.Size = new System.Drawing.Size(204, 17);
            this.label_currentborrows.TabIndex = 34;
            this.label_currentborrows.Text = "Currently Borrowed Equipment:";
            // 
            // label_dateformat
            // 
            this.label_dateformat.AutoSize = true;
            this.label_dateformat.Location = new System.Drawing.Point(331, 29);
            this.label_dateformat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dateformat.Name = "label_dateformat";
            this.label_dateformat.Size = new System.Drawing.Size(92, 17);
            this.label_dateformat.TabIndex = 33;
            this.label_dateformat.Text = "(dd/mm/yyyy)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "(dd/mm/yyyy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "(dd/mm/yyyy)";
            // 
            // button_saveClose
            // 
            this.button_saveClose.Location = new System.Drawing.Point(742, 500);
            this.button_saveClose.Margin = new System.Windows.Forms.Padding(4);
            this.button_saveClose.Name = "button_saveClose";
            this.button_saveClose.Size = new System.Drawing.Size(116, 32);
            this.button_saveClose.TabIndex = 30;
            this.button_saveClose.Text = "Save and Close";
            this.button_saveClose.UseVisualStyleBackColor = true;
            this.button_saveClose.Click += new System.EventHandler(this.button_saveClose_Click);
            // 
            // button_saveOpen
            // 
            this.button_saveOpen.Location = new System.Drawing.Point(461, 500);
            this.button_saveOpen.Margin = new System.Windows.Forms.Padding(4);
            this.button_saveOpen.Name = "button_saveOpen";
            this.button_saveOpen.Size = new System.Drawing.Size(149, 32);
            this.button_saveOpen.TabIndex = 28;
            this.button_saveOpen.Text = "Save and Open List";
            this.button_saveOpen.UseVisualStyleBackColor = true;
            this.button_saveOpen.Click += new System.EventHandler(this.button_saveOpen_Click);
            // 
            // frm_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 545);
            this.Controls.Add(this.button_saveOpen);
            this.Controls.Add(this.button_saveClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_dateformat);
            this.Controls.Add(this.label_currentborrows);
            this.Controls.Add(this.dg_currentborrows);
            this.Controls.Add(this.button_equipmentbooking);
            this.Controls.Add(this.txt_contract_finish);
            this.Controls.Add(this.label_contract_finish);
            this.Controls.Add(this.txt_contract_start);
            this.Controls.Add(this.label_contract_start);
            this.Controls.Add(this.label_natinsnumb);
            this.Controls.Add(this.txt_natinsnumb);
            this.Controls.Add(this.label_qualifications);
            this.Controls.Add(this.txt_qualifications);
            this.Controls.Add(this.cmb_position);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.cmb_contract);
            this.Controls.Add(this.txt_pc);
            this.Controls.Add(this.label_contract);
            this.Controls.Add(this.label_pc);
            this.Controls.Add(this.txt_county);
            this.Controls.Add(this.label_county);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_saveStay);
            this.Controls.Add(this.txt_medical_notes);
            this.Controls.Add(this.label_medical_notes);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_emerg_mobile);
            this.Controls.Add(this.label_emerg_mobile);
            this.Controls.Add(this.txt_emerg_telephone);
            this.Controls.Add(this.label_emerg_telephone);
            this.Controls.Add(this.txt_allergies);
            this.Controls.Add(this.label_allergies);
            this.Controls.Add(this.txt_emerg_relation);
            this.Controls.Add(this.label_emerg_relation);
            this.Controls.Add(this.txt_doctor_phone);
            this.Controls.Add(this.label_doctor_phone);
            this.Controls.Add(this.txt_doctor_name);
            this.Controls.Add(this.label_doctor_name);
            this.Controls.Add(this.txt_emerg_name);
            this.Controls.Add(this.label_emerg_name);
            this.Controls.Add(this.label_emergencycontact);
            this.Controls.Add(this.txt_address2);
            this.Controls.Add(this.label_address2);
            this.Controls.Add(this.txt_address1);
            this.Controls.Add(this.label_address1);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.label_telephone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.label_mobile);
            this.Controls.Add(this.label_dob);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.label_staffinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Staff Form";
            this.Load += new System.EventHandler(this.frm_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_currentborrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.ComboBox cmb_contract;
        private System.Windows.Forms.MaskedTextBox txt_pc;
        private System.Windows.Forms.Label label_contract;
        private System.Windows.Forms.Label label_pc;
        private System.Windows.Forms.TextBox txt_county;
        private System.Windows.Forms.Label label_county;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_saveStay;
        private System.Windows.Forms.TextBox txt_medical_notes;
        private System.Windows.Forms.Label label_medical_notes;
        private System.Windows.Forms.MaskedTextBox txt_dob;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_emerg_mobile;
        private System.Windows.Forms.Label label_emerg_mobile;
        private System.Windows.Forms.TextBox txt_emerg_telephone;
        private System.Windows.Forms.Label label_emerg_telephone;
        private System.Windows.Forms.TextBox txt_allergies;
        private System.Windows.Forms.Label label_allergies;
        private System.Windows.Forms.TextBox txt_emerg_relation;
        private System.Windows.Forms.Label label_emerg_relation;
        private System.Windows.Forms.TextBox txt_doctor_phone;
        private System.Windows.Forms.Label label_doctor_phone;
        private System.Windows.Forms.TextBox txt_doctor_name;
        private System.Windows.Forms.Label label_doctor_name;
        private System.Windows.Forms.TextBox txt_emerg_name;
        private System.Windows.Forms.Label label_emerg_name;
        private System.Windows.Forms.Label label_emergencycontact;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.Label label_address2;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.Label label_address1;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label_staffinfo;
        private System.Windows.Forms.TextBox txt_qualifications;
        private System.Windows.Forms.Label label_qualifications;
        private System.Windows.Forms.Label label_mobile;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_natinsnumb;
        private System.Windows.Forms.Label label_natinsnumb;
        private System.Windows.Forms.MaskedTextBox txt_contract_start;
        private System.Windows.Forms.Label label_contract_start;
        private System.Windows.Forms.MaskedTextBox txt_contract_finish;
        private System.Windows.Forms.Label label_contract_finish;
        private System.Windows.Forms.Button button_equipmentbooking;
        private System.Windows.Forms.DataGridView dg_currentborrows;
        private System.Windows.Forms.Label label_currentborrows;
        private System.Windows.Forms.Label label_dateformat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_saveClose;
        private System.Windows.Forms.Button button_saveOpen;
    }
}