namespace Gym_administration
{
    partial class frm_class_instance_list
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
            this.label_classname = new System.Windows.Forms.Label();
            this.txt_classname = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.dg_classes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // label_classname
            // 
            this.label_classname.AutoSize = true;
            this.label_classname.Location = new System.Drawing.Point(12, 14);
            this.label_classname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_classname.Name = "label_classname";
            this.label_classname.Size = new System.Drawing.Size(83, 17);
            this.label_classname.TabIndex = 25;
            this.label_classname.Text = "Class Name";
            // 
            // txt_classname
            // 
            this.txt_classname.Location = new System.Drawing.Point(15, 33);
            this.txt_classname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(235, 22);
            this.txt_classname.TabIndex = 24;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(259, 30);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 28);
            this.button_search.TabIndex = 23;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dg_classes
            // 
            this.dg_classes.AllowUserToAddRows = false;
            this.dg_classes.AllowUserToDeleteRows = false;
            this.dg_classes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_classes.Location = new System.Drawing.Point(16, 65);
            this.dg_classes.Margin = new System.Windows.Forms.Padding(4);
            this.dg_classes.Name = "dg_classes";
            this.dg_classes.RowTemplate.Height = 24;
            this.dg_classes.Size = new System.Drawing.Size(1044, 314);
            this.dg_classes.TabIndex = 22;
            this.dg_classes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_classes_CellDoubleClick);
            // 
            // frm_class_instance_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 394);
            this.Controls.Add(this.label_classname);
            this.Controls.Add(this.txt_classname);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dg_classes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_class_instance_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Arrangements list";
            this.Load += new System.EventHandler(this.frm_class_instance_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_classes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_classname;
        private System.Windows.Forms.TextBox txt_classname;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView dg_classes;
    }
}