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
            this.button_changepassw = new System.Windows.Forms.Button();
            this.label_oldpassw = new System.Windows.Forms.Label();
            this.txt_oldpassw = new System.Windows.Forms.TextBox();
            this.txt_newpassw = new System.Windows.Forms.TextBox();
            this.label_newpassw = new System.Windows.Forms.Label();
            this.txt_repeatnewpw = new System.Windows.Forms.TextBox();
            this.label_repeatnewp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_changepassw
            // 
            this.button_changepassw.Location = new System.Drawing.Point(148, 129);
            this.button_changepassw.Margin = new System.Windows.Forms.Padding(4);
            this.button_changepassw.Name = "button_changepassw";
            this.button_changepassw.Size = new System.Drawing.Size(164, 28);
            this.button_changepassw.TabIndex = 3;
            this.button_changepassw.Text = "Change password";
            this.button_changepassw.UseVisualStyleBackColor = true;
            this.button_changepassw.Click += new System.EventHandler(this.button_changepassw_Click);
            // 
            // label_oldpassw
            // 
            this.label_oldpassw.AutoSize = true;
            this.label_oldpassw.Location = new System.Drawing.Point(19, 22);
            this.label_oldpassw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_oldpassw.Name = "label_oldpassw";
            this.label_oldpassw.Size = new System.Drawing.Size(98, 17);
            this.label_oldpassw.TabIndex = 1;
            this.label_oldpassw.Text = "Old password:";
            // 
            // txt_oldpassw
            // 
            this.txt_oldpassw.AcceptsTab = true;
            this.txt_oldpassw.Location = new System.Drawing.Point(148, 22);
            this.txt_oldpassw.Margin = new System.Windows.Forms.Padding(4);
            this.txt_oldpassw.Name = "txt_oldpassw";
            this.txt_oldpassw.PasswordChar = '*';
            this.txt_oldpassw.Size = new System.Drawing.Size(200, 22);
            this.txt_oldpassw.TabIndex = 0;
            // 
            // txt_newpassw
            // 
            this.txt_newpassw.AcceptsTab = true;
            this.txt_newpassw.Location = new System.Drawing.Point(148, 54);
            this.txt_newpassw.Margin = new System.Windows.Forms.Padding(4);
            this.txt_newpassw.Name = "txt_newpassw";
            this.txt_newpassw.PasswordChar = '*';
            this.txt_newpassw.Size = new System.Drawing.Size(200, 22);
            this.txt_newpassw.TabIndex = 1;
            // 
            // label_newpassw
            // 
            this.label_newpassw.AutoSize = true;
            this.label_newpassw.Location = new System.Drawing.Point(19, 54);
            this.label_newpassw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_newpassw.Name = "label_newpassw";
            this.label_newpassw.Size = new System.Drawing.Size(103, 17);
            this.label_newpassw.TabIndex = 3;
            this.label_newpassw.Text = "New password:";
            // 
            // txt_repeatnewpw
            // 
            this.txt_repeatnewpw.AcceptsReturn = true;
            this.txt_repeatnewpw.AcceptsTab = true;
            this.txt_repeatnewpw.Location = new System.Drawing.Point(148, 86);
            this.txt_repeatnewpw.Margin = new System.Windows.Forms.Padding(4);
            this.txt_repeatnewpw.Name = "txt_repeatnewpw";
            this.txt_repeatnewpw.PasswordChar = '*';
            this.txt_repeatnewpw.Size = new System.Drawing.Size(200, 22);
            this.txt_repeatnewpw.TabIndex = 2;
            // 
            // label_repeatnewp
            // 
            this.label_repeatnewp.AutoSize = true;
            this.label_repeatnewp.Location = new System.Drawing.Point(19, 86);
            this.label_repeatnewp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_repeatnewp.Name = "label_repeatnewp";
            this.label_repeatnewp.Size = new System.Drawing.Size(122, 17);
            this.label_repeatnewp.TabIndex = 5;
            this.label_repeatnewp.Text = "Repeat password:";
            // 
            // frm_login_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 172);
            this.Controls.Add(this.txt_repeatnewpw);
            this.Controls.Add(this.label_repeatnewp);
            this.Controls.Add(this.txt_newpassw);
            this.Controls.Add(this.label_newpassw);
            this.Controls.Add(this.txt_oldpassw);
            this.Controls.Add(this.label_oldpassw);
            this.Controls.Add(this.button_changepassw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_login_options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_changepassw;
        private System.Windows.Forms.Label label_oldpassw;
        private System.Windows.Forms.TextBox txt_oldpassw;
        private System.Windows.Forms.TextBox txt_newpassw;
        private System.Windows.Forms.Label label_newpassw;
        private System.Windows.Forms.TextBox txt_repeatnewpw;
        private System.Windows.Forms.Label label_repeatnewp;
    }
}