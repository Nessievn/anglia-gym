namespace Gym_administration
{
    partial class frm_login_options
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_old = new System.Windows.Forms.TextBox();
            this.txt_new = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_repnew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old password:";
            // 
            // txt_old
            // 
            this.txt_old.Location = new System.Drawing.Point(111, 18);
            this.txt_old.Name = "txt_old";
            this.txt_old.PasswordChar = '*';
            this.txt_old.Size = new System.Drawing.Size(151, 20);
            this.txt_old.TabIndex = 2;
            // 
            // txt_new
            // 
            this.txt_new.Location = new System.Drawing.Point(111, 44);
            this.txt_new.Name = "txt_new";
            this.txt_new.PasswordChar = '*';
            this.txt_new.Size = new System.Drawing.Size(151, 20);
            this.txt_new.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New password:";
            // 
            // txt_repnew
            // 
            this.txt_repnew.Location = new System.Drawing.Point(111, 70);
            this.txt_repnew.Name = "txt_repnew";
            this.txt_repnew.PasswordChar = '*';
            this.txt_repnew.Size = new System.Drawing.Size(151, 20);
            this.txt_repnew.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repeat password:";
            // 
            // frm_login_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 140);
            this.Controls.Add(this.txt_repnew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_new);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_old);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_login_options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_old;
        private System.Windows.Forms.TextBox txt_new;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_repnew;
        private System.Windows.Forms.Label label3;
    }
}