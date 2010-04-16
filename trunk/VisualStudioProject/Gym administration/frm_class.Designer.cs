namespace Gym_administration
{
    partial class frm_class
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
            this.label_classdesc = new System.Windows.Forms.Label();
            this.txt_classdesc = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.txt_classname = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_classinfo = new System.Windows.Forms.Label();
            this.rd_personal = new System.Windows.Forms.RadioButton();
            this.rd_group = new System.Windows.Forms.RadioButton();
            this.button_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_classdesc
            // 
            this.label_classdesc.AutoSize = true;
            this.label_classdesc.Location = new System.Drawing.Point(16, 90);
            this.label_classdesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_classdesc.Name = "label_classdesc";
            this.label_classdesc.Size = new System.Drawing.Size(117, 17);
            this.label_classdesc.TabIndex = 165;
            this.label_classdesc.Text = "Class Description";
            // 
            // txt_classdesc
            // 
            this.txt_classdesc.Location = new System.Drawing.Point(20, 110);
            this.txt_classdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_classdesc.Multiline = true;
            this.txt_classdesc.Name = "txt_classdesc";
            this.txt_classdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_classdesc.Size = new System.Drawing.Size(395, 166);
            this.txt_classdesc.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(20, 284);
            this.button_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(116, 32);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "Cancel";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(300, 284);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(116, 32);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // txt_classname
            // 
            this.txt_classname.Location = new System.Drawing.Point(20, 62);
            this.txt_classname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(183, 22);
            this.txt_classname.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(16, 44);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 17);
            this.label_name.TabIndex = 160;
            this.label_name.Text = "Name";
            // 
            // label_classinfo
            // 
            this.label_classinfo.AutoSize = true;
            this.label_classinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_classinfo.Location = new System.Drawing.Point(16, 11);
            this.label_classinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_classinfo.Name = "label_classinfo";
            this.label_classinfo.Size = new System.Drawing.Size(113, 20);
            this.label_classinfo.TabIndex = 157;
            this.label_classinfo.Text = "CLASS INFO:";
            // 
            // rd_personal
            // 
            this.rd_personal.AutoSize = true;
            this.rd_personal.Location = new System.Drawing.Point(323, 44);
            this.rd_personal.Margin = new System.Windows.Forms.Padding(4);
            this.rd_personal.Name = "rd_personal";
            this.rd_personal.Size = new System.Drawing.Size(85, 21);
            this.rd_personal.TabIndex = 2;
            this.rd_personal.TabStop = true;
            this.rd_personal.Text = "Personal";
            this.rd_personal.UseVisualStyleBackColor = true;
            // 
            // rd_group
            // 
            this.rd_group.AutoSize = true;
            this.rd_group.Location = new System.Drawing.Point(323, 73);
            this.rd_group.Margin = new System.Windows.Forms.Padding(4);
            this.rd_group.Name = "rd_group";
            this.rd_group.Size = new System.Drawing.Size(69, 21);
            this.rd_group.TabIndex = 3;
            this.rd_group.TabStop = true;
            this.rd_group.Text = "Group";
            this.rd_group.UseVisualStyleBackColor = true;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(144, 284);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(116, 32);
            this.button_remove.TabIndex = 5;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // frm_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 330);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.rd_group);
            this.Controls.Add(this.rd_personal);
            this.Controls.Add(this.label_classdesc);
            this.Controls.Add(this.txt_classdesc);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.txt_classname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_classinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Form";
            this.Load += new System.EventHandler(this.frm_class_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_classdesc;
        private System.Windows.Forms.TextBox txt_classdesc;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox txt_classname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_classinfo;
        private System.Windows.Forms.RadioButton rd_personal;
        private System.Windows.Forms.RadioButton rd_group;
        private System.Windows.Forms.Button button_remove;
    }
}