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
            this.button_save = new System.Windows.Forms.Button();
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
            this.cmb_paymenttype = new System.Windows.Forms.ComboBox();
            this.label_paymenttype = new System.Windows.Forms.Label();
            this.button_payments = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_equipmentbooking = new System.Windows.Forms.Button();
            this.dg_currentborrows = new System.Windows.Forms.DataGridView();
            this.label_currentborrows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_currentborrows)).BeginInit();
            this.SuspendLayout();
            // 
            // label_memberinfo
            // 
            this.label_memberinfo.AutoSize = true;
            this.label_memberinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_memberinfo.Location = new System.Drawing.Point(16, 9);
            this.label_memberinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_memberinfo.Name = "label_memberinfo";
            this.label_memberinfo.Size = new System.Drawing.Size(119, 20);
            this.label_memberinfo.TabIndex = 0;
            this.label_memberinfo.Text = "Member Info:";
            // 
            // label_membernum
            // 
            this.label_membernum.AutoSize = true;
            this.label_membernum.Location = new System.Drawing.Point(16, 36);
            this.label_membernum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_membernum.Name = "label_membernum";
            this.label_membernum.Size = new System.Drawing.Size(113, 17);
            this.label_membernum.TabIndex = 1;
            this.label_membernum.Text = "Member Number";
            // 
            // txt_membernum
            // 
            this.txt_membernum.Location = new System.Drawing.Point(16, 56);
            this.txt_membernum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_membernum.Name = "txt_membernum";
            this.txt_membernum.ReadOnly = true;
            this.txt_membernum.Size = new System.Drawing.Size(183, 22);
            this.txt_membernum.TabIndex = 1;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(16, 107);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(183, 22);
            this.txt_firstName.TabIndex = 2;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(16, 90);
            this.label_firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(76, 17);
            this.label_firstName.TabIndex = 3;
            this.label_firstName.Text = "First Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(16, 156);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(183, 22);
            this.txt_lastName.TabIndex = 3;
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(16, 139);
            this.label_lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(76, 17);
            this.label_lastName.TabIndex = 5;
            this.label_lastName.Text = "Last Name";
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(16, 183);
            this.label_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(87, 17);
            this.label_dob.TabIndex = 7;
            this.label_dob.Text = "Date of Birth";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(234, 56);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(183, 22);
            this.txt_mobile.TabIndex = 5;
            // 
            // label_mobile
            // 
            this.label_mobile.AutoSize = true;
            this.label_mobile.Location = new System.Drawing.Point(234, 35);
            this.label_mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mobile.Name = "label_mobile";
            this.label_mobile.Size = new System.Drawing.Size(49, 17);
            this.label_mobile.TabIndex = 9;
            this.label_mobile.Text = "Mobile";
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(234, 103);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(183, 22);
            this.txt_telephone.TabIndex = 7;
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(234, 82);
            this.label_telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(76, 17);
            this.label_telephone.TabIndex = 13;
            this.label_telephone.Text = "Telephone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(16, 251);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(183, 22);
            this.txt_email.TabIndex = 6;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(16, 233);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(47, 17);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "E-Mail";
            // 
            // txt_address2
            // 
            this.txt_address2.Location = new System.Drawing.Point(234, 155);
            this.txt_address2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(183, 22);
            this.txt_address2.TabIndex = 9;
            // 
            // label_address2
            // 
            this.label_address2.AutoSize = true;
            this.label_address2.Location = new System.Drawing.Point(234, 129);
            this.label_address2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_address2.Name = "label_address2";
            this.label_address2.Size = new System.Drawing.Size(72, 17);
            this.label_address2.TabIndex = 17;
            this.label_address2.Text = "Address 2";
            // 
            // txt_address1
            // 
            this.txt_address1.Location = new System.Drawing.Point(16, 302);
            this.txt_address1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(183, 22);
            this.txt_address1.TabIndex = 8;
            // 
            // label_address1
            // 
            this.label_address1.AutoSize = true;
            this.label_address1.Location = new System.Drawing.Point(16, 282);
            this.label_address1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_address1.Name = "label_address1";
            this.label_address1.Size = new System.Drawing.Size(72, 17);
            this.label_address1.TabIndex = 15;
            this.label_address1.Text = "Address 1";
            // 
            // label_emergencycontact
            // 
            this.label_emergencycontact.AutoSize = true;
            this.label_emergencycontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emergencycontact.Location = new System.Drawing.Point(455, 9);
            this.label_emergencycontact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emergencycontact.Name = "label_emergencycontact";
            this.label_emergencycontact.Size = new System.Drawing.Size(179, 20);
            this.label_emergencycontact.TabIndex = 19;
            this.label_emergencycontact.Text = "Emergency Contact:";
            // 
            // txt_emerg_telephone
            // 
            this.txt_emerg_telephone.Location = new System.Drawing.Point(459, 107);
            this.txt_emerg_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emerg_telephone.Name = "txt_emerg_telephone";
            this.txt_emerg_telephone.Size = new System.Drawing.Size(183, 22);
            this.txt_emerg_telephone.TabIndex = 18;
            // 
            // label_emerg_telephone
            // 
            this.label_emerg_telephone.AutoSize = true;
            this.label_emerg_telephone.Location = new System.Drawing.Point(455, 87);
            this.label_emerg_telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emerg_telephone.Name = "label_emerg_telephone";
            this.label_emerg_telephone.Size = new System.Drawing.Size(76, 17);
            this.label_emerg_telephone.TabIndex = 32;
            this.label_emerg_telephone.Text = "Telephone";
            // 
            // txt_allergies
            // 
            this.txt_allergies.Location = new System.Drawing.Point(459, 250);
            this.txt_allergies.Margin = new System.Windows.Forms.Padding(4);
            this.txt_allergies.Name = "txt_allergies";
            this.txt_allergies.Size = new System.Drawing.Size(183, 22);
            this.txt_allergies.TabIndex = 22;
            // 
            // label_allergies
            // 
            this.label_allergies.AutoSize = true;
            this.label_allergies.Location = new System.Drawing.Point(455, 230);
            this.label_allergies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_allergies.Name = "label_allergies";
            this.label_allergies.Size = new System.Drawing.Size(62, 17);
            this.label_allergies.TabIndex = 30;
            this.label_allergies.Text = "Allergies";
            // 
            // txt_emerg_relation
            // 
            this.txt_emerg_relation.Location = new System.Drawing.Point(671, 59);
            this.txt_emerg_relation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emerg_relation.Name = "txt_emerg_relation";
            this.txt_emerg_relation.Size = new System.Drawing.Size(183, 22);
            this.txt_emerg_relation.TabIndex = 17;
            // 
            // label_emerg_relation
            // 
            this.label_emerg_relation.AutoSize = true;
            this.label_emerg_relation.Location = new System.Drawing.Point(667, 43);
            this.label_emerg_relation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emerg_relation.Name = "label_emerg_relation";
            this.label_emerg_relation.Size = new System.Drawing.Size(60, 17);
            this.label_emerg_relation.TabIndex = 28;
            this.label_emerg_relation.Text = "Relation";
            // 
            // txt_doctor_phone
            // 
            this.txt_doctor_phone.Location = new System.Drawing.Point(671, 202);
            this.txt_doctor_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doctor_phone.Name = "txt_doctor_phone";
            this.txt_doctor_phone.Size = new System.Drawing.Size(183, 22);
            this.txt_doctor_phone.TabIndex = 21;
            // 
            // label_doctor_phone
            // 
            this.label_doctor_phone.AutoSize = true;
            this.label_doctor_phone.Location = new System.Drawing.Point(667, 181);
            this.label_doctor_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_doctor_phone.Name = "label_doctor_phone";
            this.label_doctor_phone.Size = new System.Drawing.Size(76, 17);
            this.label_doctor_phone.TabIndex = 26;
            this.label_doctor_phone.Text = "Telephone";
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Location = new System.Drawing.Point(459, 202);
            this.txt_doctor_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(183, 22);
            this.txt_doctor_name.TabIndex = 20;
            // 
            // label_doctor_name
            // 
            this.label_doctor_name.AutoSize = true;
            this.label_doctor_name.Location = new System.Drawing.Point(455, 181);
            this.label_doctor_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_doctor_name.Name = "label_doctor_name";
            this.label_doctor_name.Size = new System.Drawing.Size(91, 17);
            this.label_doctor_name.TabIndex = 24;
            this.label_doctor_name.Text = "Doctor Name";
            // 
            // txt_emerg_name
            // 
            this.txt_emerg_name.Location = new System.Drawing.Point(459, 59);
            this.txt_emerg_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emerg_name.Name = "txt_emerg_name";
            this.txt_emerg_name.Size = new System.Drawing.Size(183, 22);
            this.txt_emerg_name.TabIndex = 16;
            // 
            // label_emerg_name
            // 
            this.label_emerg_name.AutoSize = true;
            this.label_emerg_name.Location = new System.Drawing.Point(455, 43);
            this.label_emerg_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emerg_name.Name = "label_emerg_name";
            this.label_emerg_name.Size = new System.Drawing.Size(45, 17);
            this.label_emerg_name.TabIndex = 20;
            this.label_emerg_name.Text = "Name";
            // 
            // txt_emerg_mobile
            // 
            this.txt_emerg_mobile.Location = new System.Drawing.Point(671, 107);
            this.txt_emerg_mobile.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emerg_mobile.Name = "txt_emerg_mobile";
            this.txt_emerg_mobile.Size = new System.Drawing.Size(183, 22);
            this.txt_emerg_mobile.TabIndex = 19;
            // 
            // label_emerg_mobile
            // 
            this.label_emerg_mobile.AutoSize = true;
            this.label_emerg_mobile.Location = new System.Drawing.Point(667, 87);
            this.label_emerg_mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emerg_mobile.Name = "label_emerg_mobile";
            this.label_emerg_mobile.Size = new System.Drawing.Size(49, 17);
            this.label_emerg_mobile.TabIndex = 34;
            this.label_emerg_mobile.Text = "Mobile";
            // 
            // label_medical_info
            // 
            this.label_medical_info.AutoSize = true;
            this.label_medical_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_medical_info.Location = new System.Drawing.Point(455, 146);
            this.label_medical_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_medical_info.Name = "label_medical_info";
            this.label_medical_info.Size = new System.Drawing.Size(180, 20);
            this.label_medical_info.TabIndex = 36;
            this.label_medical_info.Text = "Medical Information:";
            // 
            // txt_dob
            // 
            this.txt_dob.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_dob.Location = new System.Drawing.Point(16, 203);
            this.txt_dob.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dob.Mask = "00/00/0000";
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(132, 22);
            this.txt_dob.TabIndex = 4;
            this.txt_dob.ValidatingType = typeof(System.DateTime);
            // 
            // txt_medical_notes
            // 
            this.txt_medical_notes.Location = new System.Drawing.Point(459, 302);
            this.txt_medical_notes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_medical_notes.Multiline = true;
            this.txt_medical_notes.Name = "txt_medical_notes";
            this.txt_medical_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_medical_notes.Size = new System.Drawing.Size(395, 166);
            this.txt_medical_notes.TabIndex = 23;
            // 
            // label_medical_notes
            // 
            this.label_medical_notes.AutoSize = true;
            this.label_medical_notes.Location = new System.Drawing.Point(455, 282);
            this.label_medical_notes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_medical_notes.Name = "label_medical_notes";
            this.label_medical_notes.Size = new System.Drawing.Size(97, 17);
            this.label_medical_notes.TabIndex = 38;
            this.label_medical_notes.Text = "Medical Notes";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(739, 494);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(116, 32);
            this.button_save.TabIndex = 40;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(16, 494);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(116, 32);
            this.button_cancel.TabIndex = 41;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // txt_county
            // 
            this.txt_county.Location = new System.Drawing.Point(234, 203);
            this.txt_county.Margin = new System.Windows.Forms.Padding(4);
            this.txt_county.Name = "txt_county";
            this.txt_county.Size = new System.Drawing.Size(183, 22);
            this.txt_county.TabIndex = 11;
            // 
            // label_county
            // 
            this.label_county.AutoSize = true;
            this.label_county.Location = new System.Drawing.Point(234, 181);
            this.label_county.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_county.Name = "label_county";
            this.label_county.Size = new System.Drawing.Size(52, 17);
            this.label_county.TabIndex = 44;
            this.label_county.Text = "County";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(16, 350);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(183, 22);
            this.txt_city.TabIndex = 10;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(16, 330);
            this.label_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(31, 17);
            this.label_city.TabIndex = 42;
            this.label_city.Text = "City";
            // 
            // txt_pc
            // 
            this.txt_pc.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_pc.Location = new System.Drawing.Point(16, 398);
            this.txt_pc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pc.Mask = ">LCCC 9LL";
            this.txt_pc.Name = "txt_pc";
            this.txt_pc.Size = new System.Drawing.Size(132, 22);
            this.txt_pc.TabIndex = 12;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(234, 231);
            this.label_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(40, 17);
            this.label_type.TabIndex = 47;
            this.label_type.Text = "Type";
            // 
            // label_pc
            // 
            this.label_pc.AutoSize = true;
            this.label_pc.Location = new System.Drawing.Point(16, 378);
            this.label_pc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pc.Name = "label_pc";
            this.label_pc.Size = new System.Drawing.Size(73, 17);
            this.label_pc.TabIndex = 46;
            this.label_pc.Text = "Post Code";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Individual",
            "Group",
            "Family",
            "Student",
            "Company",
            "Over 60"});
            this.cmb_type.Location = new System.Drawing.Point(234, 251);
            this.cmb_type.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(163, 24);
            this.cmb_type.TabIndex = 13;
            // 
            // chk_active
            // 
            this.chk_active.AutoSize = true;
            this.chk_active.Checked = true;
            this.chk_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_active.Location = new System.Drawing.Point(16, 430);
            this.chk_active.Margin = new System.Windows.Forms.Padding(4);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(76, 21);
            this.chk_active.TabIndex = 14;
            this.chk_active.Text = "Active?";
            this.chk_active.UseVisualStyleBackColor = true;
            // 
            // cmb_paymenttype
            // 
            this.cmb_paymenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_paymenttype.FormattingEnabled = true;
            this.cmb_paymenttype.Items.AddRange(new object[] {
            "Debit Card",
            "Cash",
            "Cheque",
            "Bank Account"});
            this.cmb_paymenttype.Location = new System.Drawing.Point(234, 300);
            this.cmb_paymenttype.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_paymenttype.Name = "cmb_paymenttype";
            this.cmb_paymenttype.Size = new System.Drawing.Size(160, 24);
            this.cmb_paymenttype.TabIndex = 15;
            // 
            // label_paymenttype
            // 
            this.label_paymenttype.AutoSize = true;
            this.label_paymenttype.Location = new System.Drawing.Point(234, 280);
            this.label_paymenttype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymenttype.Name = "label_paymenttype";
            this.label_paymenttype.Size = new System.Drawing.Size(99, 17);
            this.label_paymenttype.TabIndex = 54;
            this.label_paymenttype.Text = "Payment Type";
            // 
            // button_payments
            // 
            this.button_payments.Location = new System.Drawing.Point(432, 494);
            this.button_payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_payments.Name = "button_payments";
            this.button_payments.Size = new System.Drawing.Size(99, 32);
            this.button_payments.TabIndex = 55;
            this.button_payments.Text = "Payments";
            this.button_payments.UseVisualStyleBackColor = true;
            this.button_payments.Click += new System.EventHandler(this.button_payments_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(139, 494);
            this.button_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(93, 32);
            this.button_remove.TabIndex = 56;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_equipmentbooking
            // 
            this.button_equipmentbooking.Location = new System.Drawing.Point(250, 494);
            this.button_equipmentbooking.Name = "button_equipmentbooking";
            this.button_equipmentbooking.Size = new System.Drawing.Size(164, 32);
            this.button_equipmentbooking.TabIndex = 57;
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
            this.dg_currentborrows.Location = new System.Drawing.Point(234, 350);
            this.dg_currentborrows.Margin = new System.Windows.Forms.Padding(4);
            this.dg_currentborrows.Name = "dg_currentborrows";
            this.dg_currentborrows.RowHeadersVisible = false;
            this.dg_currentborrows.RowTemplate.Height = 24;
            this.dg_currentborrows.Size = new System.Drawing.Size(193, 118);
            this.dg_currentborrows.TabIndex = 58;
            this.dg_currentborrows.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_currentborrows_CellDoubleClick);
            // 
            // label_currentborrows
            // 
            this.label_currentborrows.AutoSize = true;
            this.label_currentborrows.Location = new System.Drawing.Point(234, 330);
            this.label_currentborrows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_currentborrows.Name = "label_currentborrows";
            this.label_currentborrows.Size = new System.Drawing.Size(204, 17);
            this.label_currentborrows.TabIndex = 59;
            this.label_currentborrows.Text = "Currently Borrowed Equipment:";
            // 
            // frm_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 545);
            this.Controls.Add(this.label_currentborrows);
            this.Controls.Add(this.dg_currentborrows);
            this.Controls.Add(this.button_equipmentbooking);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_payments);
            this.Controls.Add(this.cmb_paymenttype);
            this.Controls.Add(this.label_paymenttype);
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
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.txt_medical_notes);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Form";
            this.Load += new System.EventHandler(this.frm_member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_currentborrows)).EndInit();
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
        private System.Windows.Forms.Button button_save;
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
        private System.Windows.Forms.ComboBox cmb_paymenttype;
        private System.Windows.Forms.Label label_paymenttype;
        private System.Windows.Forms.Button button_payments;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_equipmentbooking;
        private System.Windows.Forms.DataGridView dg_currentborrows;
        private System.Windows.Forms.Label label_currentborrows;
    }
}