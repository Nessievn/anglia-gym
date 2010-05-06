namespace Gym_administration
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
            this.dg_eqbookings = new System.Windows.Forms.DataGridView();
            this.label_eqbookings = new System.Windows.Forms.Label();
            this.label_dateformat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_saveClose = new System.Windows.Forms.Button();
            this.button_saveOpen = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.chk_active = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_eqbookings)).BeginInit();
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
            this.cmb_position.Location = new System.Drawing.Point(172, 270);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(121, 21);
            this.cmb_position.TabIndex = 16;
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(170, 254);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(44, 13);
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
            this.cmb_contract.Location = new System.Drawing.Point(172, 232);
            this.cmb_contract.Name = "cmb_contract";
            this.cmb_contract.Size = new System.Drawing.Size(121, 21);
            this.cmb_contract.TabIndex = 15;
            // 
            // txt_pc
            // 
            this.txt_pc.Location = new System.Drawing.Point(10, 232);
            this.txt_pc.Mask = ">LCCC 9LL";
            this.txt_pc.Name = "txt_pc";
            this.txt_pc.Size = new System.Drawing.Size(100, 20);
            this.txt_pc.TabIndex = 8;
            // 
            // label_contract
            // 
            this.label_contract.AutoSize = true;
            this.label_contract.Location = new System.Drawing.Point(170, 214);
            this.label_contract.Name = "label_contract";
            this.label_contract.Size = new System.Drawing.Size(91, 13);
            this.label_contract.TabIndex = 119;
            this.label_contract.Text = "Employment Type";
            // 
            // label_pc
            // 
            this.label_pc.AutoSize = true;
            this.label_pc.Location = new System.Drawing.Point(8, 214);
            this.label_pc.Name = "label_pc";
            this.label_pc.Size = new System.Drawing.Size(56, 13);
            this.label_pc.TabIndex = 120;
            this.label_pc.Text = "Post Code";
            // 
            // txt_county
            // 
            this.txt_county.Location = new System.Drawing.Point(172, 193);
            this.txt_county.Name = "txt_county";
            this.txt_county.Size = new System.Drawing.Size(138, 20);
            this.txt_county.TabIndex = 7;
            // 
            // label_county
            // 
            this.label_county.AutoSize = true;
            this.label_county.Location = new System.Drawing.Point(170, 176);
            this.label_county.Name = "label_county";
            this.label_county.Size = new System.Drawing.Size(40, 13);
            this.label_county.TabIndex = 101;
            this.label_county.Text = "County";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(10, 193);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(138, 20);
            this.txt_city.TabIndex = 6;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(8, 176);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(24, 13);
            this.label_city.TabIndex = 121;
            this.label_city.Text = "City";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(10, 406);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 26);
            this.button_cancel.TabIndex = 26;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_saveStay
            // 
            this.button_saveStay.Location = new System.Drawing.Point(464, 406);
            this.button_saveStay.Name = "button_saveStay";
            this.button_saveStay.Size = new System.Drawing.Size(87, 26);
            this.button_saveStay.TabIndex = 29;
            this.button_saveStay.Text = "Save and Stay";
            this.button_saveStay.UseVisualStyleBackColor = true;
            this.button_saveStay.Click += new System.EventHandler(this.button_saveStay_Click);
            // 
            // txt_medical_notes
            // 
            this.txt_medical_notes.Location = new System.Drawing.Point(346, 232);
            this.txt_medical_notes.Multiline = true;
            this.txt_medical_notes.Name = "txt_medical_notes";
            this.txt_medical_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_medical_notes.Size = new System.Drawing.Size(299, 60);
            this.txt_medical_notes.TabIndex = 24;
            // 
            // label_medical_notes
            // 
            this.label_medical_notes.AutoSize = true;
            this.label_medical_notes.Location = new System.Drawing.Point(344, 214);
            this.label_medical_notes.Name = "label_medical_notes";
            this.label_medical_notes.Size = new System.Drawing.Size(75, 13);
            this.label_medical_notes.TabIndex = 122;
            this.label_medical_notes.Text = "Medical Notes";
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(172, 41);
            this.txt_dob.Mask = "00/00/0000";
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(100, 20);
            this.txt_dob.TabIndex = 12;
            this.txt_dob.ValidatingType = typeof(System.DateTime);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(343, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 16);
            this.label19.TabIndex = 123;
            this.label19.Text = "Medical Information:";
            // 
            // txt_emerg_mobile
            // 
            this.txt_emerg_mobile.Location = new System.Drawing.Point(506, 79);
            this.txt_emerg_mobile.Name = "txt_emerg_mobile";
            this.txt_emerg_mobile.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_mobile.TabIndex = 20;
            // 
            // label_emerg_mobile
            // 
            this.label_emerg_mobile.AutoSize = true;
            this.label_emerg_mobile.Location = new System.Drawing.Point(504, 62);
            this.label_emerg_mobile.Name = "label_emerg_mobile";
            this.label_emerg_mobile.Size = new System.Drawing.Size(38, 13);
            this.label_emerg_mobile.TabIndex = 124;
            this.label_emerg_mobile.Text = "Mobile";
            // 
            // txt_emerg_telephone
            // 
            this.txt_emerg_telephone.Location = new System.Drawing.Point(346, 79);
            this.txt_emerg_telephone.Name = "txt_emerg_telephone";
            this.txt_emerg_telephone.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_telephone.TabIndex = 19;
            // 
            // label_emerg_telephone
            // 
            this.label_emerg_telephone.AutoSize = true;
            this.label_emerg_telephone.Location = new System.Drawing.Point(344, 62);
            this.label_emerg_telephone.Name = "label_emerg_telephone";
            this.label_emerg_telephone.Size = new System.Drawing.Size(58, 13);
            this.label_emerg_telephone.TabIndex = 125;
            this.label_emerg_telephone.Text = "Telephone";
            // 
            // txt_allergies
            // 
            this.txt_allergies.Location = new System.Drawing.Point(346, 193);
            this.txt_allergies.Name = "txt_allergies";
            this.txt_allergies.Size = new System.Drawing.Size(138, 20);
            this.txt_allergies.TabIndex = 23;
            // 
            // label_allergies
            // 
            this.label_allergies.AutoSize = true;
            this.label_allergies.Location = new System.Drawing.Point(344, 176);
            this.label_allergies.Name = "label_allergies";
            this.label_allergies.Size = new System.Drawing.Size(46, 13);
            this.label_allergies.TabIndex = 126;
            this.label_allergies.Text = "Allergies";
            // 
            // txt_emerg_relation
            // 
            this.txt_emerg_relation.Location = new System.Drawing.Point(506, 41);
            this.txt_emerg_relation.Name = "txt_emerg_relation";
            this.txt_emerg_relation.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_relation.TabIndex = 18;
            // 
            // label_emerg_relation
            // 
            this.label_emerg_relation.AutoSize = true;
            this.label_emerg_relation.Location = new System.Drawing.Point(504, 24);
            this.label_emerg_relation.Name = "label_emerg_relation";
            this.label_emerg_relation.Size = new System.Drawing.Size(46, 13);
            this.label_emerg_relation.TabIndex = 127;
            this.label_emerg_relation.Text = "Relation";
            // 
            // txt_doctor_phone
            // 
            this.txt_doctor_phone.Location = new System.Drawing.Point(506, 155);
            this.txt_doctor_phone.Name = "txt_doctor_phone";
            this.txt_doctor_phone.Size = new System.Drawing.Size(138, 20);
            this.txt_doctor_phone.TabIndex = 22;
            // 
            // label_doctor_phone
            // 
            this.label_doctor_phone.AutoSize = true;
            this.label_doctor_phone.Location = new System.Drawing.Point(504, 138);
            this.label_doctor_phone.Name = "label_doctor_phone";
            this.label_doctor_phone.Size = new System.Drawing.Size(58, 13);
            this.label_doctor_phone.TabIndex = 128;
            this.label_doctor_phone.Text = "Telephone";
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Location = new System.Drawing.Point(346, 155);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(138, 20);
            this.txt_doctor_name.TabIndex = 21;
            // 
            // label_doctor_name
            // 
            this.label_doctor_name.AutoSize = true;
            this.label_doctor_name.Location = new System.Drawing.Point(344, 138);
            this.label_doctor_name.Name = "label_doctor_name";
            this.label_doctor_name.Size = new System.Drawing.Size(70, 13);
            this.label_doctor_name.TabIndex = 129;
            this.label_doctor_name.Text = "Doctor Name";
            // 
            // txt_emerg_name
            // 
            this.txt_emerg_name.Location = new System.Drawing.Point(346, 41);
            this.txt_emerg_name.Name = "txt_emerg_name";
            this.txt_emerg_name.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_name.TabIndex = 17;
            // 
            // label_emerg_name
            // 
            this.label_emerg_name.AutoSize = true;
            this.label_emerg_name.Location = new System.Drawing.Point(344, 24);
            this.label_emerg_name.Name = "label_emerg_name";
            this.label_emerg_name.Size = new System.Drawing.Size(35, 13);
            this.label_emerg_name.TabIndex = 130;
            this.label_emerg_name.Text = "Name";
            // 
            // label_emergencycontact
            // 
            this.label_emergencycontact.AutoSize = true;
            this.label_emergencycontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emergencycontact.Location = new System.Drawing.Point(343, 7);
            this.label_emergencycontact.Name = "label_emergencycontact";
            this.label_emergencycontact.Size = new System.Drawing.Size(128, 16);
            this.label_emergencycontact.TabIndex = 83;
            this.label_emergencycontact.Text = "Emergency Contact:";
            // 
            // txt_address2
            // 
            this.txt_address2.Location = new System.Drawing.Point(172, 155);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(138, 20);
            this.txt_address2.TabIndex = 5;
            // 
            // label_address2
            // 
            this.label_address2.AutoSize = true;
            this.label_address2.Location = new System.Drawing.Point(170, 138);
            this.label_address2.Name = "label_address2";
            this.label_address2.Size = new System.Drawing.Size(54, 13);
            this.label_address2.TabIndex = 131;
            this.label_address2.Text = "Address 2";
            // 
            // txt_address1
            // 
            this.txt_address1.Location = new System.Drawing.Point(10, 155);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(138, 20);
            this.txt_address1.TabIndex = 4;
            // 
            // label_address1
            // 
            this.label_address1.AutoSize = true;
            this.label_address1.Location = new System.Drawing.Point(8, 138);
            this.label_address1.Name = "label_address1";
            this.label_address1.Size = new System.Drawing.Size(54, 13);
            this.label_address1.TabIndex = 132;
            this.label_address1.Text = "Address 1";
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(172, 117);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(138, 20);
            this.txt_telephone.TabIndex = 14;
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(170, 100);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(58, 13);
            this.label_telephone.TabIndex = 133;
            this.label_telephone.Text = "Telephone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(10, 117);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(138, 20);
            this.txt_email.TabIndex = 3;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(8, 100);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(42, 13);
            this.label_email.TabIndex = 134;
            this.label_email.Text = "E-Mail";
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dob.Location = new System.Drawing.Point(170, 24);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(79, 13);
            this.label_dob.TabIndex = 136;
            this.label_dob.Text = "Date of Birth";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(10, 79);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(138, 20);
            this.txt_lastName.TabIndex = 2;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(8, 62);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(58, 13);
            this.label_lastName.TabIndex = 137;
            this.label_lastName.Text = "Last Name";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(10, 41);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(138, 20);
            this.txt_firstName.TabIndex = 1;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(8, 24);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(57, 13);
            this.label_firstName.TabIndex = 138;
            this.label_firstName.Text = "First Name";
            // 
            // label_staffinfo
            // 
            this.label_staffinfo.AutoSize = true;
            this.label_staffinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_staffinfo.Location = new System.Drawing.Point(10, 7);
            this.label_staffinfo.Name = "label_staffinfo";
            this.label_staffinfo.Size = new System.Drawing.Size(121, 16);
            this.label_staffinfo.TabIndex = 139;
            this.label_staffinfo.Text = "GYM STAFF INFO:";
            // 
            // txt_qualifications
            // 
            this.txt_qualifications.Location = new System.Drawing.Point(346, 326);
            this.txt_qualifications.Multiline = true;
            this.txt_qualifications.Name = "txt_qualifications";
            this.txt_qualifications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_qualifications.Size = new System.Drawing.Size(299, 75);
            this.txt_qualifications.TabIndex = 25;
            // 
            // label_qualifications
            // 
            this.label_qualifications.AutoSize = true;
            this.label_qualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qualifications.Location = new System.Drawing.Point(343, 305);
            this.label_qualifications.Name = "label_qualifications";
            this.label_qualifications.Size = new System.Drawing.Size(91, 16);
            this.label_qualifications.TabIndex = 118;
            this.label_qualifications.Text = "Qualifications:";
            // 
            // label_mobile
            // 
            this.label_mobile.AutoSize = true;
            this.label_mobile.Location = new System.Drawing.Point(170, 62);
            this.label_mobile.Name = "label_mobile";
            this.label_mobile.Size = new System.Drawing.Size(38, 13);
            this.label_mobile.TabIndex = 135;
            this.label_mobile.Text = "Mobile";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(172, 79);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(138, 20);
            this.txt_mobile.TabIndex = 13;
            // 
            // txt_natinsnumb
            // 
            this.txt_natinsnumb.Location = new System.Drawing.Point(10, 270);
            this.txt_natinsnumb.Name = "txt_natinsnumb";
            this.txt_natinsnumb.Size = new System.Drawing.Size(138, 20);
            this.txt_natinsnumb.TabIndex = 9;
            // 
            // label_natinsnumb
            // 
            this.label_natinsnumb.AutoSize = true;
            this.label_natinsnumb.Location = new System.Drawing.Point(8, 253);
            this.label_natinsnumb.Name = "label_natinsnumb";
            this.label_natinsnumb.Size = new System.Drawing.Size(136, 13);
            this.label_natinsnumb.TabIndex = 117;
            this.label_natinsnumb.Text = "National Insurance Number";
            // 
            // txt_contract_start
            // 
            this.txt_contract_start.Location = new System.Drawing.Point(10, 308);
            this.txt_contract_start.Mask = "00/00/0000";
            this.txt_contract_start.Name = "txt_contract_start";
            this.txt_contract_start.Size = new System.Drawing.Size(100, 20);
            this.txt_contract_start.TabIndex = 10;
            this.txt_contract_start.ValidatingType = typeof(System.DateTime);
            // 
            // label_contract_start
            // 
            this.label_contract_start.AutoSize = true;
            this.label_contract_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contract_start.Location = new System.Drawing.Point(8, 291);
            this.label_contract_start.Name = "label_contract_start";
            this.label_contract_start.Size = new System.Drawing.Size(86, 13);
            this.label_contract_start.TabIndex = 116;
            this.label_contract_start.Text = "Contract Start";
            // 
            // txt_contract_finish
            // 
            this.txt_contract_finish.Location = new System.Drawing.Point(10, 346);
            this.txt_contract_finish.Mask = "00/00/0000";
            this.txt_contract_finish.Name = "txt_contract_finish";
            this.txt_contract_finish.Size = new System.Drawing.Size(100, 20);
            this.txt_contract_finish.TabIndex = 11;
            this.txt_contract_finish.ValidatingType = typeof(System.DateTime);
            // 
            // label_contract_finish
            // 
            this.label_contract_finish.AutoSize = true;
            this.label_contract_finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contract_finish.Location = new System.Drawing.Point(8, 329);
            this.label_contract_finish.Name = "label_contract_finish";
            this.label_contract_finish.Size = new System.Drawing.Size(92, 13);
            this.label_contract_finish.TabIndex = 115;
            this.label_contract_finish.Text = "Contract Finish";
            // 
            // button_equipmentbooking
            // 
            this.button_equipmentbooking.Location = new System.Drawing.Point(172, 406);
            this.button_equipmentbooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_equipmentbooking.Name = "button_equipmentbooking";
            this.button_equipmentbooking.Size = new System.Drawing.Size(145, 26);
            this.button_equipmentbooking.TabIndex = 27;
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
            this.dg_eqbookings.Location = new System.Drawing.Point(172, 310);
            this.dg_eqbookings.Name = "dg_eqbookings";
            this.dg_eqbookings.RowHeadersVisible = false;
            this.dg_eqbookings.RowTemplate.Height = 24;
            this.dg_eqbookings.Size = new System.Drawing.Size(145, 91);
            this.dg_eqbookings.TabIndex = 31;
            this.dg_eqbookings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_eqbookings_CellDoubleClick);
            // 
            // label_eqbookings
            // 
            this.label_eqbookings.AutoSize = true;
            this.label_eqbookings.Location = new System.Drawing.Point(170, 292);
            this.label_eqbookings.Name = "label_eqbookings";
            this.label_eqbookings.Size = new System.Drawing.Size(152, 13);
            this.label_eqbookings.TabIndex = 34;
            this.label_eqbookings.Text = "Currently Borrowed Equipment:";
            // 
            // label_dateformat
            // 
            this.label_dateformat.AutoSize = true;
            this.label_dateformat.Location = new System.Drawing.Point(248, 24);
            this.label_dateformat.Name = "label_dateformat";
            this.label_dateformat.Size = new System.Drawing.Size(71, 13);
            this.label_dateformat.TabIndex = 33;
            this.label_dateformat.Text = "(dd/mm/yyyy)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "(dd/mm/yyyy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "(dd/mm/yyyy)";
            // 
            // button_saveClose
            // 
            this.button_saveClose.Location = new System.Drawing.Point(556, 406);
            this.button_saveClose.Name = "button_saveClose";
            this.button_saveClose.Size = new System.Drawing.Size(91, 26);
            this.button_saveClose.TabIndex = 30;
            this.button_saveClose.Text = "Save and Close";
            this.button_saveClose.UseVisualStyleBackColor = true;
            this.button_saveClose.Click += new System.EventHandler(this.button_saveClose_Click);
            // 
            // button_saveOpen
            // 
            this.button_saveOpen.Location = new System.Drawing.Point(346, 406);
            this.button_saveOpen.Name = "button_saveOpen";
            this.button_saveOpen.Size = new System.Drawing.Size(112, 26);
            this.button_saveOpen.TabIndex = 28;
            this.button_saveOpen.Text = "Save and Open List";
            this.button_saveOpen.UseVisualStyleBackColor = true;
            this.button_saveOpen.Click += new System.EventHandler(this.button_saveOpen_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(100, 406);
            this.button_remove.Margin = new System.Windows.Forms.Padding(2);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(67, 26);
            this.button_remove.TabIndex = 140;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // chk_active
            // 
            this.chk_active.AutoSize = true;
            this.chk_active.Checked = true;
            this.chk_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_active.Location = new System.Drawing.Point(173, 6);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(62, 17);
            this.chk_active.TabIndex = 141;
            this.chk_active.TabStop = false;
            this.chk_active.Text = "Active?";
            this.chk_active.UseVisualStyleBackColor = true;
            // 
            // frm_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 443);
            this.Controls.Add(this.chk_active);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_saveOpen);
            this.Controls.Add(this.button_saveClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_dateformat);
            this.Controls.Add(this.label_eqbookings);
            this.Controls.Add(this.dg_eqbookings);
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
            this.MaximizeBox = false;
            this.Name = "frm_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.dg_eqbookings)).EndInit();
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
        private System.Windows.Forms.DataGridView dg_eqbookings;
        private System.Windows.Forms.Label label_eqbookings;
        private System.Windows.Forms.Label label_dateformat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_saveClose;
        private System.Windows.Forms.Button button_saveOpen;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.CheckBox chk_active;
    }
}