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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_equipmentname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_equipment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_equipment)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Add Equipment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Equipment Name";
            // 
            // txt_equipmentname
            // 
            this.txt_equipmentname.Location = new System.Drawing.Point(30, 43);
            this.txt_equipmentname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_equipmentname.Name = "txt_equipmentname";
            this.txt_equipmentname.Size = new System.Drawing.Size(235, 22);
            this.txt_equipmentname.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dg_equipment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_classes_CellDoubleClick);
            // 
            // frm_equipment_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_equipmentname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_equipment);
            this.Name = "frm_equipment_list";
            this.Text = "frm_equipment_list";
            ((System.ComponentModel.ISupportInitialize)(this.dg_equipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_equipmentname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_equipment;
    }
}