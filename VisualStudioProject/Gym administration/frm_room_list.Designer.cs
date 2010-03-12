namespace Gym_administration
{
    partial class frm_room_list
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_roomname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dg_rooms = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Room Name";
            // 
            // txt_roomname
            // 
            this.txt_roomname.Location = new System.Drawing.Point(11, 25);
            this.txt_roomname.Name = "txt_roomname";
            this.txt_roomname.Size = new System.Drawing.Size(177, 20);
            this.txt_roomname.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_rooms
            // 
            this.dg_rooms.AllowUserToAddRows = false;
            this.dg_rooms.AllowUserToDeleteRows = false;
            this.dg_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rooms.Location = new System.Drawing.Point(12, 51);
            this.dg_rooms.Name = "dg_rooms";
            this.dg_rooms.Size = new System.Drawing.Size(441, 244);
            this.dg_rooms.TabIndex = 13;
            this.dg_rooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_rooms_CellContentClick);
            this.dg_rooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_rooms_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add Room";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_room_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 308);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_roomname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_rooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_room_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room list";
            this.Load += new System.EventHandler(this.frm_room_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_roomname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_rooms;
        private System.Windows.Forms.Button button2;
    }
}