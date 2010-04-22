namespace Gym_administration
{
    partial class frm_equipment_bookings_list
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
            this.label_eqbookingdblclickinfo = new System.Windows.Forms.Label();
            this.dg_eqbookings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_eqbookings)).BeginInit();
            this.SuspendLayout();
            // 
            // label_eqbookingdblclickinfo
            // 
            this.label_eqbookingdblclickinfo.AutoSize = true;
            this.label_eqbookingdblclickinfo.Location = new System.Drawing.Point(7, 12);
            this.label_eqbookingdblclickinfo.Name = "label_eqbookingdblclickinfo";
            this.label_eqbookingdblclickinfo.Size = new System.Drawing.Size(248, 13);
            this.label_eqbookingdblclickinfo.TabIndex = 26;
            this.label_eqbookingdblclickinfo.Text = "Please double click on a row for equipment returns:";
            // 
            // dg_eqbookings
            // 
            this.dg_eqbookings.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dg_eqbookings.AllowUserToAddRows = false;
            this.dg_eqbookings.AllowUserToDeleteRows = false;
            this.dg_eqbookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_eqbookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_eqbookings.Location = new System.Drawing.Point(10, 54);
            this.dg_eqbookings.Name = "dg_eqbookings";
            this.dg_eqbookings.RowTemplate.Height = 24;
            this.dg_eqbookings.Size = new System.Drawing.Size(866, 256);
            this.dg_eqbookings.TabIndex = 0;
            this.dg_eqbookings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_eqbookings_CellDoubleClick);
            // 
            // frm_equipment_bookings_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 320);
            this.Controls.Add(this.label_eqbookingdblclickinfo);
            this.Controls.Add(this.dg_eqbookings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_equipment_bookings_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment Bookings List";
            this.Load += new System.EventHandler(this.frm_equipment_bookings_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_eqbookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_eqbookingdblclickinfo;
        private System.Windows.Forms.DataGridView dg_eqbookings;
    }
}