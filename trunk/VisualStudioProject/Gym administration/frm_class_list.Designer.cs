namespace Gym_administration
{
    partial class frm_class_list
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
            this.button_addclass = new System.Windows.Forms.Button();
            this.label_classname = new System.Windows.Forms.Label();
            this.txt_classname = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.dg_classes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // button_addclass
            // 
            this.button_addclass.Location = new System.Drawing.Point(504, 31);
            this.button_addclass.Margin = new System.Windows.Forms.Padding(4);
            this.button_addclass.Name = "button_addclass";
            this.button_addclass.Size = new System.Drawing.Size(100, 28);
            this.button_addclass.TabIndex = 22;
            this.button_addclass.Text = "Add Class";
            this.button_addclass.UseVisualStyleBackColor = true;
            this.button_addclass.Click += new System.EventHandler(this.button_addclass_Click);
            // 
            // label_classname
            // 
            this.label_classname.AutoSize = true;
            this.label_classname.Location = new System.Drawing.Point(12, 15);
            this.label_classname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_classname.Name = "label_classname";
            this.label_classname.Size = new System.Drawing.Size(83, 17);
            this.label_classname.TabIndex = 21;
            this.label_classname.Text = "Class Name";
            // 
            // txt_classname
            // 
            this.txt_classname.Location = new System.Drawing.Point(15, 34);
            this.txt_classname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(235, 22);
            this.txt_classname.TabIndex = 20;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(259, 31);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 28);
            this.button_search.TabIndex = 19;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dg_classes
            // 
            this.dg_classes.AllowUserToAddRows = false;
            this.dg_classes.AllowUserToDeleteRows = false;
            this.dg_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_classes.Location = new System.Drawing.Point(16, 66);
            this.dg_classes.Margin = new System.Windows.Forms.Padding(4);
            this.dg_classes.Name = "dg_classes";
            this.dg_classes.Size = new System.Drawing.Size(588, 300);
            this.dg_classes.TabIndex = 18;
            this.dg_classes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_classes_CellDoubleClick);
            // 
            // frm_class_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 380);
            this.Controls.Add(this.button_addclass);
            this.Controls.Add(this.label_classname);
            this.Controls.Add(this.txt_classname);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dg_classes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_class_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class list";
            this.Load += new System.EventHandler(this.frm_class_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_classes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addclass;
        private System.Windows.Forms.Label label_classname;
        private System.Windows.Forms.TextBox txt_classname;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView dg_classes;
    }
}