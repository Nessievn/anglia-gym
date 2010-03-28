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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_classname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_classes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_classes)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Add Class";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Class Name";
            // 
            // txt_classname
            // 
            this.txt_classname.Location = new System.Drawing.Point(11, 28);
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(177, 20);
            this.txt_classname.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_classes
            // 
            this.dg_classes.AllowUserToAddRows = false;
            this.dg_classes.AllowUserToDeleteRows = false;
            this.dg_classes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_classes.Location = new System.Drawing.Point(12, 54);
            this.dg_classes.Name = "dg_classes";
            this.dg_classes.Size = new System.Drawing.Size(441, 244);
            this.dg_classes.TabIndex = 18;
            this.dg_classes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_classes_CellDoubleClick);
            // 
            // frm_class_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_classname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_classes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_class_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class list";
            this.Load += new System.EventHandler(this.frm_class_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_classes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_classname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_classes;
    }
}