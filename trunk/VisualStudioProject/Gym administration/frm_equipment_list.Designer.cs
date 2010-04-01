namespace Gym_administration
{
    partial class frm_equipment_list
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
            this.button_addequipment = new System.Windows.Forms.Button();
            this.label_equipmentname = new System.Windows.Forms.Label();
            this.txt_equipmentname = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.dg_equipment = new System.Windows.Forms.DataGridView();
            this.rd_item = new System.Windows.Forms.RadioButton();
            this.rd_set = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_equipment)).BeginInit();
            this.SuspendLayout();
            // 
            // button_addequipment
            // 
            this.button_addequipment.Location = new System.Drawing.Point(492, 40);
            this.button_addequipment.Margin = new System.Windows.Forms.Padding(4);
            this.button_addequipment.Name = "button_addequipment";
            this.button_addequipment.Size = new System.Drawing.Size(127, 28);
            this.button_addequipment.TabIndex = 27;
            this.button_addequipment.Text = "Add Equipment";
            this.button_addequipment.UseVisualStyleBackColor = true;
            this.button_addequipment.Click += new System.EventHandler(this.button_addequipment_Click);
            // 
            // label_equipmentname
            // 
            this.label_equipmentname.AutoSize = true;
            this.label_equipmentname.Location = new System.Drawing.Point(27, 24);
            this.label_equipmentname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_equipmentname.Name = "label_equipmentname";
            this.label_equipmentname.Size = new System.Drawing.Size(116, 17);
            this.label_equipmentname.TabIndex = 26;
            this.label_equipmentname.Text = "Equipment Name";
            // 
            // txt_equipmentname
            // 
            this.txt_equipmentname.Location = new System.Drawing.Point(30, 43);
            this.txt_equipmentname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_equipmentname.Name = "txt_equipmentname";
            this.txt_equipmentname.Size = new System.Drawing.Size(235, 22);
            this.txt_equipmentname.TabIndex = 25;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(274, 40);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 28);
            this.button_search.TabIndex = 24;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dg_equipment
            // 
            this.dg_equipment.AllowUserToDeleteRows = false;
            this.dg_equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_equipment.Location = new System.Drawing.Point(31, 75);
            this.dg_equipment.Margin = new System.Windows.Forms.Padding(4);
            this.dg_equipment.Name = "dg_equipment";
            this.dg_equipment.RowTemplate.Height = 24;
            this.dg_equipment.Size = new System.Drawing.Size(588, 300);
            this.dg_equipment.TabIndex = 23;
            this.dg_equipment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_equipment_CellDoubleClick);
            // 
            // rd_item
            // 
            this.rd_item.AutoSize = true;
            this.rd_item.Location = new System.Drawing.Point(155, 12);
            this.rd_item.Name = "rd_item";
            this.rd_item.Size = new System.Drawing.Size(62, 21);
            this.rd_item.TabIndex = 28;
            this.rd_item.TabStop = true;
            this.rd_item.Text = "Items";
            this.rd_item.UseVisualStyleBackColor = true;
            this.rd_item.Click += new System.EventHandler(this.rd_item_Checked);
            // 
            // rd_set
            // 
            this.rd_set.AutoSize = true;
            this.rd_set.Location = new System.Drawing.Point(274, 12);
            this.rd_set.Name = "rd_set";
            this.rd_set.Size = new System.Drawing.Size(57, 21);
            this.rd_set.TabIndex = 29;
            this.rd_set.TabStop = true;
            this.rd_set.Text = "Sets";
            this.rd_set.UseVisualStyleBackColor = true;
            this.rd_set.Click += new System.EventHandler(this.rd_set_Checked);
            // 
            // frm_equipment_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 399);
            this.Controls.Add(this.rd_set);
            this.Controls.Add(this.rd_item);
            this.Controls.Add(this.button_addequipment);
            this.Controls.Add(this.label_equipmentname);
            this.Controls.Add(this.txt_equipmentname);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dg_equipment);
            this.Name = "frm_equipment_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_equipment_list";
            ((System.ComponentModel.ISupportInitialize)(this.dg_equipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addequipment;
        private System.Windows.Forms.Label label_equipmentname;
        private System.Windows.Forms.TextBox txt_equipmentname;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView dg_equipment;
        private System.Windows.Forms.RadioButton rd_item;
        private System.Windows.Forms.RadioButton rd_set;
    }
}