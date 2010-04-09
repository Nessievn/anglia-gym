﻿namespace Gym_administration
{
    partial class frm_class_instance_arrange
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
            this.label_chooseclass = new System.Windows.Forms.Label();
            this.cmb_classes = new System.Windows.Forms.ComboBox();
            this.cmb_rooms = new System.Windows.Forms.ComboBox();
            this.label_chooserooms = new System.Windows.Forms.Label();
            this.cmb_instructors = new System.Windows.Forms.ComboBox();
            this.label_chooseinstructor = new System.Windows.Forms.Label();
            this.txt_startdate = new System.Windows.Forms.MaskedTextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.txt_starttime = new System.Windows.Forms.MaskedTextBox();
            this.label_starttime = new System.Windows.Forms.Label();
            this.label_endtime = new System.Windows.Forms.Label();
            this.txt_endtime = new System.Windows.Forms.MaskedTextBox();
            this.label_classinfo = new System.Windows.Forms.Label();
            this.label_equipment = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.cmb_repeats = new System.Windows.Forms.ComboBox();
            this.label_repeats = new System.Windows.Forms.Label();
            this.button_enrollmembers = new System.Windows.Forms.Button();
            this.button_viewattendants = new System.Windows.Forms.Button();
            this.groupBox_membersenrolled = new System.Windows.Forms.GroupBox();
            this.label_maxmembers_amount = new System.Windows.Forms.Label();
            this.lbl_currentmembers_amount = new System.Windows.Forms.Label();
            this.label_maxmembers = new System.Windows.Forms.Label();
            this.label_currentmembers = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.btn_equipment = new System.Windows.Forms.Button();
            this.label_currentborrows = new System.Windows.Forms.Label();
            this.dg_currentborrows = new System.Windows.Forms.DataGridView();
            this.groupBox_membersenrolled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_currentborrows)).BeginInit();
            this.SuspendLayout();
            // 
            // label_chooseclass
            // 
            this.label_chooseclass.AutoSize = true;
            this.label_chooseclass.Location = new System.Drawing.Point(11, 108);
            this.label_chooseclass.Name = "label_chooseclass";
            this.label_chooseclass.Size = new System.Drawing.Size(71, 13);
            this.label_chooseclass.TabIndex = 0;
            this.label_chooseclass.Text = "Choose Class";
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
            // label_chooserooms
            // 
            this.label_chooserooms.AutoSize = true;
            this.label_chooserooms.Location = new System.Drawing.Point(11, 154);
            this.label_chooserooms.Name = "label_chooserooms";
            this.label_chooserooms.Size = new System.Drawing.Size(74, 13);
            this.label_chooserooms.TabIndex = 15;
            this.label_chooserooms.Text = "Choose Room";
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
            // label_chooseinstructor
            // 
            this.label_chooseinstructor.AutoSize = true;
            this.label_chooseinstructor.Location = new System.Drawing.Point(11, 204);
            this.label_chooseinstructor.Name = "label_chooseinstructor";
            this.label_chooseinstructor.Size = new System.Drawing.Size(90, 13);
            this.label_chooseinstructor.TabIndex = 17;
            this.label_chooseinstructor.Text = "Choose Instructor";
            // 
            // txt_startdate
            // 
            this.txt_startdate.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_startdate.Location = new System.Drawing.Point(256, 124);
            this.txt_startdate.Mask = "00/00/0000";
            this.txt_startdate.Name = "txt_startdate";
            this.txt_startdate.Size = new System.Drawing.Size(68, 20);
            this.txt_startdate.TabIndex = 19;
            this.txt_startdate.ValidatingType = typeof(System.DateTime);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(253, 108);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 20;
            this.label_date.Text = "Date";
            // 
            // txt_starttime
            // 
            this.txt_starttime.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_starttime.Location = new System.Drawing.Point(256, 170);
            this.txt_starttime.Mask = "00:00";
            this.txt_starttime.Name = "txt_starttime";
            this.txt_starttime.Size = new System.Drawing.Size(68, 20);
            this.txt_starttime.TabIndex = 21;
            this.txt_starttime.ValidatingType = typeof(System.DateTime);
            // 
            // label_starttime
            // 
            this.label_starttime.AutoSize = true;
            this.label_starttime.Location = new System.Drawing.Point(253, 154);
            this.label_starttime.Name = "label_starttime";
            this.label_starttime.Size = new System.Drawing.Size(55, 13);
            this.label_starttime.TabIndex = 22;
            this.label_starttime.Text = "Start Time";
            // 
            // label_endtime
            // 
            this.label_endtime.AutoSize = true;
            this.label_endtime.Location = new System.Drawing.Point(338, 154);
            this.label_endtime.Name = "label_endtime";
            this.label_endtime.Size = new System.Drawing.Size(52, 13);
            this.label_endtime.TabIndex = 24;
            this.label_endtime.Text = "End Time";
            // 
            // txt_endtime
            // 
            this.txt_endtime.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_endtime.Location = new System.Drawing.Point(341, 170);
            this.txt_endtime.Mask = "00:00";
            this.txt_endtime.Name = "txt_endtime";
            this.txt_endtime.Size = new System.Drawing.Size(66, 20);
            this.txt_endtime.TabIndex = 23;
            this.txt_endtime.ValidatingType = typeof(System.DateTime);
            // 
            // label_classinfo
            // 
            this.label_classinfo.AutoSize = true;
            this.label_classinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_classinfo.Location = new System.Drawing.Point(11, 9);
            this.label_classinfo.Name = "label_classinfo";
            this.label_classinfo.Size = new System.Drawing.Size(131, 16);
            this.label_classinfo.TabIndex = 25;
            this.label_classinfo.Text = "Class Information:";
            // 
            // label_equipment
            // 
            this.label_equipment.AutoSize = true;
            this.label_equipment.Location = new System.Drawing.Point(11, 255);
            this.label_equipment.Name = "label_equipment";
            this.label_equipment.Size = new System.Drawing.Size(57, 13);
            this.label_equipment.TabIndex = 27;
            this.label_equipment.Text = "Equipment";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(328, 358);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 28;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
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
            // label_repeats
            // 
            this.label_repeats.AutoSize = true;
            this.label_repeats.Location = new System.Drawing.Point(253, 204);
            this.label_repeats.Name = "label_repeats";
            this.label_repeats.Size = new System.Drawing.Size(47, 13);
            this.label_repeats.TabIndex = 30;
            this.label_repeats.Text = "Repeats";
            // 
            // button_enrollmembers
            // 
            this.button_enrollmembers.Location = new System.Drawing.Point(214, 358);
            this.button_enrollmembers.Name = "button_enrollmembers";
            this.button_enrollmembers.Size = new System.Drawing.Size(108, 23);
            this.button_enrollmembers.TabIndex = 31;
            this.button_enrollmembers.Text = "Enroll Members";
            this.button_enrollmembers.UseVisualStyleBackColor = true;
            this.button_enrollmembers.Click += new System.EventHandler(this.button_enrollmembers_Click);
            // 
            // button_viewattendants
            // 
            this.button_viewattendants.Location = new System.Drawing.Point(99, 358);
            this.button_viewattendants.Name = "button_viewattendants";
            this.button_viewattendants.Size = new System.Drawing.Size(109, 23);
            this.button_viewattendants.TabIndex = 32;
            this.button_viewattendants.Text = "View Attendants";
            this.button_viewattendants.UseVisualStyleBackColor = true;
            this.button_viewattendants.Click += new System.EventHandler(this.button_viewattendants_Click);
            // 
            // groupBox_membersenrolled
            // 
            this.groupBox_membersenrolled.Controls.Add(this.label_maxmembers_amount);
            this.groupBox_membersenrolled.Controls.Add(this.lbl_currentmembers_amount);
            this.groupBox_membersenrolled.Controls.Add(this.label_maxmembers);
            this.groupBox_membersenrolled.Controls.Add(this.label_currentmembers);
            this.groupBox_membersenrolled.Location = new System.Drawing.Point(12, 37);
            this.groupBox_membersenrolled.Name = "groupBox_membersenrolled";
            this.groupBox_membersenrolled.Size = new System.Drawing.Size(394, 68);
            this.groupBox_membersenrolled.TabIndex = 33;
            this.groupBox_membersenrolled.TabStop = false;
            this.groupBox_membersenrolled.Text = "Members enrolled";
            // 
            // label_maxmembers_amount
            // 
            this.label_maxmembers_amount.AutoSize = true;
            this.label_maxmembers_amount.Location = new System.Drawing.Point(316, 31);
            this.label_maxmembers_amount.Name = "label_maxmembers_amount";
            this.label_maxmembers_amount.Size = new System.Drawing.Size(13, 13);
            this.label_maxmembers_amount.TabIndex = 3;
            this.label_maxmembers_amount.Text = "0";
            // 
            // lbl_currentmembers_amount
            // 
            this.lbl_currentmembers_amount.AutoSize = true;
            this.lbl_currentmembers_amount.Location = new System.Drawing.Point(104, 31);
            this.lbl_currentmembers_amount.Name = "lbl_currentmembers_amount";
            this.lbl_currentmembers_amount.Size = new System.Drawing.Size(13, 13);
            this.lbl_currentmembers_amount.TabIndex = 2;
            this.lbl_currentmembers_amount.Text = "0";
            // 
            // label_maxmembers
            // 
            this.label_maxmembers.AutoSize = true;
            this.label_maxmembers.Location = new System.Drawing.Point(241, 31);
            this.label_maxmembers.Name = "label_maxmembers";
            this.label_maxmembers.Size = new System.Drawing.Size(79, 13);
            this.label_maxmembers.TabIndex = 1;
            this.label_maxmembers.Text = "Max. Members:";
            // 
            // label_currentmembers
            // 
            this.label_currentmembers.AutoSize = true;
            this.label_currentmembers.Location = new System.Drawing.Point(17, 31);
            this.label_currentmembers.Name = "label_currentmembers";
            this.label_currentmembers.Size = new System.Drawing.Size(89, 13);
            this.label_currentmembers.TabIndex = 0;
            this.label_currentmembers.Text = "Current members:";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(7, 358);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 34;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // btn_equipment
            // 
            this.btn_equipment.Location = new System.Drawing.Point(12, 271);
            this.btn_equipment.Name = "btn_equipment";
            this.btn_equipment.Size = new System.Drawing.Size(152, 23);
            this.btn_equipment.TabIndex = 35;
            this.btn_equipment.Text = "Equipment Booking";
            this.btn_equipment.UseVisualStyleBackColor = true;
            this.btn_equipment.Click += new System.EventHandler(this.btn_equipment_Click);
            // 
            // label_currentborrows
            // 
            this.label_currentborrows.AutoSize = true;
            this.label_currentborrows.Location = new System.Drawing.Point(254, 254);
            this.label_currentborrows.Name = "label_currentborrows";
            this.label_currentborrows.Size = new System.Drawing.Size(152, 13);
            this.label_currentborrows.TabIndex = 117;
            this.label_currentborrows.Text = "Currently Borrowed Equipment:";
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
            this.dg_currentborrows.Location = new System.Drawing.Point(170, 271);
            this.dg_currentborrows.Name = "dg_currentborrows";
            this.dg_currentborrows.RowHeadersVisible = false;
            this.dg_currentborrows.RowTemplate.Height = 24;
            this.dg_currentborrows.Size = new System.Drawing.Size(231, 72);
            this.dg_currentborrows.TabIndex = 116;
            this.dg_currentborrows.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_currentborrows_CellDoubleClick);
            // 
            // frm_class_instance_arrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 393);
            this.Controls.Add(this.label_currentborrows);
            this.Controls.Add(this.dg_currentborrows);
            this.Controls.Add(this.btn_equipment);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.groupBox_membersenrolled);
            this.Controls.Add(this.button_viewattendants);
            this.Controls.Add(this.button_enrollmembers);
            this.Controls.Add(this.label_repeats);
            this.Controls.Add(this.cmb_repeats);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_equipment);
            this.Controls.Add(this.label_classinfo);
            this.Controls.Add(this.label_endtime);
            this.Controls.Add(this.txt_endtime);
            this.Controls.Add(this.label_starttime);
            this.Controls.Add(this.txt_starttime);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.txt_startdate);
            this.Controls.Add(this.cmb_instructors);
            this.Controls.Add(this.label_chooseinstructor);
            this.Controls.Add(this.cmb_rooms);
            this.Controls.Add(this.label_chooserooms);
            this.Controls.Add(this.cmb_classes);
            this.Controls.Add(this.label_chooseclass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_class_instance_arrange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Arrange";
            this.Load += new System.EventHandler(this.frm_class_instance_arrange_Load);
            this.groupBox_membersenrolled.ResumeLayout(false);
            this.groupBox_membersenrolled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_currentborrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_chooseclass;
        private System.Windows.Forms.ComboBox cmb_classes;
        private System.Windows.Forms.ComboBox cmb_rooms;
        private System.Windows.Forms.Label label_chooserooms;
        private System.Windows.Forms.ComboBox cmb_instructors;
        private System.Windows.Forms.Label label_chooseinstructor;
        private System.Windows.Forms.MaskedTextBox txt_startdate;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.MaskedTextBox txt_starttime;
        private System.Windows.Forms.Label label_starttime;
        private System.Windows.Forms.Label label_endtime;
        private System.Windows.Forms.MaskedTextBox txt_endtime;
        private System.Windows.Forms.Label label_classinfo;
        private System.Windows.Forms.Label label_equipment;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox cmb_repeats;
        private System.Windows.Forms.Label label_repeats;
        private System.Windows.Forms.Button button_enrollmembers;
        private System.Windows.Forms.Button button_viewattendants;
        private System.Windows.Forms.GroupBox groupBox_membersenrolled;
        private System.Windows.Forms.Label label_maxmembers_amount;
        private System.Windows.Forms.Label lbl_currentmembers_amount;
        private System.Windows.Forms.Label label_maxmembers;
        private System.Windows.Forms.Label label_currentmembers;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button btn_equipment;
        private System.Windows.Forms.Label label_currentborrows;
        private System.Windows.Forms.DataGridView dg_currentborrows;
    }
}