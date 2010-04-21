namespace Gym_administration
{
    partial class frm_member
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_member));
            this.label_memberinfo = new System.Windows.Forms.Label();
            this.label_membernum = new System.Windows.Forms.Label();
            this.txt_membernum = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_dob = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label_mobile = new System.Windows.Forms.Label();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.label_telephone = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.label_address2 = new System.Windows.Forms.Label();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.label_address1 = new System.Windows.Forms.Label();
            this.label_emergencycontact = new System.Windows.Forms.Label();
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
            this.txt_emerg_mobile = new System.Windows.Forms.TextBox();
            this.label_emerg_mobile = new System.Windows.Forms.Label();
            this.label_medical_info = new System.Windows.Forms.Label();
            this.txt_dob = new System.Windows.Forms.MaskedTextBox();
            this.txt_medical_notes = new System.Windows.Forms.TextBox();
            this.label_medical_notes = new System.Windows.Forms.Label();
            this.button_saveStay = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.txt_county = new System.Windows.Forms.TextBox();
            this.label_county = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.txt_pc = new System.Windows.Forms.MaskedTextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_pc = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.chk_active = new System.Windows.Forms.CheckBox();
            this.button_payments = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_equipmentbooking = new System.Windows.Forms.Button();
            this.dg_eqbookings = new System.Windows.Forms.DataGridView();
            this.label_eqbookings = new System.Windows.Forms.Label();
            this.label_dateformat = new System.Windows.Forms.Label();
            this.label_emailunique = new System.Windows.Forms.Label();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.label_sid = new System.Windows.Forms.Label();
            this.txt_stcardnumber = new System.Windows.Forms.TextBox();
            this.label_stcardnumber = new System.Windows.Forms.Label();
            this.button_saveClose = new System.Windows.Forms.Button();
            this.button_saveOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rd_male = new System.Windows.Forms.RadioButton();
            this.rd_female = new System.Windows.Forms.RadioButton();
            this.button_RestoreMedicalText = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_eqbookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_memberinfo
            // 
            this.label_memberinfo.AutoSize = true;
            this.label_memberinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_memberinfo.Location = new System.Drawing.Point(10, 6);
            this.label_memberinfo.Name = "label_memberinfo";
            this.label_memberinfo.Size = new System.Drawing.Size(104, 16);
            this.label_memberinfo.TabIndex = 0;
            this.label_memberinfo.Text = "MEMBER INFO:";
            // 
            // label_membernum
            // 
            this.label_membernum.AutoSize = true;
            this.label_membernum.Location = new System.Drawing.Point(10, 28);
            this.label_membernum.Name = "label_membernum";
            this.label_membernum.Size = new System.Drawing.Size(85, 13);
            this.label_membernum.TabIndex = 1;
            this.label_membernum.Text = "Member Number";
            // 
            // txt_membernum
            // 
            this.txt_membernum.Location = new System.Drawing.Point(12, 46);
            this.txt_membernum.Name = "txt_membernum";
            this.txt_membernum.ReadOnly = true;
            this.txt_membernum.Size = new System.Drawing.Size(138, 20);
            this.txt_membernum.TabIndex = 1;
            this.txt_membernum.TabStop = false;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(12, 126);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(138, 20);
            this.txt_firstName.TabIndex = 3;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(10, 109);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(57, 13);
            this.label_firstName.TabIndex = 3;
            this.label_firstName.Text = "First Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(176, 126);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(138, 20);
            this.txt_lastName.TabIndex = 4;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(173, 109);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(58, 13);
            this.label_lastName.TabIndex = 5;
            this.label_lastName.Text = "Last Name";
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dob.Location = new System.Drawing.Point(10, 71);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(79, 13);
            this.label_dob.TabIndex = 7;
            this.label_dob.Text = "Date of Birth";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(176, 317);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(138, 20);
            this.txt_mobile.TabIndex = 12;
            // 
            // label_mobile
            // 
            this.label_mobile.AutoSize = true;
            this.label_mobile.Location = new System.Drawing.Point(173, 300);
            this.label_mobile.Name = "label_mobile";
            this.label_mobile.Size = new System.Drawing.Size(92, 13);
            this.label_mobile.TabIndex = 9;
            this.label_mobile.Text = "Mobile Telephone";
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(176, 279);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(138, 20);
            this.txt_telephone.TabIndex = 10;
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(173, 262);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(89, 13);
            this.label_telephone.TabIndex = 13;
            this.label_telephone.Text = "Home Telephone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(12, 366);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(302, 20);
            this.txt_email.TabIndex = 15;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(10, 349);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(42, 13);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "E-Mail";
            // 
            // txt_address2
            // 
            this.txt_address2.Location = new System.Drawing.Point(12, 202);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(302, 20);
            this.txt_address2.TabIndex = 6;
            // 
            // label_address2
            // 
            this.label_address2.AutoSize = true;
            this.label_address2.Location = new System.Drawing.Point(10, 185);
            this.label_address2.Name = "label_address2";
            this.label_address2.Size = new System.Drawing.Size(98, 13);
            this.label_address2.TabIndex = 17;
            this.label_address2.Text = "Address UK, Line 2";
            // 
            // txt_address1
            // 
            this.txt_address1.Location = new System.Drawing.Point(12, 164);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(302, 20);
            this.txt_address1.TabIndex = 5;
            // 
            // label_address1
            // 
            this.label_address1.AutoSize = true;
            this.label_address1.Location = new System.Drawing.Point(10, 147);
            this.label_address1.Name = "label_address1";
            this.label_address1.Size = new System.Drawing.Size(98, 13);
            this.label_address1.TabIndex = 15;
            this.label_address1.Text = "Address UK, Line 1";
            // 
            // label_emergencycontact
            // 
            this.label_emergencycontact.AutoSize = true;
            this.label_emergencycontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emergencycontact.Location = new System.Drawing.Point(349, 294);
            this.label_emergencycontact.Name = "label_emergencycontact";
            this.label_emergencycontact.Size = new System.Drawing.Size(157, 16);
            this.label_emergencycontact.TabIndex = 19;
            this.label_emergencycontact.Text = "Emergency Contact (UK):";
            // 
            // txt_emerg_telephone
            // 
            this.txt_emerg_telephone.Location = new System.Drawing.Point(352, 364);
            this.txt_emerg_telephone.Name = "txt_emerg_telephone";
            this.txt_emerg_telephone.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_telephone.TabIndex = 22;
            // 
            // label_emerg_telephone
            // 
            this.label_emerg_telephone.AutoSize = true;
            this.label_emerg_telephone.Location = new System.Drawing.Point(349, 347);
            this.label_emerg_telephone.Name = "label_emerg_telephone";
            this.label_emerg_telephone.Size = new System.Drawing.Size(58, 13);
            this.label_emerg_telephone.TabIndex = 32;
            this.label_emerg_telephone.Text = "Telephone";
            // 
            // txt_allergies
            // 
            this.txt_allergies.Location = new System.Drawing.Point(495, 162);
            this.txt_allergies.Name = "txt_allergies";
            this.txt_allergies.Size = new System.Drawing.Size(138, 20);
            this.txt_allergies.TabIndex = 18;
            this.txt_allergies.Text = "none";
            // 
            // label_allergies
            // 
            this.label_allergies.AutoSize = true;
            this.label_allergies.Location = new System.Drawing.Point(493, 145);
            this.label_allergies.Name = "label_allergies";
            this.label_allergies.Size = new System.Drawing.Size(46, 13);
            this.label_allergies.TabIndex = 30;
            this.label_allergies.Text = "Allergies";
            // 
            // txt_emerg_relation
            // 
            this.txt_emerg_relation.Location = new System.Drawing.Point(511, 325);
            this.txt_emerg_relation.Name = "txt_emerg_relation";
            this.txt_emerg_relation.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_relation.TabIndex = 21;
            // 
            // label_emerg_relation
            // 
            this.label_emerg_relation.AutoSize = true;
            this.label_emerg_relation.Location = new System.Drawing.Point(508, 312);
            this.label_emerg_relation.Name = "label_emerg_relation";
            this.label_emerg_relation.Size = new System.Drawing.Size(46, 13);
            this.label_emerg_relation.TabIndex = 28;
            this.label_emerg_relation.Text = "Relation";
            // 
            // txt_doctor_phone
            // 
            this.txt_doctor_phone.Location = new System.Drawing.Point(423, 162);
            this.txt_doctor_phone.Name = "txt_doctor_phone";
            this.txt_doctor_phone.Size = new System.Drawing.Size(67, 20);
            this.txt_doctor_phone.TabIndex = 17;
            // 
            // label_doctor_phone
            // 
            this.label_doctor_phone.AutoSize = true;
            this.label_doctor_phone.Location = new System.Drawing.Point(421, 145);
            this.label_doctor_phone.Name = "label_doctor_phone";
            this.label_doctor_phone.Size = new System.Drawing.Size(58, 13);
            this.label_doctor_phone.TabIndex = 26;
            this.label_doctor_phone.Text = "Telephone";
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Location = new System.Drawing.Point(352, 162);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(66, 20);
            this.txt_doctor_name.TabIndex = 16;
            // 
            // label_doctor_name
            // 
            this.label_doctor_name.AutoSize = true;
            this.label_doctor_name.Location = new System.Drawing.Point(349, 145);
            this.label_doctor_name.Name = "label_doctor_name";
            this.label_doctor_name.Size = new System.Drawing.Size(70, 13);
            this.label_doctor_name.TabIndex = 24;
            this.label_doctor_name.Text = "Doctor Name";
            // 
            // txt_emerg_name
            // 
            this.txt_emerg_name.Location = new System.Drawing.Point(352, 325);
            this.txt_emerg_name.Name = "txt_emerg_name";
            this.txt_emerg_name.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_name.TabIndex = 20;
            // 
            // label_emerg_name
            // 
            this.label_emerg_name.AutoSize = true;
            this.label_emerg_name.Location = new System.Drawing.Point(349, 308);
            this.label_emerg_name.Name = "label_emerg_name";
            this.label_emerg_name.Size = new System.Drawing.Size(35, 13);
            this.label_emerg_name.TabIndex = 20;
            this.label_emerg_name.Text = "Name";
            // 
            // txt_emerg_mobile
            // 
            this.txt_emerg_mobile.Location = new System.Drawing.Point(511, 364);
            this.txt_emerg_mobile.Name = "txt_emerg_mobile";
            this.txt_emerg_mobile.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_mobile.TabIndex = 23;
            // 
            // label_emerg_mobile
            // 
            this.label_emerg_mobile.AutoSize = true;
            this.label_emerg_mobile.Location = new System.Drawing.Point(508, 348);
            this.label_emerg_mobile.Name = "label_emerg_mobile";
            this.label_emerg_mobile.Size = new System.Drawing.Size(38, 13);
            this.label_emerg_mobile.TabIndex = 34;
            this.label_emerg_mobile.Text = "Mobile";
            // 
            // label_medical_info
            // 
            this.label_medical_info.AutoSize = true;
            this.label_medical_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_medical_info.Location = new System.Drawing.Point(349, 126);
            this.label_medical_info.Name = "label_medical_info";
            this.label_medical_info.Size = new System.Drawing.Size(127, 16);
            this.label_medical_info.TabIndex = 36;
            this.label_medical_info.Text = "Medical Information:";
            // 
            // txt_dob
            // 
            this.txt_dob.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_dob.Location = new System.Drawing.Point(12, 88);
            this.txt_dob.Mask = "00/00/0000";
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(100, 20);
            this.txt_dob.TabIndex = 2;
            this.txt_dob.ValidatingType = typeof(System.DateTime);
            // 
            // txt_medical_notes
            // 
            this.txt_medical_notes.Location = new System.Drawing.Point(352, 200);
            this.txt_medical_notes.Multiline = true;
            this.txt_medical_notes.Name = "txt_medical_notes";
            this.txt_medical_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_medical_notes.Size = new System.Drawing.Size(297, 95);
            this.txt_medical_notes.TabIndex = 19;
            this.txt_medical_notes.Text = resources.GetString("txt_medical_notes.Text");
            // 
            // label_medical_notes
            // 
            this.label_medical_notes.AutoSize = true;
            this.label_medical_notes.Location = new System.Drawing.Point(349, 183);
            this.label_medical_notes.Name = "label_medical_notes";
            this.label_medical_notes.Size = new System.Drawing.Size(75, 13);
            this.label_medical_notes.TabIndex = 38;
            this.label_medical_notes.Text = "Medical Notes";
            // 
            // button_saveStay
            // 
            this.button_saveStay.Location = new System.Drawing.Point(465, 401);
            this.button_saveStay.Name = "button_saveStay";
            this.button_saveStay.Size = new System.Drawing.Size(86, 26);
            this.button_saveStay.TabIndex = 29;
            this.button_saveStay.Text = "Save and Stay";
            this.button_saveStay.UseVisualStyleBackColor = true;
            this.button_saveStay.Click += new System.EventHandler(this.button_saveStay_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 401);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(73, 26);
            this.button_cancel.TabIndex = 24;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // txt_county
            // 
            this.txt_county.Location = new System.Drawing.Point(176, 240);
            this.txt_county.Name = "txt_county";
            this.txt_county.Size = new System.Drawing.Size(138, 20);
            this.txt_county.TabIndex = 8;
            // 
            // label_county
            // 
            this.label_county.AutoSize = true;
            this.label_county.Location = new System.Drawing.Point(173, 223);
            this.label_county.Name = "label_county";
            this.label_county.Size = new System.Drawing.Size(40, 13);
            this.label_county.TabIndex = 44;
            this.label_county.Text = "County";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(12, 240);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(138, 20);
            this.txt_city.TabIndex = 7;
            this.txt_city.TextChanged += new System.EventHandler(this.txt_city_TextChanged);
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(10, 223);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(24, 13);
            this.label_city.TabIndex = 42;
            this.label_city.Text = "City";
            // 
            // txt_pc
            // 
            this.txt_pc.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_pc.Location = new System.Drawing.Point(12, 279);
            this.txt_pc.Mask = ">LCCC 9LL";
            this.txt_pc.Name = "txt_pc";
            this.txt_pc.Size = new System.Drawing.Size(100, 20);
            this.txt_pc.TabIndex = 9;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(10, 300);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(37, 13);
            this.label_type.TabIndex = 47;
            this.label_type.Text = "Status";
            // 
            // label_pc
            // 
            this.label_pc.AutoSize = true;
            this.label_pc.Location = new System.Drawing.Point(10, 262);
            this.label_pc.Name = "label_pc";
            this.label_pc.Size = new System.Drawing.Size(56, 13);
            this.label_pc.TabIndex = 46;
            this.label_pc.Text = "Post Code";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Student Full Time",
            "Student Part Time",
            "Anglia Ruskin Staff",
            "Former Graduate (Alumni)",
            "Community Monthly",
            "Community PAYG",
            "Sport Team (ARU Society)",
            "Other ARU Society",
            "Sport Federation",
            "Summer School",
            "External Company",
            "Other Individual",
            "Other Group",
            "Other"});
            this.cmb_type.Location = new System.Drawing.Point(12, 317);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(138, 21);
            this.cmb_type.TabIndex = 11;
            // 
            // chk_active
            // 
            this.chk_active.AutoSize = true;
            this.chk_active.Checked = true;
            this.chk_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_active.Location = new System.Drawing.Point(176, 8);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(62, 17);
            this.chk_active.TabIndex = 14;
            this.chk_active.TabStop = false;
            this.chk_active.Text = "Active?";
            this.chk_active.UseVisualStyleBackColor = true;
            // 
            // button_payments
            // 
            this.button_payments.Location = new System.Drawing.Point(278, 401);
            this.button_payments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_payments.Name = "button_payments";
            this.button_payments.Size = new System.Drawing.Size(70, 26);
            this.button_payments.TabIndex = 27;
            this.button_payments.Text = "Payments";
            this.button_payments.UseVisualStyleBackColor = true;
            this.button_payments.Click += new System.EventHandler(this.button_payments_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(90, 401);
            this.button_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(67, 26);
            this.button_remove.TabIndex = 25;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_equipmentbooking
            // 
            this.button_equipmentbooking.Location = new System.Drawing.Point(161, 401);
            this.button_equipmentbooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_equipmentbooking.Name = "button_equipmentbooking";
            this.button_equipmentbooking.Size = new System.Drawing.Size(112, 26);
            this.button_equipmentbooking.TabIndex = 26;
            this.button_equipmentbooking.Text = "Equipment Booking";
            this.button_equipmentbooking.UseVisualStyleBackColor = true;
            this.button_equipmentbooking.Click += new System.EventHandler(this.button_equipmentbooking_Click);
            // 
            // dg_eqbookings
            // 
            this.dg_eqbookings.AllowUserToAddRows = false;
            this.dg_eqbookings.AllowUserToDeleteRows = false;
            this.dg_eqbookings.AllowUserToResizeColumns = false;
            this.dg_eqbookings.AllowUserToResizeRows = false;
            this.dg_eqbookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_eqbookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_eqbookings.Cursor = System.Windows.Forms.Cursors.Default;
            this.dg_eqbookings.Location = new System.Drawing.Point(505, 26);
            this.dg_eqbookings.Name = "dg_eqbookings";
            this.dg_eqbookings.RowHeadersVisible = false;
            this.dg_eqbookings.RowTemplate.Height = 24;
            this.dg_eqbookings.Size = new System.Drawing.Size(145, 96);
            this.dg_eqbookings.TabIndex = 58;
            this.dg_eqbookings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_eqbookings_CellDoubleClick);
            // 
            // label_eqbookings
            // 
            this.label_eqbookings.AutoSize = true;
            this.label_eqbookings.Location = new System.Drawing.Point(503, 7);
            this.label_eqbookings.Name = "label_eqbookings";
            this.label_eqbookings.Size = new System.Drawing.Size(152, 13);
            this.label_eqbookings.TabIndex = 59;
            this.label_eqbookings.Text = "Currently Borrowed Equipment:";
            // 
            // label_dateformat
            // 
            this.label_dateformat.AutoSize = true;
            this.label_dateformat.Location = new System.Drawing.Point(91, 71);
            this.label_dateformat.Name = "label_dateformat";
            this.label_dateformat.Size = new System.Drawing.Size(71, 13);
            this.label_dateformat.TabIndex = 60;
            this.label_dateformat.Text = "(dd/mm/yyyy)";
            // 
            // label_emailunique
            // 
            this.label_emailunique.AutoSize = true;
            this.label_emailunique.Location = new System.Drawing.Point(56, 349);
            this.label_emailunique.Name = "label_emailunique";
            this.label_emailunique.Size = new System.Drawing.Size(92, 13);
            this.label_emailunique.TabIndex = 61;
            this.label_emailunique.Text = "(has to be unique)";
            // 
            // txt_sid
            // 
            this.txt_sid.Location = new System.Drawing.Point(176, 46);
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.Size = new System.Drawing.Size(138, 20);
            this.txt_sid.TabIndex = 0;
            // 
            // label_sid
            // 
            this.label_sid.AutoSize = true;
            this.label_sid.Location = new System.Drawing.Point(173, 28);
            this.label_sid.Name = "label_sid";
            this.label_sid.Size = new System.Drawing.Size(125, 13);
            this.label_sid.TabIndex = 63;
            this.label_sid.Text = "Student ID Number (SID)";
            // 
            // txt_stcardnumber
            // 
            this.txt_stcardnumber.AcceptsReturn = true;
            this.txt_stcardnumber.Location = new System.Drawing.Point(176, 88);
            this.txt_stcardnumber.Name = "txt_stcardnumber";
            this.txt_stcardnumber.Size = new System.Drawing.Size(138, 20);
            this.txt_stcardnumber.TabIndex = 1;
            // 
            // label_stcardnumber
            // 
            this.label_stcardnumber.AutoSize = true;
            this.label_stcardnumber.Location = new System.Drawing.Point(173, 71);
            this.label_stcardnumber.Name = "label_stcardnumber";
            this.label_stcardnumber.Size = new System.Drawing.Size(109, 13);
            this.label_stcardnumber.TabIndex = 65;
            this.label_stcardnumber.Text = "Student Card Number";
            // 
            // button_saveClose
            // 
            this.button_saveClose.Location = new System.Drawing.Point(557, 401);
            this.button_saveClose.Name = "button_saveClose";
            this.button_saveClose.Size = new System.Drawing.Size(94, 26);
            this.button_saveClose.TabIndex = 30;
            this.button_saveClose.Text = "Save and Close";
            this.button_saveClose.UseVisualStyleBackColor = true;
            this.button_saveClose.Click += new System.EventHandler(this.button_saveClose_Click);
            // 
            // button_saveOpen
            // 
            this.button_saveOpen.Location = new System.Drawing.Point(353, 401);
            this.button_saveOpen.Name = "button_saveOpen";
            this.button_saveOpen.Size = new System.Drawing.Size(106, 26);
            this.button_saveOpen.TabIndex = 28;
            this.button_saveOpen.Text = "Save and Open List";
            this.button_saveOpen.UseVisualStyleBackColor = true;
            this.button_saveOpen.Click += new System.EventHandler(this.button_saveOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(352, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Double click: Load new picture \r\nRight click: Delete picture");
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // rd_male
            // 
            this.rd_male.AutoSize = true;
            this.rd_male.Location = new System.Drawing.Point(238, 340);
            this.rd_male.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_male.Name = "rd_male";
            this.rd_male.Size = new System.Drawing.Size(48, 17);
            this.rd_male.TabIndex = 14;
            this.rd_male.Text = "Male";
            this.rd_male.UseVisualStyleBackColor = true;
            this.rd_male.Click += new System.EventHandler(this.rd_male_Checked);
            // 
            // rd_female
            // 
            this.rd_female.AutoSize = true;
            this.rd_female.Location = new System.Drawing.Point(176, 340);
            this.rd_female.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_female.Name = "rd_female";
            this.rd_female.Size = new System.Drawing.Size(59, 17);
            this.rd_female.TabIndex = 13;
            this.rd_female.TabStop = true;
            this.rd_female.Text = "Female";
            this.rd_female.UseVisualStyleBackColor = true;
            this.rd_female.Click += new System.EventHandler(this.rd_female_Checked);
            // 
            // button_RestoreMedicalText
            // 
            this.button_RestoreMedicalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.8F);
            this.button_RestoreMedicalText.Location = new System.Drawing.Point(423, 183);
            this.button_RestoreMedicalText.Name = "button_RestoreMedicalText";
            this.button_RestoreMedicalText.Size = new System.Drawing.Size(87, 14);
            this.button_RestoreMedicalText.TabIndex = 71;
            this.button_RestoreMedicalText.TabStop = false;
            this.button_RestoreMedicalText.Text = "RESTORE DEFAULT TEXT";
            this.button_RestoreMedicalText.UseVisualStyleBackColor = true;
            this.button_RestoreMedicalText.Click += new System.EventHandler(this.button_RestoreMedicalText_Click);
            // 
            // frm_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 443);
            this.Controls.Add(this.button_RestoreMedicalText);
            this.Controls.Add(this.rd_female);
            this.Controls.Add(this.rd_male);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_saveOpen);
            this.Controls.Add(this.button_saveClose);
            this.Controls.Add(this.txt_stcardnumber);
            this.Controls.Add(this.label_stcardnumber);
            this.Controls.Add(this.txt_sid);
            this.Controls.Add(this.label_sid);
            this.Controls.Add(this.label_emailunique);
            this.Controls.Add(this.label_dateformat);
            this.Controls.Add(this.label_eqbookings);
            this.Controls.Add(this.dg_eqbookings);
            this.Controls.Add(this.button_equipmentbooking);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_payments);
            this.Controls.Add(this.chk_active);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.txt_pc);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_pc);
            this.Controls.Add(this.txt_county);
            this.Controls.Add(this.label_county);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_saveStay);
            this.Controls.Add(this.label_medical_notes);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.label_medical_info);
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
            this.Controls.Add(this.txt_membernum);
            this.Controls.Add(this.label_membernum);
            this.Controls.Add(this.label_memberinfo);
            this.Controls.Add(this.txt_medical_notes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frm_member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Form";
            ((System.ComponentModel.ISupportInitialize)(this.dg_eqbookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_memberinfo;
        private System.Windows.Forms.Label label_membernum;
        private System.Windows.Forms.TextBox txt_membernum;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label_mobile;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.Label label_address2;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.Label label_address1;
        private System.Windows.Forms.Label label_emergencycontact;
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
        private System.Windows.Forms.TextBox txt_emerg_mobile;
        private System.Windows.Forms.Label label_emerg_mobile;
        private System.Windows.Forms.Label label_medical_info;
        private System.Windows.Forms.MaskedTextBox txt_dob;
        private System.Windows.Forms.TextBox txt_medical_notes;
        private System.Windows.Forms.Label label_medical_notes;
        private System.Windows.Forms.Button button_saveStay;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox txt_county;
        private System.Windows.Forms.Label label_county;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.MaskedTextBox txt_pc;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_pc;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.CheckBox chk_active;
        private System.Windows.Forms.Button button_payments;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_equipmentbooking;
        private System.Windows.Forms.DataGridView dg_eqbookings;
        private System.Windows.Forms.Label label_eqbookings;
        private System.Windows.Forms.Label label_dateformat;
        private System.Windows.Forms.Label label_emailunique;
        private System.Windows.Forms.TextBox txt_sid;
        private System.Windows.Forms.Label label_sid;
        private System.Windows.Forms.TextBox txt_stcardnumber;
        private System.Windows.Forms.Label label_stcardnumber;
        private System.Windows.Forms.Button button_saveClose;
        private System.Windows.Forms.Button button_saveOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rd_male;
        private System.Windows.Forms.RadioButton rd_female;
        private System.Windows.Forms.Button button_RestoreMedicalText;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}