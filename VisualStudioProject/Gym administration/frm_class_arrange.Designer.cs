namespace Gym_administration
{
    partial class frm_class_arrange
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
            this.cmb_classes = new System.Windows.Forms.ComboBox();
            this.cmb_rooms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_instructors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_start = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_start_time = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_end_time = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_repeats = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_attendants = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_current = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Class";
            // 
            // cmb_classes
            // 
            this.cmb_classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_classes.FormattingEnabled = true;
            this.cmb_classes.Location = new System.Drawing.Point(14, 124);
            this.cmb_classes.Name = "cmb_classes";
            this.cmb_classes.Size = new System.Drawing.Size(223, 21);
            this.cmb_classes.TabIndex = 14;
            // 
            // cmb_rooms
            // 
            this.cmb_rooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_rooms.FormattingEnabled = true;
            this.cmb_rooms.Location = new System.Drawing.Point(14, 170);
            this.cmb_rooms.Name = "cmb_rooms";
            this.cmb_rooms.Size = new System.Drawing.Size(223, 21);
            this.cmb_rooms.TabIndex = 16;
            this.cmb_rooms.SelectedIndexChanged += new System.EventHandler(this.cmb_rooms_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose Room";
            // 
            // cmb_instructors
            // 
            this.cmb_instructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_instructors.FormattingEnabled = true;
            this.cmb_instructors.Location = new System.Drawing.Point(14, 220);
            this.cmb_instructors.Name = "cmb_instructors";
            this.cmb_instructors.Size = new System.Drawing.Size(223, 21);
            this.cmb_instructors.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Choose Instructor";
            // 
            // txt_start
            // 
            this.txt_start.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_start.Location = new System.Drawing.Point(256, 124);
            this.txt_start.Mask = "00/00/0000";
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(68, 20);
            this.txt_start.TabIndex = 19;
            this.txt_start.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date";
            // 
            // txt_start_time
            // 
            this.txt_start_time.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_start_time.Location = new System.Drawing.Point(256, 170);
            this.txt_start_time.Mask = "00:00";
            this.txt_start_time.Name = "txt_start_time";
            this.txt_start_time.Size = new System.Drawing.Size(68, 20);
            this.txt_start_time.TabIndex = 21;
            this.txt_start_time.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "End Time";
            // 
            // txt_end_time
            // 
            this.txt_end_time.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_end_time.Location = new System.Drawing.Point(341, 170);
            this.txt_end_time.Mask = "00:00";
            this.txt_end_time.Name = "txt_end_time";
            this.txt_end_time.Size = new System.Drawing.Size(66, 20);
            this.txt_end_time.TabIndex = 23;
            this.txt_end_time.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Class Information:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(393, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Equipment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_repeats
            // 
            this.cmb_repeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_repeats.FormattingEnabled = true;
            this.cmb_repeats.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.cmb_repeats.Location = new System.Drawing.Point(256, 220);
            this.cmb_repeats.Name = "cmb_repeats";
            this.cmb_repeats.Size = new System.Drawing.Size(151, 21);
            this.cmb_repeats.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Repeats";
            // 
            // btn_attendants
            // 
            this.btn_attendants.Location = new System.Drawing.Point(129, 309);
            this.btn_attendants.Name = "btn_attendants";
            this.btn_attendants.Size = new System.Drawing.Size(108, 23);
            this.btn_attendants.TabIndex = 31;
            this.btn_attendants.Text = "Enroll Members";
            this.btn_attendants.UseVisualStyleBackColor = true;
            this.btn_attendants.Click += new System.EventHandler(this.btn_attendants_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "View Attendants";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_max);
            this.groupBox1.Controls.Add(this.lbl_current);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 68);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Members enrolled";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Current members:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Max. Members:";
            // 
            // lbl_current
            // 
            this.lbl_current.AutoSize = true;
            this.lbl_current.Location = new System.Drawing.Point(104, 31);
            this.lbl_current.Name = "lbl_current";
            this.lbl_current.Size = new System.Drawing.Size(13, 13);
            this.lbl_current.TabIndex = 2;
            this.lbl_current.Text = "0";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Location = new System.Drawing.Point(316, 31);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(13, 13);
            this.lbl_max.TabIndex = 3;
            this.lbl_max.Text = "0";
            // 
            // frm_class_arrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_attendants);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_repeats);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_end_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_start_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.cmb_instructors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_rooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_classes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_class_arrange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Arrange";
            this.Load += new System.EventHandler(this.frm_class_arrange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_classes;
        private System.Windows.Forms.ComboBox cmb_rooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_instructors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_start_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_end_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_repeats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_attendants;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label lbl_current;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}