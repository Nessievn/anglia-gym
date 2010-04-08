namespace Gym_administration
{
    partial class frm_add_payment
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
            this.button_addpayment = new System.Windows.Forms.Button();
            this.label_amount = new System.Windows.Forms.Label();
            this.txt_details = new System.Windows.Forms.TextBox();
            this.label_details = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.MaskedTextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button_addpayment
            // 
            this.button_addpayment.Location = new System.Drawing.Point(253, 204);
            this.button_addpayment.Margin = new System.Windows.Forms.Padding(4);
            this.button_addpayment.Name = "button_addpayment";
            this.button_addpayment.Size = new System.Drawing.Size(120, 28);
            this.button_addpayment.TabIndex = 0;
            this.button_addpayment.Text = "Add Payment";
            this.button_addpayment.UseVisualStyleBackColor = true;
            this.button_addpayment.Click += new System.EventHandler(this.button_addpayment_Click);
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(17, 15);
            this.label_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(60, 17);
            this.label_amount.TabIndex = 2;
            this.label_amount.Text = "Amount:";
            // 
            // txt_details
            // 
            this.txt_details.Location = new System.Drawing.Point(80, 47);
            this.txt_details.Margin = new System.Windows.Forms.Padding(4);
            this.txt_details.Multiline = true;
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(292, 137);
            this.txt_details.TabIndex = 3;
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Location = new System.Drawing.Point(16, 50);
            this.label_details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(55, 17);
            this.label_details.TabIndex = 4;
            this.label_details.Text = "Details:";
            // 
            // txt_date
            // 
            this.txt_date.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_date.Location = new System.Drawing.Point(80, 201);
            this.txt_date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_date.Mask = "00/00/0000";
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(132, 22);
            this.txt_date.TabIndex = 8;
            this.txt_date.ValidatingType = typeof(System.DateTime);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(17, 204);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(42, 17);
            this.label_date.TabIndex = 9;
            this.label_date.Text = "Date:";
            // 
            // txt_amount
            // 
            this.txt_amount.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_amount.Location = new System.Drawing.Point(80, 15);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_amount.Mask = "0000.00";
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(132, 22);
            this.txt_amount.TabIndex = 10;
            // 
            // frm_add_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 247);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_details);
            this.Controls.Add(this.txt_details);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.button_addpayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_add_payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Payment";
            this.Load += new System.EventHandler(this.frm_add_payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addpayment;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.TextBox txt_details;
        private System.Windows.Forms.Label label_details;
        private System.Windows.Forms.MaskedTextBox txt_date;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.MaskedTextBox txt_amount;
    }
}