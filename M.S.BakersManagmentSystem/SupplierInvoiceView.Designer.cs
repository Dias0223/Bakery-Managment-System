namespace M.S.BakersManagmentSystem
{
    partial class SupplierInvoiceView
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
            this.invoice_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grn_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.si_total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.invoice_id,
            this.grn_no,
            this.sup_id,
            this.si_date,
            this.si_total_amount});
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
            this.label2.Size = new System.Drawing.Size(267, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "SUPPLIER INVOICE HISTORY";
            // 
            // invoice_id
            // 
            this.invoice_id.DataPropertyName = "Invoice_ID";
            this.invoice_id.HeaderText = "Invoice ID";
            this.invoice_id.Name = "invoice_id";
            this.invoice_id.ReadOnly = true;
            // 
            // grn_no
            // 
            this.grn_no.DataPropertyName = "GRN_No";
            this.grn_no.HeaderText = "GRN No";
            this.grn_no.Name = "grn_no";
            this.grn_no.ReadOnly = true;
            // 
            // sup_id
            // 
            this.sup_id.DataPropertyName = "Sup_ID";
            this.sup_id.HeaderText = "Sup ID";
            this.sup_id.Name = "sup_id";
            this.sup_id.ReadOnly = true;
            // 
            // si_date
            // 
            this.si_date.DataPropertyName = "SI_Date";
            this.si_date.HeaderText = "SI Date";
            this.si_date.Name = "si_date";
            this.si_date.ReadOnly = true;
            // 
            // si_total_amount
            // 
            this.si_total_amount.DataPropertyName = "SI_Total_Amount";
            this.si_total_amount.HeaderText = "SI Total Amount";
            this.si_total_amount.Name = "si_total_amount";
            this.si_total_amount.ReadOnly = true;
            // 
            // SupplierInvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1470, 718);
            this.Controls.Add(this.panel1);
            this.Name = "SupplierInvoiceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierInvoiceView";
            this.Load += new System.EventHandler(this.SupplierInvoiceView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grn_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grn_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grn_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn sup_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_total_amount;
    }
}