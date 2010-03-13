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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_classdesc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_classname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_personal = new System.Windows.Forms.RadioButton();
            this.rd_group = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 165;
            this.label2.Text = "Class Description";
            // 
            // txt_classdesc
            // 
            this.txt_classdesc.Location = new System.Drawing.Point(15, 89);
            this.txt_classdesc.Multiline = true;
            this.txt_classdesc.Name = "txt_classdesc";
            this.txt_classdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_classdesc.Size = new System.Drawing.Size(297, 136);
            this.txt_classdesc.TabIndex = 164;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 26);
            this.button2.TabIndex = 163;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 162;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_classname
            // 
            this.txt_classname.Location = new System.Drawing.Point(15, 50);
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(138, 20);
            this.txt_classname.TabIndex = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 160;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 157;
            this.label1.Text = "Class Info:";
            // 
            // rd_personal
            // 
            this.rd_personal.AutoSize = true;
            this.rd_personal.Location = new System.Drawing.Point(242, 36);
            this.rd_personal.Name = "rd_personal";
            this.rd_personal.Size = new System.Drawing.Size(66, 17);
            this.rd_personal.TabIndex = 166;
            this.rd_personal.TabStop = true;
            this.rd_personal.Text = "Personal";
            this.rd_personal.UseVisualStyleBackColor = true;
            // 
            // rd_group
            // 
            this.rd_group.AutoSize = true;
            this.rd_group.Location = new System.Drawing.Point(242, 59);
            this.rd_group.Name = "rd_group";
            this.rd_group.Size = new System.Drawing.Size(54, 17);
            this.rd_group.TabIndex = 167;
            this.rd_group.TabStop = true;
            this.rd_group.Text = "Group";
            this.rd_group.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 26);
            this.button3.TabIndex = 168;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 268);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rd_group);
            this.Controls.Add(this.rd_personal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_classdesc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_classname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Form";
            this.Load += new System.EventHandler(this.frm_class_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_classdesc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_classname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_personal;
        private System.Windows.Forms.RadioButton rd_group;
        private System.Windows.Forms.Button button3;
    }
}