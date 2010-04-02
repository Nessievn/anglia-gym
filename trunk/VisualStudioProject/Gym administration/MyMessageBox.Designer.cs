namespace Gym_administration
{
    partial class MyMessageBox
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
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(167, 81);
            this.button_2.Margin = new System.Windows.Forms.Padding(4);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(99, 31);
            this.button_2.TabIndex = 8;
            this.button_2.UseVisualStyleBackColor = true;
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(274, 81);
            this.button_3.Margin = new System.Windows.Forms.Padding(4);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(99, 31);
            this.button_3.TabIndex = 7;
            this.button_3.UseVisualStyleBackColor = true;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(33, 31);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(0, 17);
            this.label_Message.TabIndex = 10;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 124);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Label label_Message;
    }
}