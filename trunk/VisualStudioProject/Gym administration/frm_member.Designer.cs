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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_membernum = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_emerg_telephone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_allergies = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_emerg_relation = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_doctor_phone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_doctor_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_emerg_name = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_emerg_mobile = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_dob = new System.Windows.Forms.MaskedTextBox();
            this.txt_medical_notes = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_county = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_pc = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.chk_active = new System.Windows.Forms.CheckBox();
            this.cmb_payment = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Info:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_membernum
            // 
            this.txt_membernum.Location = new System.Drawing.Point(12, 48);
            this.txt_membernum.Name = "txt_membernum";
            this.txt_membernum.ReadOnly = true;
            this.txt_membernum.Size = new System.Drawing.Size(138, 20);
            this.txt_membernum.TabIndex = 1;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(12, 87);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(138, 20);
            this.txt_firstName.TabIndex = 2;
            this.txt_firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(12, 127);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(138, 20);
            this.txt_lastName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date of Birth";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(177, 165);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(138, 20);
            this.txt_mobile.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mobile";
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(177, 204);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(138, 20);
            this.txt_telephone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telephone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(12, 204);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(138, 20);
            this.txt_email.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "E-Mail";
            // 
            // txt_address2
            // 
            this.txt_address2.Location = new System.Drawing.Point(177, 245);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(138, 20);
            this.txt_address2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Address 2";
            // 
            // txt_address1
            // 
            this.txt_address1.Location = new System.Drawing.Point(12, 245);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(138, 20);
            this.txt_address1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Address 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(341, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Emergency Contact:";
            // 
            // txt_emerg_telephone
            // 
            this.txt_emerg_telephone.Location = new System.Drawing.Point(344, 87);
            this.txt_emerg_telephone.Name = "txt_emerg_telephone";
            this.txt_emerg_telephone.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_telephone.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Telephone";
            // 
            // txt_allergies
            // 
            this.txt_allergies.Location = new System.Drawing.Point(344, 203);
            this.txt_allergies.Name = "txt_allergies";
            this.txt_allergies.Size = new System.Drawing.Size(138, 20);
            this.txt_allergies.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(341, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Allergies";
            // 
            // txt_emerg_relation
            // 
            this.txt_emerg_relation.Location = new System.Drawing.Point(503, 48);
            this.txt_emerg_relation.Name = "txt_emerg_relation";
            this.txt_emerg_relation.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_relation.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(500, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Relation";
            // 
            // txt_doctor_phone
            // 
            this.txt_doctor_phone.Location = new System.Drawing.Point(503, 164);
            this.txt_doctor_phone.Name = "txt_doctor_phone";
            this.txt_doctor_phone.Size = new System.Drawing.Size(138, 20);
            this.txt_doctor_phone.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(500, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Telephone";
            // 
            // txt_doctor_name
            // 
            this.txt_doctor_name.Location = new System.Drawing.Point(344, 164);
            this.txt_doctor_name.Name = "txt_doctor_name";
            this.txt_doctor_name.Size = new System.Drawing.Size(138, 20);
            this.txt_doctor_name.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(341, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Doctor Name";
            // 
            // txt_emerg_name
            // 
            this.txt_emerg_name.Location = new System.Drawing.Point(344, 48);
            this.txt_emerg_name.Name = "txt_emerg_name";
            this.txt_emerg_name.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_name.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(341, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Name";
            // 
            // txt_emerg_mobile
            // 
            this.txt_emerg_mobile.Location = new System.Drawing.Point(503, 87);
            this.txt_emerg_mobile.Name = "txt_emerg_mobile";
            this.txt_emerg_mobile.Size = new System.Drawing.Size(138, 20);
            this.txt_emerg_mobile.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(500, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Mobile";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(341, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(147, 16);
            this.label19.TabIndex = 36;
            this.label19.Text = "Medical Information:";
            // 
            // txt_dob
            // 
            this.txt_dob.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_dob.Location = new System.Drawing.Point(12, 165);
            this.txt_dob.Mask = "00/00/0000";
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(100, 20);
            this.txt_dob.TabIndex = 4;
            this.txt_dob.ValidatingType = typeof(System.DateTime);
            // 
            // txt_medical_notes
            // 
            this.txt_medical_notes.Location = new System.Drawing.Point(344, 245);
            this.txt_medical_notes.Multiline = true;
            this.txt_medical_notes.Name = "txt_medical_notes";
            this.txt_medical_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_medical_notes.Size = new System.Drawing.Size(297, 136);
            this.txt_medical_notes.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(341, 229);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Medical Notes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 40;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 26);
            this.button2.TabIndex = 41;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_county
            // 
            this.txt_county.Location = new System.Drawing.Point(175, 284);
            this.txt_county.Name = "txt_county";
            this.txt_county.Size = new System.Drawing.Size(138, 20);
            this.txt_county.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(172, 268);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "County";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(12, 284);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(138, 20);
            this.txt_city.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 268);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "City";
            // 
            // txt_pc
            // 
            this.txt_pc.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_pc.Location = new System.Drawing.Point(12, 323);
            this.txt_pc.Mask = ">LCCC 9LL";
            this.txt_pc.Name = "txt_pc";
            this.txt_pc.Size = new System.Drawing.Size(100, 20);
            this.txt_pc.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(172, 307);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(31, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "Type";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 307);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 46;
            this.label26.Text = "Post Code";
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
            this.cmb_type.Location = new System.Drawing.Point(175, 323);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_type.TabIndex = 13;
            // 
            // chk_active
            // 
            this.chk_active.AutoSize = true;
            this.chk_active.Checked = true;
            this.chk_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_active.Location = new System.Drawing.Point(12, 349);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(62, 17);
            this.chk_active.TabIndex = 14;
            this.chk_active.Text = "Active?";
            this.chk_active.UseVisualStyleBackColor = true;
            // 
            // cmb_payment
            // 
            this.cmb_payment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_payment.FormattingEnabled = true;
            this.cmb_payment.Items.AddRange(new object[] {
            "Debit Card",
            "Cash",
            "Cheque",
            "Bank Account"});
            this.cmb_payment.Location = new System.Drawing.Point(177, 363);
            this.cmb_payment.Name = "cmb_payment";
            this.cmb_payment.Size = new System.Drawing.Size(121, 21);
            this.cmb_payment.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(174, 347);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 54;
            this.label23.Text = "Payment Type";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 26);
            this.button3.TabIndex = 55;
            this.button3.Text = "Payments";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(131, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 26);
            this.button4.TabIndex = 56;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 443);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmb_payment);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.chk_active);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.txt_pc);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txt_county);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_medical_notes);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_emerg_mobile);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_emerg_telephone);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_allergies);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_emerg_relation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_doctor_phone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_doctor_name);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_emerg_name);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_address2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_address1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_membernum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Form";
            this.Load += new System.EventHandler(this.frm_member_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_membernum;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_emerg_telephone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_allergies;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_emerg_relation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_doctor_phone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_doctor_name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_emerg_name;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_emerg_mobile;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txt_dob;
        private System.Windows.Forms.TextBox txt_medical_notes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_county;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox txt_pc;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.CheckBox chk_active;
        private System.Windows.Forms.ComboBox cmb_payment;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}