﻿namespace Gym_administration
{
    partial class frm_payment_list
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
            this.button_addpayments = new System.Windows.Forms.Button();
            this.dg_payments = new System.Windows.Forms.DataGridView();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_payments)).BeginInit();
            this.SuspendLayout();
            // 
            // button_addpayments
            // 
            this.button_addpayments.Location = new System.Drawing.Point(751, 272);
            this.button_addpayments.Name = "button_addpayments";
            this.button_addpayments.Size = new System.Drawing.Size(125, 23);
            this.button_addpayments.TabIndex = 0;
            this.button_addpayments.Text = "Add payments";
            this.button_addpayments.UseVisualStyleBackColor = true;
            this.button_addpayments.Click += new System.EventHandler(this.button_addpayments_Click);
            // 
            // dg_payments
            // 
            this.dg_payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_payments.Location = new System.Drawing.Point(12, 12);
            this.dg_payments.Name = "dg_payments";
            this.dg_payments.RowTemplate.Height = 24;
            this.dg_payments.Size = new System.Drawing.Size(864, 254);
            this.dg_payments.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(12, 272);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(125, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // frm_payment_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 307);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.dg_payments);
            this.Controls.Add(this.button_addpayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_payment_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)(this.dg_payments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_addpayments;
        private System.Windows.Forms.DataGridView dg_payments;
        private System.Windows.Forms.Button button_close;
    }
}