namespace M.S.BakersManagmentSystem
{
    partial class PaymentView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grn_table = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pay_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grn_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.grn_table);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 694);
            this.panel1.TabIndex = 2;
            // 
            // grn_table
            // 
            this.grn_table.AllowUserToAddRows = false;
            this.grn_table.AllowUserToDeleteRows = false;
            this.grn_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grn_table.BackgroundColor = System.Drawing.Color.White;
            this.grn_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grn_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grn_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grn_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grn_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pay_id,
            this.invoice_id,
            this.pay_date,
            this.pay_amount,
            this.unit_price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grn_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.grn_table.EnableHeadersVisualStyles = false;
            this.grn_table.Location = new System.Drawing.Point(26, 64);
            this.grn_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grn_table.Name = "grn_table";
            this.grn_table.ReadOnly = true;
            this.grn_table.RowHeadersVisible = false;
            this.grn_table.RowTemplate.Height = 24;
            this.grn_table.Size = new System.Drawing.Size(1393, 610);
            this.grn_table.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "PAYMENT HISTORY";
            // 
            // pay_id
            // 
            this.pay_id.DataPropertyName = "Pay_ID";
            this.pay_id.HeaderText = "Pay ID";
            this.pay_id.Name = "pay_id";
            this.pay_id.ReadOnly = true;
            // 
            // invoice_id
            // 
            this.invoice_id.DataPropertyName = "Invoice_ID";
            this.invoice_id.HeaderText = "Invoice ID";
            this.invoice_id.Name = "invoice_id";
            this.invoice_id.ReadOnly = true;
            // 
            // pay_date
            // 
            this.pay_date.DataPropertyName = "Pay_Date";
            this.pay_date.HeaderText = "Pay Date";
            this.pay_date.Name = "pay_date";
            this.pay_date.ReadOnly = true;
            // 
            // pay_amount
            // 
            this.pay_amount.DataPropertyName = "Pay_Amount";
            this.pay_amount.HeaderText = "Pay Amount";
            this.pay_amount.Name = "pay_amount";
            this.pay_amount.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.DataPropertyName = "Pay_Description";
            this.unit_price.HeaderText = "Comment";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1470, 718);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentView";
            this.Load += new System.EventHandler(this.PaymentView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grn_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grn_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
    }
}