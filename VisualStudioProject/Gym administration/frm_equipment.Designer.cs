﻿namespace Gym_administration
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
            this.label_iteminfo = new System.Windows.Forms.Label();
            this.txt_setname = new System.Windows.Forms.TextBox();
            this.label_setname = new System.Windows.Forms.Label();
            this.button_vehicle = new System.Windows.Forms.Button();
            this.label_stock = new System.Windows.Forms.Label();
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
            this.counter_stock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(203, 497);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(116, 32);
            this.button_remove.TabIndex = 178;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // rd_item
            // 
            this.rd_item.AutoSize = true;
            this.rd_item.Checked = true;
            this.rd_item.Location = new System.Drawing.Point(223, 29);
            this.rd_item.Margin = new System.Windows.Forms.Padding(4);
            this.rd_item.Name = "rd_item";
            this.rd_item.Size = new System.Drawing.Size(55, 21);
            this.rd_item.TabIndex = 177;
            this.rd_item.TabStop = true;
            this.rd_item.Text = "Item";
            this.rd_item.UseVisualStyleBackColor = true;
            this.rd_item.Click += new System.EventHandler(this.rd_item_Checked);
            // 
            // rd_set
            // 
            this.rd_set.AutoSize = true;
            this.rd_set.Location = new System.Drawing.Point(291, 29);
            this.rd_set.Margin = new System.Windows.Forms.Padding(4);
            this.rd_set.Name = "rd_set";
            this.rd_set.Size = new System.Drawing.Size(50, 21);
            this.rd_set.TabIndex = 176;
            this.rd_set.TabStop = true;
            this.rd_set.Text = "Set";
            this.rd_set.UseVisualStyleBackColor = true;
            this.rd_set.Click += new System.EventHandler(this.rd_set_Checked);
            // 
            // label_itemdesc
            // 
            this.label_itemdesc.AutoSize = true;
            this.label_itemdesc.Location = new System.Drawing.Point(77, 166);
            this.label_itemdesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_itemdesc.Name = "label_itemdesc";
            this.label_itemdesc.Size = new System.Drawing.Size(109, 17);
            this.label_itemdesc.TabIndex = 175;
            this.label_itemdesc.Text = "Item Description";
            // 
            // txt_equipmentdesc
            // 
            this.txt_equipmentdesc.Location = new System.Drawing.Point(79, 187);
            this.txt_equipmentdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_equipmentdesc.Multiline = true;
            this.txt_equipmentdesc.Name = "txt_equipmentdesc";
            this.txt_equipmentdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_equipmentdesc.Size = new System.Drawing.Size(395, 123);
            this.txt_equipmentdesc.TabIndex = 174;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(79, 497);
            this.button_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(116, 32);
            this.button_close.TabIndex = 173;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(359, 497);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(116, 32);
            this.button_save.TabIndex = 172;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // txt_itemname
            // 
            this.txt_itemname.Location = new System.Drawing.Point(79, 81);
            this.txt_itemname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(183, 22);
            this.txt_itemname.TabIndex = 170;
            // 
            // label_itemname
            // 
            this.label_itemname.AutoSize = true;
            this.label_itemname.Location = new System.Drawing.Point(76, 60);
            this.label_itemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_itemname.Name = "label_itemname";
            this.label_itemname.Size = new System.Drawing.Size(75, 17);
            this.label_itemname.TabIndex = 171;
            this.label_itemname.Text = "Item Name";
            // 
            // label_iteminfo
            // 
            this.label_iteminfo.AutoSize = true;
            this.label_iteminfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iteminfo.Location = new System.Drawing.Point(75, 30);
            this.label_iteminfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_iteminfo.Name = "label_iteminfo";
            this.label_iteminfo.Size = new System.Drawing.Size(88, 20);
            this.label_iteminfo.TabIndex = 169;
            this.label_iteminfo.Text = "Item Info:";
            // 
            // txt_setname
            // 
            this.txt_setname.Location = new System.Drawing.Point(291, 81);
            this.txt_setname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_setname.Name = "txt_setname";
            this.txt_setname.Size = new System.Drawing.Size(183, 22);
            this.txt_setname.TabIndex = 179;
            // 
            // label_setname
            // 
            this.label_setname.AutoSize = true;
            this.label_setname.Location = new System.Drawing.Point(288, 60);
            this.label_setname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_setname.Name = "label_setname";
            this.label_setname.Size = new System.Drawing.Size(70, 17);
            this.label_setname.TabIndex = 180;
            this.label_setname.Text = "Set Name";
            // 
            // button_vehicle
            // 
            this.button_vehicle.Location = new System.Drawing.Point(360, 23);
            this.button_vehicle.Name = "button_vehicle";
            this.button_vehicle.Size = new System.Drawing.Size(115, 32);
            this.button_vehicle.TabIndex = 181;
            this.button_vehicle.Text = "Vehicle";
            this.button_vehicle.UseVisualStyleBackColor = true;
            this.button_vehicle.Click += new System.EventHandler(this.button_vehicle_Click);
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Location = new System.Drawing.Point(108, 111);
            this.label_stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(119, 17);
            this.label_stock.TabIndex = 183;
            this.label_stock.Text = "Currently in Stock";
            // 
            // cmb_item1
            // 
            this.cmb_item1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item1.FormattingEnabled = true;
            this.cmb_item1.Location = new System.Drawing.Point(101, 340);
            this.cmb_item1.Name = "cmb_item1";
            this.cmb_item1.Size = new System.Drawing.Size(183, 24);
            this.cmb_item1.TabIndex = 185;
            this.cmb_item1.SelectedIndexChanged += new System.EventHandler(this.cmb_item1_SelectedIndexChanged);
            this.cmb_item1.SelectedValueChanged += new System.EventHandler(this.cmb_item1_SelectedIndexChanged);
            this.cmb_item1.TextChanged += new System.EventHandler(this.cmb_item1_SelectedIndexChanged);
            // 
            // cmb_item2
            // 
            this.cmb_item2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item2.FormattingEnabled = true;
            this.cmb_item2.Location = new System.Drawing.Point(101, 369);
            this.cmb_item2.Name = "cmb_item2";
            this.cmb_item2.Size = new System.Drawing.Size(183, 24);
            this.cmb_item2.TabIndex = 186;
            this.cmb_item2.SelectedIndexChanged += new System.EventHandler(this.cmb_item2_SelectedIndexChanged);
            this.cmb_item2.SelectedValueChanged += new System.EventHandler(this.cmb_item2_SelectedIndexChanged);
            this.cmb_item2.TextChanged += new System.EventHandler(this.cmb_item2_SelectedIndexChanged);
            // 
            // cmb_item3
            // 
            this.cmb_item3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item3.FormattingEnabled = true;
            this.cmb_item3.Location = new System.Drawing.Point(101, 399);
            this.cmb_item3.Name = "cmb_item3";
            this.cmb_item3.Size = new System.Drawing.Size(183, 24);
            this.cmb_item3.TabIndex = 187;
            this.cmb_item3.SelectedIndexChanged += new System.EventHandler(this.cmb_item3_SelectedIndexChanged);
            this.cmb_item3.SelectedValueChanged += new System.EventHandler(this.cmb_item3_SelectedIndexChanged);
            this.cmb_item3.TextChanged += new System.EventHandler(this.cmb_item3_SelectedIndexChanged);
            // 
            // cmb_item4
            // 
            this.cmb_item4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item4.FormattingEnabled = true;
            this.cmb_item4.Location = new System.Drawing.Point(101, 429);
            this.cmb_item4.Name = "cmb_item4";
            this.cmb_item4.Size = new System.Drawing.Size(183, 24);
            this.cmb_item4.TabIndex = 188;
            this.cmb_item4.SelectedIndexChanged += new System.EventHandler(this.cmb_item4_SelectedIndexChanged);
            this.cmb_item4.SelectedValueChanged += new System.EventHandler(this.cmb_item4_SelectedIndexChanged);
            this.cmb_item4.TextChanged += new System.EventHandler(this.cmb_item4_SelectedIndexChanged);
            // 
            // cmb_item5
            // 
            this.cmb_item5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_item5.FormattingEnabled = true;
            this.cmb_item5.Location = new System.Drawing.Point(101, 459);
            this.cmb_item5.Name = "cmb_item5";
            this.cmb_item5.Size = new System.Drawing.Size(183, 24);
            this.cmb_item5.TabIndex = 189;
            this.cmb_item5.SelectedIndexChanged += new System.EventHandler(this.cmb_item5_SelectedIndexChanged);
            this.cmb_item5.SelectedValueChanged += new System.EventHandler(this.cmb_item5_SelectedIndexChanged);
            this.cmb_item5.TextChanged += new System.EventHandler(this.cmb_item5_SelectedIndexChanged);
            // 
            // label_itemamount
            // 
            this.label_itemamount.AutoSize = true;
            this.label_itemamount.Location = new System.Drawing.Point(324, 318);
            this.label_itemamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_itemamount.Name = "label_itemamount";
            this.label_itemamount.Size = new System.Drawing.Size(126, 17);
            this.label_itemamount.TabIndex = 195;
            this.label_itemamount.Text = "Item Amount in Set";
            // 
            // label_iteminset
            // 
            this.label_iteminset.AutoSize = true;
            this.label_iteminset.Location = new System.Drawing.Point(140, 318);
            this.label_iteminset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_iteminset.Name = "label_iteminset";
            this.label_iteminset.Size = new System.Drawing.Size(81, 17);
            this.label_iteminset.TabIndex = 196;
            this.label_iteminset.Text = "Items in Set";
            // 
            // counter_item2
            // 
            this.counter_item2.Location = new System.Drawing.Point(327, 371);
            this.counter_item2.Name = "counter_item2";
            this.counter_item2.Size = new System.Drawing.Size(116, 22);
            this.counter_item2.TabIndex = 198;
            // 
            // counter_item1
            // 
            this.counter_item1.Location = new System.Drawing.Point(327, 341);
            this.counter_item1.Name = "counter_item1";
            this.counter_item1.Size = new System.Drawing.Size(116, 22);
            this.counter_item1.TabIndex = 199;
            // 
            // counter_item3
            // 
            this.counter_item3.Location = new System.Drawing.Point(327, 401);
            this.counter_item3.Name = "counter_item3";
            this.counter_item3.Size = new System.Drawing.Size(116, 22);
            this.counter_item3.TabIndex = 200;
            // 
            // counter_item4
            // 
            this.counter_item4.Location = new System.Drawing.Point(327, 431);
            this.counter_item4.Name = "counter_item4";
            this.counter_item4.Size = new System.Drawing.Size(116, 22);
            this.counter_item4.TabIndex = 201;
            // 
            // counter_item5
            // 
            this.counter_item5.Location = new System.Drawing.Point(327, 461);
            this.counter_item5.Name = "counter_item5";
            this.counter_item5.Size = new System.Drawing.Size(116, 22);
            this.counter_item5.TabIndex = 202;
            // 
            // label_itemsetinfo
            // 
            this.label_itemsetinfo.AutoSize = true;
            this.label_itemsetinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemsetinfo.Location = new System.Drawing.Point(75, 30);
            this.label_itemsetinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_itemsetinfo.Name = "label_itemsetinfo";
            this.label_itemsetinfo.Size = new System.Drawing.Size(122, 20);
            this.label_itemsetinfo.TabIndex = 203;
            this.label_itemsetinfo.Text = "Item Set Info:";
            // 
            // label_itemsetdesc
            // 
            this.label_itemsetdesc.AutoSize = true;
            this.label_itemsetdesc.Location = new System.Drawing.Point(77, 166);
            this.label_itemsetdesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_itemsetdesc.Name = "label_itemsetdesc";
            this.label_itemsetdesc.Size = new System.Drawing.Size(134, 17);
            this.label_itemsetdesc.TabIndex = 205;
            this.label_itemsetdesc.Text = "Item Set Description";
            // 
            // counter_stock
            // 
            this.counter_stock.Location = new System.Drawing.Point(111, 130);
            this.counter_stock.Name = "counter_stock";
            this.counter_stock.Size = new System.Drawing.Size(116, 22);
            this.counter_stock.TabIndex = 206;
            // 
            // frm_equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 542);
            this.Controls.Add(this.counter_stock);
            this.Controls.Add(this.label_itemsetdesc);
            this.Controls.Add(this.label_itemsetinfo);
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
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.button_vehicle);
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
            this.Name = "frm_equipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_equipment";
            this.Load += new System.EventHandler(this.frm_equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.counter_item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_item5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counter_stock)).EndInit();
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
        private System.Windows.Forms.Label label_iteminfo;
        private System.Windows.Forms.TextBox txt_setname;
        private System.Windows.Forms.Label label_setname;
        private System.Windows.Forms.Button button_vehicle;
        private System.Windows.Forms.Label label_stock;
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
        private System.Windows.Forms.NumericUpDown counter_stock;
    }
}