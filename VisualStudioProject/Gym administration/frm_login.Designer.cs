namespace Gym_administration
{
    partial class frm_login
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
            this.button_accept = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_pleaselogin = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(177, 124);
            this.button_accept.Margin = new System.Windows.Forms.Padding(4);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(133, 28);
            this.button_accept.TabIndex = 2;
            this.button_accept.Text = "Accept";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // txt_username
            // 
            this.txt_username.AcceptsReturn = true;
            this.txt_username.AcceptsTab = true;
            this.txt_username.Location = new System.Drawing.Point(177, 43);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(132, 22);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "admin@ad.min";
            // 
            // txt_password
            // 
            this.txt_password.AcceptsReturn = true;
            this.txt_password.AcceptsTab = true;
            this.txt_password.Location = new System.Drawing.Point(177, 75);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(132, 22);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "admin";
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(39, 43);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(73, 17);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(39, 75);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(69, 17);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // label_pleaselogin
            // 
            this.label_pleaselogin.AutoSize = true;
            this.label_pleaselogin.Location = new System.Drawing.Point(39, 11);
            this.label_pleaselogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pleaselogin.Name = "label_pleaselogin";
            this.label_pleaselogin.Size = new System.Drawing.Size(153, 17);
            this.label_pleaselogin.TabIndex = 5;
            this.label_pleaselogin.Text = "Please log in to access";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(36, 124);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(133, 28);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 174);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_pleaselogin);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.button_accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Administration Login Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_pleaselogin;
        private System.Windows.Forms.Button button_cancel;
    }
}

