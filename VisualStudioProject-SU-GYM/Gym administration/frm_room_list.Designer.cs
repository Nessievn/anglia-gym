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
            this.label_roomname = new System.Windows.Forms.Label();
            this.txt_roomname = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.dg_rooms = new System.Windows.Forms.DataGridView();
            this.button_addroom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label_roomname
            // 
            this.label_roomname.AutoSize = true;
            this.label_roomname.Location = new System.Drawing.Point(9, 9);
            this.label_roomname.Name = "label_roomname";
            this.label_roomname.Size = new System.Drawing.Size(66, 13);
            this.label_roomname.TabIndex = 16;
            this.label_roomname.Text = "Room Name";
            // 
            // txt_roomname
            // 
            this.txt_roomname.Location = new System.Drawing.Point(11, 25);
            this.txt_roomname.Name = "txt_roomname";
            this.txt_roomname.Size = new System.Drawing.Size(177, 20);
            this.txt_roomname.TabIndex = 1;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(194, 22);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dg_rooms
            // 
            this.dg_rooms.AllowUserToAddRows = false;
            this.dg_rooms.AllowUserToDeleteRows = false;
            this.dg_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_rooms.Location = new System.Drawing.Point(12, 51);
            this.dg_rooms.Name = "dg_rooms";
            this.dg_rooms.RowTemplate.Height = 24;
            this.dg_rooms.Size = new System.Drawing.Size(441, 244);
            this.dg_rooms.TabIndex = 4;
            this.dg_rooms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_rooms_CellDoubleClick);
            // 
            // button_addroom
            // 
            this.button_addroom.Location = new System.Drawing.Point(378, 22);
            this.button_addroom.Name = "button_addroom";
            this.button_addroom.Size = new System.Drawing.Size(75, 23);
            this.button_addroom.TabIndex = 3;
            this.button_addroom.Text = "Add Room";
            this.button_addroom.UseVisualStyleBackColor = true;
            this.button_addroom.Click += new System.EventHandler(this.button_addroom_Click);
            // 
            // frm_room_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 308);
            this.Controls.Add(this.button_addroom);
            this.Controls.Add(this.label_roomname);
            this.Controls.Add(this.txt_roomname);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dg_rooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_room_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room list";
            ((System.ComponentModel.ISupportInitialize)(this.dg_rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_roomname;
        private System.Windows.Forms.TextBox txt_roomname;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridView dg_rooms;
        private System.Windows.Forms.Button button_addroom;
    }
}