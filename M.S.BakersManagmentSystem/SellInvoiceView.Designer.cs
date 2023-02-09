namespace M.S.BakersManagmentSystem
{
    partial class SellInvoiceView
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
            this.si_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.si_id,
            this.dp_id,
            this.sale_date,
            this.sale_qty,
            this.sale_unit_price,
            this.sale_amount});
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
            this.label2.Size = new System.Drawing.Size(223, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "SELL INVOICE HISTORY";
            // 
            // si_id
            // 
            this.si_id.DataPropertyName = "SI_ID";
            this.si_id.HeaderText = "SI ID";
            this.si_id.Name = "si_id";
            this.si_id.ReadOnly = true;
            // 
            // dp_id
            // 
            this.dp_id.DataPropertyName = "DP_ID";
            this.dp_id.HeaderText = "DP ID";
            this.dp_id.Name = "dp_id";
            this.dp_id.ReadOnly = true;
            // 
            // sale_date
            // 
            this.sale_date.DataPropertyName = "Sale_Date";
            this.sale_date.HeaderText = "Sale Date";
            this.sale_date.Name = "sale_date";
            this.sale_date.ReadOnly = true;
            // 
            // sale_qty
            // 
            this.sale_qty.DataPropertyName = "Sale_Qty";
            this.sale_qty.HeaderText = "Sale Qty";
            this.sale_qty.Name = "sale_qty";
            this.sale_qty.ReadOnly = true;
            // 
            // sale_unit_price
            // 
            this.sale_unit_price.DataPropertyName = "Sale_Unit_Price";
            this.sale_unit_price.HeaderText = "Sale Unit Price";
            this.sale_unit_price.Name = "sale_unit_price";
            this.sale_unit_price.ReadOnly = true;
            // 
            // sale_amount
            // 
            this.sale_amount.DataPropertyName = "Sale_Total_Amount";
            this.sale_amount.HeaderText = "Sale Total Amount";
            this.sale_amount.Name = "sale_amount";
            this.sale_amount.ReadOnly = true;
            // 
            // SellInvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1470, 718);
            this.Controls.Add(this.panel1);
            this.Name = "SellInvoiceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellInvoiceView";
            this.Load += new System.EventHandler(this.SellInvoiceView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grn_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grn_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn si_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_amount;
    }
}