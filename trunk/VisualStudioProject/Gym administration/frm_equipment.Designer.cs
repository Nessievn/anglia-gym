namespace Gym_administration
{
    partial class frm_equipment
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
            this.button_remove = new System.Windows.Forms.Button();
            this.rd_item = new System.Windows.Forms.RadioButton();
            this.rd_set = new System.Windows.Forms.RadioButton();
            this.label_itemdesc = new System.Windows.Forms.Label();
            this.txt_equipmentdesc = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.label_itemname = new System.Windows.Forms.Label();
            this.txt_setname = new System.Windows.Forms.TextBox();
            this.label_setname = new System.Windows.Forms.Label();
            this.cmb_item1 = new System.Windows.Forms.ComboBox();
            this.cmb_item2 = new System.Windows.Forms.ComboBox();
            this.cmb_item3 = new System.Windows.Forms.ComboBox();
            this.cmb_item4 = new System.Windows.Forms.ComboBox();
            this.cmb_item5 = new System.Windows.Forms.ComboBox();
            this.label_itemamount = new System.Windows.Forms.Label();
            this.label_iteminset = new System.Windows.Forms.Label();
            this.counter_item2 = new System.Windows.Forms.NumericUpDown();
            this.counter_item1 = new System.Windows.Forms.NumericUpDown();
            this.counter_item3 = new System.Windows.Forms.NumericUpDown();
            this.counter_item4 = new System.Windows.Forms.NumericUpDown();
            this.counter_item5 = new System.Windows.Forms.NumericUpDown();
            this.label_itemsetinfo = new System.Windows.Forms.Label();
            this.label_itemsetdesc = new System.Windows.Forms.Label();
            this.counter_amounttoborrow = new System.Windows.Forms.NumericUpDown();
            this.label_amounttoborrow = new System.Windows.Forms.Label();
            this.counter_numberofdays = new System.Windows.Forms.NumericUpDown();
            this.label_numberofdays = new System.Windows.Forms.Label();
            this.label_iteminfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_amounttoborrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_numberofdays)).BeginInit();
            this.SuspendLayout();
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(152, 404);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(87, 26);
            this.button_remove.TabIndex = 18;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // rd_item
            // 
            this.rd_item.AutoSize = true;
            this.rd_item.Checked = true;
            this.rd_item.Location = new System.Drawing.Point(167, 24);
            this.rd_item.Name = "rd_item";
            this.rd_item.Size = new System.Drawing.Size(45, 17);
            this.rd_item.TabIndex = 2;
            this.rd_item.TabStop = true;
            this.rd_item.Text = "Item";
            this.rd_item.UseVisualStyleBackColor = true;
            this.rd_item.Click += new System.EventHandler(this.rd_item_Checked);
            // 
            // rd_set
            // 
            this.rd_set.AutoSize = true;
            this.rd_set.Location = new System.Drawing.Point(218, 24);
            this.rd_set.Name = "rd_set";
            this.rd_set.Size = new System.Drawing.Size(41, 17);
            this.rd_set.TabIndex = 3;
            this.rd_set.TabStop = true;
            this.rd_set.Text = "Set";
            this.rd_set.UseVisualStyleBackColor = true;
            this.rd_set.Click += new System.EventHandler(this.rd_set_Checked);
            // 
            // label_itemdesc
            // 
            this.label_itemdesc.AutoSize = true;
            this.label_itemdesc.Location = new System.Drawing.Point(58, 135);
            this.label_itemdesc.Name = "label_itemdesc";
            this.label_itemdesc.Size = new System.Drawing.Size(83, 13);
            this.label_itemdesc.TabIndex = 175;
            this.label_itemdesc.Text = "Item Description";
            // 
            // txt_equipmentdesc
            // 
            this.txt_equipmentdesc.Location = new System.Drawing.Point(59, 152);
            this.txt_equipmentdesc.Multiline = true;
            this.txt_equipmentdesc.Name = "txt_equipmentdesc";
            this.txt_equipmentdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_equipmentdesc.Size = new System.Drawing.Size(297, 101);
            this.txt_equipmentdesc.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(59, 404);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(87, 26);
            this.button_close.TabIndex = 17;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(269, 404);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(87, 26);
            this.button_save.TabIndex = 19;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(59, 66);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(138, 20);
            this.txt_itemname.TabIndex = 0;
            // 
            // label_itemname
            // 
            this.label_itemname.AutoSize = true;
            this.label_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemname.Location = new System.Drawing.Point(57, 49);
            this.label_itemname.Name = "label_itemname";
            this.label_itemname.Size = new System.Drawing.Size(67, 13);
            this.label_itemname.TabIndex = 171;
            this.label_itemname.Text = "Item Name";
            // 
            // txt_setname
            // 
            this.txt_setname.Location = new System.Drawing.Point(218, 66);
            this.txt_setname.Name = "txt_setname";
            this.txt_setname.Size = new System.Drawing.Size(138, 20);
            this.txt_setname.TabIndex = 4;
            // 
            // label_setname
            // 
            this.label_setname.AutoSize = true;
            this.label_setname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_setname.Location = new System.Drawing.Point(216, 49);
            this.label_setname.Name = "label_setname";
            this.label_setname.Size = new System.Drawing.Size(62, 13);
            this.label_setname.TabIndex = 180;
            this.label_setname.Text = "Set Name";
            // 
            // cmb_item1
            // 
            this.cmb_item1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item1.FormattingEnabled = true;
            this.cmb_item1.Location = new System.Drawing.Point(76, 276);
            this.cmb_item1.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_item1.Name = "cmb_item1";
            this.cmb_item1.Size = new System.Drawing.Size(138, 21);
            this.cmb_item1.TabIndex = 7;
            this.cmb_item1.SelectedIndexChanged += new System.EventHandler(this.cmb_item1_SelectedIndexChanged);
            this.cmb_item1.SelectedValueChanged += new System.EventHandler(this.cmb_item1_SelectedIndexChanged);
            this.cmb_item1.TextChanged += new System.EventHandler(this.cmb_item1_SelectedIndexChanged);
            // 
            // cmb_item2
            // 
            this.cmb_item2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item2.FormattingEnabled = true;
            this.cmb_item2.Location = new System.Drawing.Point(76, 300);
            this.cmb_item2.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_item2.Name = "cmb_item2";
            this.cmb_item2.Size = new System.Drawing.Size(138, 21);
            this.cmb_item2.TabIndex = 9;
            this.cmb_item2.SelectedIndexChanged += new System.EventHandler(this.cmb_item2_SelectedIndexChanged);
            this.cmb_item2.SelectedValueChanged += new System.EventHandler(this.cmb_item2_SelectedIndexChanged);
            this.cmb_item2.TextChanged += new System.EventHandler(this.cmb_item2_SelectedIndexChanged);
            // 
            // cmb_item3
            // 
            this.cmb_item3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item3.FormattingEnabled = true;
            this.cmb_item3.Location = new System.Drawing.Point(76, 324);
            this.cmb_item3.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_item3.Name = "cmb_item3";
            this.cmb_item3.Size = new System.Drawing.Size(138, 21);
            this.cmb_item3.TabIndex = 11;
            this.cmb_item3.SelectedIndexChanged += new System.EventHandler(this.cmb_item3_SelectedIndexChanged);
            this.cmb_item3.SelectedValueChanged += new System.EventHandler(this.cmb_item3_SelectedIndexChanged);
            this.cmb_item3.TextChanged += new System.EventHandler(this.cmb_item3_SelectedIndexChanged);
            // 
            // cmb_item4
            // 
            this.cmb_item4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item4.FormattingEnabled = true;
            this.cmb_item4.Location = new System.Drawing.Point(76, 349);
            this.cmb_item4.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_item4.Name = "cmb_item4";
            this.cmb_item4.Size = new System.Drawing.Size(138, 21);
            this.cmb_item4.TabIndex = 13;
            this.cmb_item4.SelectedIndexChanged += new System.EventHandler(this.cmb_item4_SelectedIndexChanged);
            this.cmb_item4.SelectedValueChanged += new System.EventHandler(this.cmb_item4_SelectedIndexChanged);
            this.cmb_item4.TextChanged += new System.EventHandler(this.cmb_item4_SelectedIndexChanged);
            // 
            // cmb_item5
            // 
            this.cmb_item5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item5.FormattingEnabled = true;
            this.cmb_item5.Location = new System.Drawing.Point(76, 373);
            this.cmb_item5.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_item5.Name = "cmb_item5";
            this.cmb_item5.Size = new System.Drawing.Size(138, 21);
            this.cmb_item5.TabIndex = 15;
            this.cmb_item5.SelectedIndexChanged += new System.EventHandler(this.cmb_item5_SelectedIndexChanged);
            this.cmb_item5.SelectedValueChanged += new System.EventHandler(this.cmb_item5_SelectedIndexChanged);
            this.cmb_item5.TextChanged += new System.EventHandler(this.cmb_item5_SelectedIndexChanged);
            // 
            // label_itemamount
            // 
            this.label_itemamount.AutoSize = true;
            this.label_itemamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemamount.Location = new System.Drawing.Point(243, 258);
            this.label_itemamount.Name = "label_itemamount";
            this.label_itemamount.Size = new System.Drawing.Size(114, 13);
            this.label_itemamount.TabIndex = 195;
            this.label_itemamount.Text = "Item Amount in Set";
            // 
            // label_iteminset
            // 
            this.label_iteminset.AutoSize = true;
            this.label_iteminset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iteminset.Location = new System.Drawing.Point(105, 258);
            this.label_iteminset.Name = "label_iteminset";
            this.label_iteminset.Size = new System.Drawing.Size(74, 13);
            this.label_iteminset.TabIndex = 196;
            this.label_iteminset.Text = "Items in Set";
            // 
            // counter_item2
            // 
            this.counter_item2.Location = new System.Drawing.Point(245, 301);
            this.counter_item2.Margin = new System.Windows.Forms.Padding(2);
            this.counter_item2.Name = "counter_item2";
            this.counter_item2.Size = new System.Drawing.Size(88, 20);
            this.counter_item2.TabIndex = 10;
            // 
            // counter_item1
            // 
            this.counter_item1.Location = new System.Drawing.Point(245, 277);
            this.counter_item1.Margin = new System.Windows.Forms.Padding(2);
            this.counter_item1.Name = "counter_item1";
            this.counter_item1.Size = new System.Drawing.Size(88, 20);
            this.counter_item1.TabIndex = 8;
            // 
            // counter_item3
            // 
            this.counter_item3.Location = new System.Drawing.Point(245, 326);
            this.counter_item3.Margin = new System.Windows.Forms.Padding(2);
            this.counter_item3.Name = "counter_item3";
            this.counter_item3.Size = new System.Drawing.Size(88, 20);
            this.counter_item3.TabIndex = 12;
            // 
            // counter_item4
            // 
            this.counter_item4.Location = new System.Drawing.Point(245, 350);
            this.counter_item4.Margin = new System.Windows.Forms.Padding(2);
            this.counter_item4.Name = "counter_item4";
            this.counter_item4.Size = new System.Drawing.Size(88, 20);
            this.counter_item4.TabIndex = 14;
            // 
            // counter_item5
            // 
            this.counter_item5.Location = new System.Drawing.Point(245, 375);
            this.counter_item5.Margin = new System.Windows.Forms.Padding(2);
            this.counter_item5.Name = "counter_item5";
            this.counter_item5.Size = new System.Drawing.Size(88, 20);
            this.counter_item5.TabIndex = 16;
            // 
            // label_itemsetinfo
            // 
            this.label_itemsetinfo.AutoSize = true;
            this.label_itemsetinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemsetinfo.Location = new System.Drawing.Point(56, 24);
            this.label_itemsetinfo.Name = "label_itemsetinfo";
            this.label_itemsetinfo.Size = new System.Drawing.Size(107, 16);
            this.label_itemsetinfo.TabIndex = 203;
            this.label_itemsetinfo.Text = "ITEM SET INFO:";
            // 
            // label_itemsetdesc
            // 
            this.label_itemsetdesc.AutoSize = true;
            this.label_itemsetdesc.Location = new System.Drawing.Point(58, 135);
            this.label_itemsetdesc.Name = "label_itemsetdesc";
            this.label_itemsetdesc.Size = new System.Drawing.Size(102, 13);
            this.label_itemsetdesc.TabIndex = 205;
            this.label_itemsetdesc.Text = "Item Set Description";
            // 
            // counter_amounttoborrow
            // 
            this.counter_amounttoborrow.Location = new System.Drawing.Point(59, 107);
            this.counter_amounttoborrow.Margin = new System.Windows.Forms.Padding(2);
            this.counter_amounttoborrow.Name = "counter_amounttoborrow";
            this.counter_amounttoborrow.Size = new System.Drawing.Size(88, 20);
            this.counter_amounttoborrow.TabIndex = 5;
            this.counter_amounttoborrow.Visible = false;
            // 
            // label_amounttoborrow
            // 
            this.label_amounttoborrow.AutoSize = true;
            this.label_amounttoborrow.Location = new System.Drawing.Point(57, 91);
            this.label_amounttoborrow.Name = "label_amounttoborrow";
            this.label_amounttoborrow.Size = new System.Drawing.Size(93, 13);
            this.label_amounttoborrow.TabIndex = 209;
            this.label_amounttoborrow.Text = "Amount to borrow:";
            this.label_amounttoborrow.Visible = false;
            // 
            // counter_numberofdays
            // 
            this.counter_numberofdays.Location = new System.Drawing.Point(218, 107);
            this.counter_numberofdays.Margin = new System.Windows.Forms.Padding(2);
            this.counter_numberofdays.Name = "counter_numberofdays";
            this.counter_numberofdays.Size = new System.Drawing.Size(88, 20);
            this.counter_numberofdays.TabIndex = 6;
            this.counter_numberofdays.Visible = false;
            // 
            // label_numberofdays
            // 
            this.label_numberofdays.AutoSize = true;
            this.label_numberofdays.Location = new System.Drawing.Point(216, 91);
            this.label_numberofdays.Name = "label_numberofdays";
            this.label_numberofdays.Size = new System.Drawing.Size(136, 13);
            this.label_numberofdays.TabIndex = 211;
            this.label_numberofdays.Text = "Number of days until return:";
            this.label_numberofdays.Visible = false;
            // 
            // label_iteminfo
            // 
            this.label_iteminfo.AutoSize = true;
            this.label_iteminfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iteminfo.Location = new System.Drawing.Point(56, 24);
            this.label_iteminfo.Name = "label_iteminfo";
            this.label_iteminfo.Size = new System.Drawing.Size(77, 16);
            this.label_iteminfo.TabIndex = 169;
            this.label_iteminfo.Text = "ITEM INFO:";
            // 
            // frm_equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 440);
            this.Controls.Add(this.label_numberofdays);
            this.Controls.Add(this.counter_numberofdays);
            this.Controls.Add(this.label_amounttoborrow);
            this.Controls.Add(this.counter_amounttoborrow);
            this.Controls.Add(this.label_itemsetdesc);
            this.Controls.Add(this.counter_item1);
            this.Controls.Add(this.counter_item2);
            this.Controls.Add(this.counter_item3);
            this.Controls.Add(this.counter_item4);
            this.Controls.Add(this.counter_item5);
            this.Controls.Add(this.label_iteminset);
            this.Controls.Add(this.label_itemamount);
            this.Controls.Add(this.cmb_item1);
            this.Controls.Add(this.cmb_item2);
            this.Controls.Add(this.cmb_item3);
            this.Controls.Add(this.cmb_item4);
            this.Controls.Add(this.cmb_item5);
            this.Controls.Add(this.label_setname);
            this.Controls.Add(this.txt_setname);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.rd_item);
            this.Controls.Add(this.rd_set);
            this.Controls.Add(this.label_itemdesc);
            this.Controls.Add(this.txt_equipmentdesc);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.label_itemname);
            this.Controls.Add(this.label_iteminfo);
            this.Controls.Add(this.label_itemsetinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment form";
            ((System.ComponentModel.ISupportInitialize)(this.counter_item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_amounttoborrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_numberofdays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.RadioButton rd_item;
        private System.Windows.Forms.RadioButton rd_set;
        private System.Windows.Forms.Label label_itemdesc;
        private System.Windows.Forms.TextBox txt_equipmentdesc;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.Label label_itemname;
        private System.Windows.Forms.TextBox txt_setname;
        private System.Windows.Forms.Label label_setname;
        private System.Windows.Forms.ComboBox cmb_item1;
        private System.Windows.Forms.ComboBox cmb_item2;
        private System.Windows.Forms.ComboBox cmb_item3;
        private System.Windows.Forms.ComboBox cmb_item4;
        private System.Windows.Forms.ComboBox cmb_item5;
        private System.Windows.Forms.Label label_itemamount;
        private System.Windows.Forms.Label label_iteminset;
        private System.Windows.Forms.NumericUpDown counter_item2;
        private System.Windows.Forms.NumericUpDown counter_item1;
        private System.Windows.Forms.NumericUpDown counter_item3;
        private System.Windows.Forms.NumericUpDown counter_item4;
        private System.Windows.Forms.NumericUpDown counter_item5;
        private System.Windows.Forms.Label label_itemsetinfo;
        private System.Windows.Forms.Label label_itemsetdesc;
        private System.Windows.Forms.NumericUpDown counter_amounttoborrow;
        private System.Windows.Forms.Label label_amounttoborrow;
        private System.Windows.Forms.NumericUpDown counter_numberofdays;
        private System.Windows.Forms.Label label_numberofdays;
        private System.Windows.Forms.Label label_iteminfo;
    }
}