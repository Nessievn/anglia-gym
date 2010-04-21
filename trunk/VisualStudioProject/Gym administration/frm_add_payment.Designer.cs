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
            this.label_dateformat = new System.Windows.Forms.Label();
            this.cmb_paymentMethod = new System.Windows.Forms.ComboBox();
            this.label_paymentMethod = new System.Windows.Forms.Label();
            this.txt_receiptNumber = new System.Windows.Forms.TextBox();
            this.label_receivedBy = new System.Windows.Forms.Label();
            this.label_receiptNumber = new System.Windows.Forms.Label();
            this.cmb_staff = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_addpayment
            // 
            this.button_addpayment.Location = new System.Drawing.Point(190, 182);
            this.button_addpayment.Name = "button_addpayment";
            this.button_addpayment.Size = new System.Drawing.Size(90, 23);
            this.button_addpayment.TabIndex = 6;
            this.button_addpayment.Text = "Add Payment";
            this.button_addpayment.UseVisualStyleBackColor = true;
            this.button_addpayment.Click += new System.EventHandler(this.button_addpayment_Click);
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(13, 12);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(53, 13);
            this.label_amount.TabIndex = 2;
            this.label_amount.Text = "Amount:";
            // 
            // txt_details
            // 
            this.txt_details.Location = new System.Drawing.Point(60, 115);
            this.txt_details.Multiline = true;
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(220, 42);
            this.txt_details.TabIndex = 4;
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Location = new System.Drawing.Point(13, 115);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(42, 13);
            this.label_details.TabIndex = 4;
            this.label_details.Text = "Details:";
            // 
            // txt_date
            // 
            this.txt_date.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_date.Location = new System.Drawing.Point(60, 184);
            this.txt_date.Mask = "00/00/0000";
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 20);
            this.txt_date.TabIndex = 5;
            this.txt_date.ValidatingType = typeof(System.DateTime);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(13, 187);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(38, 13);
            this.label_date.TabIndex = 9;
            this.label_date.Text = "Date:";
            // 
            // txt_amount
            // 
            this.txt_amount.Culture = new System.Globalization.CultureInfo("en-GB");
            this.txt_amount.Location = new System.Drawing.Point(142, 16);
            this.txt_amount.Mask = "0000.00";
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(60, 20);
            this.txt_amount.TabIndex = 0;
            // 
            // label_dateformat
            // 
            this.label_dateformat.AutoSize = true;
            this.label_dateformat.Location = new System.Drawing.Point(58, 167);
            this.label_dateformat.Name = "label_dateformat";
            this.label_dateformat.Size = new System.Drawing.Size(65, 13);
            this.label_dateformat.TabIndex = 11;
            this.label_dateformat.Text = "dd/mm/yyyy";
            // 
            // cmb_paymentMethod
            // 
            this.cmb_paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_paymentMethod.FormattingEnabled = true;
            this.cmb_paymentMethod.Items.AddRange(new object[] {
            "Card",
            "Cash",
            "Cheque",
            "Bank Transfer"});
            this.cmb_paymentMethod.Location = new System.Drawing.Point(142, 89);
            this.cmb_paymentMethod.Name = "cmb_paymentMethod";
            this.cmb_paymentMethod.Size = new System.Drawing.Size(138, 21);
            this.cmb_paymentMethod.TabIndex = 3;
            // 
            // label_paymentMethod
            // 
            this.label_paymentMethod.AutoSize = true;
            this.label_paymentMethod.Location = new System.Drawing.Point(13, 92);
            this.label_paymentMethod.Name = "label_paymentMethod";
            this.label_paymentMethod.Size = new System.Drawing.Size(90, 13);
            this.label_paymentMethod.TabIndex = 56;
            this.label_paymentMethod.Text = "Payment Method:";
            // 
            // txt_receiptNumber
            // 
            this.txt_receiptNumber.Location = new System.Drawing.Point(142, 41);
            this.txt_receiptNumber.Name = "txt_receiptNumber";
            this.txt_receiptNumber.Size = new System.Drawing.Size(138, 20);
            this.txt_receiptNumber.TabIndex = 1;
            // 
            // label_receivedBy
            // 
            this.label_receivedBy.AutoSize = true;
            this.label_receivedBy.Location = new System.Drawing.Point(13, 67);
            this.label_receivedBy.Name = "label_receivedBy";
            this.label_receivedBy.Size = new System.Drawing.Size(70, 13);
            this.label_receivedBy.TabIndex = 67;
            this.label_receivedBy.Text = "Received by:";
            // 
            // label_receiptNumber
            // 
            this.label_receiptNumber.AutoSize = true;
            this.label_receiptNumber.Location = new System.Drawing.Point(13, 43);
            this.label_receiptNumber.Name = "label_receiptNumber";
            this.label_receiptNumber.Size = new System.Drawing.Size(87, 13);
            this.label_receiptNumber.TabIndex = 68;
            this.label_receiptNumber.Text = "Receipt Number:";
            // 
            // cmb_staff
            // 
            this.cmb_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_staff.FormattingEnabled = true;
            this.cmb_staff.Location = new System.Drawing.Point(142, 65);
            this.cmb_staff.Name = "cmb_staff";
            this.cmb_staff.Size = new System.Drawing.Size(138, 21);
            this.cmb_staff.TabIndex = 2;
            // 
            // frm_add_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 211);
            this.Controls.Add(this.cmb_staff);
            this.Controls.Add(this.label_receiptNumber);
            this.Controls.Add(this.label_receivedBy);
            this.Controls.Add(this.txt_receiptNumber);
            this.Controls.Add(this.cmb_paymentMethod);
            this.Controls.Add(this.label_paymentMethod);
            this.Controls.Add(this.label_dateformat);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_details);
            this.Controls.Add(this.txt_details);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.button_addpayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Label label_dateformat;
        private System.Windows.Forms.ComboBox cmb_paymentMethod;
        private System.Windows.Forms.Label label_paymentMethod;
        private System.Windows.Forms.TextBox txt_receiptNumber;
        private System.Windows.Forms.Label label_receivedBy;
        private System.Windows.Forms.Label label_receiptNumber;
        private System.Windows.Forms.ComboBox cmb_staff;
    }
}