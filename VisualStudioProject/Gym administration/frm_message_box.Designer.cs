namespace Gym_administration
{
    partial class frm_message_box
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
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.counter1 = new System.Windows.Forms.NumericUpDown();
            this.label_counter1 = new System.Windows.Forms.Label();
            this.label_counter2 = new System.Windows.Forms.Label();
            this.label_borrowedcounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.counter1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(60, 81);
            this.button_1.Margin = new System.Windows.Forms.Padding(4);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(99, 31);
            this.button_1.TabIndex = 9;
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(167, 81);
            this.button_2.Margin = new System.Windows.Forms.Padding(4);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(99, 31);
            this.button_2.TabIndex = 8;
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(274, 81);
            this.button_3.Margin = new System.Windows.Forms.Padding(4);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(99, 31);
            this.button_3.TabIndex = 7;
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(33, 31);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(0, 17);
            this.label_Message.TabIndex = 10;
            // 
            // counter1
            // 
            this.counter1.Location = new System.Drawing.Point(60, 31);
            this.counter1.Name = "counter1";
            this.counter1.ReadOnly = true;
            this.counter1.Size = new System.Drawing.Size(116, 22);
            this.counter1.TabIndex = 207;
            this.counter1.ValueChanged += new System.EventHandler(this.counter1_ValueChanged);
            // 
            // label_counter1
            // 
            this.label_counter1.AutoSize = true;
            this.label_counter1.Location = new System.Drawing.Point(41, 9);
            this.label_counter1.Name = "label_counter1";
            this.label_counter1.Size = new System.Drawing.Size(118, 17);
            this.label_counter1.TabIndex = 208;
            this.label_counter1.Text = "Amount to return:";
            // 
            // label_counter2
            // 
            this.label_counter2.AutoSize = true;
            this.label_counter2.Location = new System.Drawing.Point(191, 9);
            this.label_counter2.Name = "label_counter2";
            this.label_counter2.Size = new System.Drawing.Size(183, 17);
            this.label_counter2.TabIndex = 209;
            this.label_counter2.Text = "Amount Remains Borrowed:";
            // 
            // label_borrowedcounter
            // 
            this.label_borrowedcounter.AutoSize = true;
            this.label_borrowedcounter.Location = new System.Drawing.Point(302, 31);
            this.label_borrowedcounter.Name = "label_borrowedcounter";
            this.label_borrowedcounter.Size = new System.Drawing.Size(16, 17);
            this.label_borrowedcounter.TabIndex = 210;
            this.label_borrowedcounter.Text = "0";
            this.label_borrowedcounter.Visible = false;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 124);
            this.Controls.Add(this.label_borrowedcounter);
            this.Controls.Add(this.label_counter2);
            this.Controls.Add(this.label_counter1);
            this.Controls.Add(this.counter1);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Messagebox";
            ((System.ComponentModel.ISupportInitialize)(this.counter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.NumericUpDown counter1;
        private System.Windows.Forms.Label label_counter1;
        private System.Windows.Forms.Label label_counter2;
        private System.Windows.Forms.Label label_borrowedcounter;
    }
}