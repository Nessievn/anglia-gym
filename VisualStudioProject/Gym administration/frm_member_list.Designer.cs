namespace Gym_administration
{
    partial class frm_member_list
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
            this.dg_members = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_members)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_members
            // 
            this.dg_members.AllowUserToAddRows = false;
            this.dg_members.AllowUserToDeleteRows = false;
            this.dg_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_members.Location = new System.Drawing.Point(8, 167);
            this.dg_members.Name = "dg_members";
            this.dg_members.Size = new System.Drawing.Size(668, 305);
            this.dg_members.TabIndex = 0;
            this.dg_members.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_members_CellDoubleClick);
            this.dg_members.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_members_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_member_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_members);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_member_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memebers List Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_members)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_members;
        private System.Windows.Forms.Button button1;
    }
}