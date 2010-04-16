namespace Gym_administration
{
    partial class frm_room
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.txt_roomsize = new System.Windows.Forms.TextBox();
            this.label_roomsize = new System.Windows.Forms.Label();
            this.txt_roomname = new System.Windows.Forms.TextBox();
            this.label_roomname = new System.Windows.Forms.Label();
            this.label_roominfo = new System.Windows.Forms.Label();
            this.txt_roomdesc = new System.Windows.Forms.TextBox();
            this.label_roomdesc = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(176, 334);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(116, 32);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(300, 334);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(116, 32);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // txt_roomsize
            // 
            this.txt_roomsize.Location = new System.Drawing.Point(20, 111);
            this.txt_roomsize.Margin = new System.Windows.Forms.Padding(4);
            this.txt_roomsize.Name = "txt_roomsize";
            this.txt_roomsize.Size = new System.Drawing.Size(183, 22);
            this.txt_roomsize.TabIndex = 2;
            // 
            // label_roomsize
            // 
            this.label_roomsize.AutoSize = true;
            this.label_roomsize.Location = new System.Drawing.Point(16, 94);
            this.label_roomsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_roomsize.Name = "label_roomsize";
            this.label_roomsize.Size = new System.Drawing.Size(35, 17);
            this.label_roomsize.TabIndex = 112;
            this.label_roomsize.Text = "Size";
            // 
            // txt_roomname
            // 
            this.txt_roomname.Location = new System.Drawing.Point(20, 62);
            this.txt_roomname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_roomname.Name = "txt_roomname";
            this.txt_roomname.Size = new System.Drawing.Size(183, 22);
            this.txt_roomname.TabIndex = 1;
            // 
            // label_roomname
            // 
            this.label_roomname.AutoSize = true;
            this.label_roomname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomname.Location = new System.Drawing.Point(16, 44);
            this.label_roomname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_roomname.Name = "label_roomname";
            this.label_roomname.Size = new System.Drawing.Size(49, 17);
            this.label_roomname.TabIndex = 110;
            this.label_roomname.Text = "Name";
            // 
            // label_roominfo
            // 
            this.label_roominfo.AutoSize = true;
            this.label_roominfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roominfo.Location = new System.Drawing.Point(16, 11);
            this.label_roominfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_roominfo.Name = "label_roominfo";
            this.label_roominfo.Size = new System.Drawing.Size(110, 20);
            this.label_roominfo.TabIndex = 105;
            this.label_roominfo.Text = "ROOM INFO:";
            // 
            // txt_roomdesc
            // 
            this.txt_roomdesc.Location = new System.Drawing.Point(20, 159);
            this.txt_roomdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_roomdesc.Multiline = true;
            this.txt_roomdesc.Name = "txt_roomdesc";
            this.txt_roomdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_roomdesc.Size = new System.Drawing.Size(395, 166);
            this.txt_roomdesc.TabIndex = 3;
            // 
            // label_roomdesc
            // 
            this.label_roomdesc.AutoSize = true;
            this.label_roomdesc.Location = new System.Drawing.Point(16, 139);
            this.label_roomdesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_roomdesc.Name = "label_roomdesc";
            this.label_roomdesc.Size = new System.Drawing.Size(120, 17);
            this.label_roomdesc.TabIndex = 156;
            this.label_roomdesc.Text = "Room Description";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(21, 334);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(116, 32);
            this.button_remove.TabIndex = 4;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // frm_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 377);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label_roomdesc);
            this.Controls.Add(this.txt_roomdesc);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.txt_roomsize);
            this.Controls.Add(this.label_roomsize);
            this.Controls.Add(this.txt_roomname);
            this.Controls.Add(this.label_roomname);
            this.Controls.Add(this.label_roominfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Form";
            this.Load += new System.EventHandler(this.frm_room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox txt_roomsize;
        private System.Windows.Forms.Label label_roomsize;
        private System.Windows.Forms.TextBox txt_roomname;
        private System.Windows.Forms.Label label_roomname;
        private System.Windows.Forms.Label label_roominfo;
        private System.Windows.Forms.TextBox txt_roomdesc;
        private System.Windows.Forms.Label label_roomdesc;
        private System.Windows.Forms.Button button_remove;

    }
}