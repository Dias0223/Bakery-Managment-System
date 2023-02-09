namespace M.S.BakersManagmentSystem
{
    partial class PurchaseOrderView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pur_Table = new System.Windows.Forms.DataGridView();
            this.pur_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rm_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pur_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pur_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pur_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pur_Table);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 578);
            this.panel2.TabIndex = 4;
            // 
            // pur_Table
            // 
            this.pur_Table.AllowUserToAddRows = false;
            this.pur_Table.AllowUserToDeleteRows = false;
            this.pur_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pur_Table.BackgroundColor = System.Drawing.Color.White;
            this.pur_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pur_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pur_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pur_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pur_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pur_no,
            this.rm_no,
            this.sup_id,
            this.pur_date,
            this.pur_qty});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pur_Table.DefaultCellStyle = dataGridViewCellStyle4;
            this.pur_Table.EnableHeadersVisualStyles = false;
            this.pur_Table.Location = new System.Drawing.Point(21, 64);
            this.pur_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pur_Table.Name = "pur_Table";
            this.pur_Table.ReadOnly = true;
            this.pur_Table.RowHeadersVisible = false;
            this.pur_Table.RowTemplate.Height = 24;
            this.pur_Table.Size = new System.Drawing.Size(931, 488);
            this.pur_Table.TabIndex = 96;
            // 
            // pur_no
            // 
            this.pur_no.DataPropertyName = "Pur_No";
            this.pur_no.HeaderText = "Purchase No";
            this.pur_no.Name = "pur_no";
            this.pur_no.ReadOnly = true;
            // 
            // rm_no
            // 
            this.rm_no.DataPropertyName = "RM_No";
            this.rm_no.HeaderText = "RM No";
            this.rm_no.Name = "rm_no";
            this.rm_no.ReadOnly = true;
            // 
            // sup_id
            // 
            this.sup_id.DataPropertyName = "Sup_ID";
            this.sup_id.HeaderText = "Supplier ID";
            this.sup_id.Name = "sup_id";
            this.sup_id.ReadOnly = true;
            // 
            // pur_date
            // 
            this.pur_date.DataPropertyName = "Purchases_Date";
            this.pur_date.HeaderText = "Date";
            this.pur_date.Name = "pur_date";
            this.pur_date.ReadOnly = true;
            // 
            // pur_qty
            // 
            this.pur_qty.DataPropertyName = "Purchases_Qty";
            this.pur_qty.HeaderText = "Purchase Qty";
            this.pur_qty.Name = "pur_qty";
            this.pur_qty.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "PURCHASE ORDER INFORMATION ";
            // 
            // PurchaseOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(996, 590);
            this.Controls.Add(this.panel2);
            this.Name = "PurchaseOrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrderView";
            this.Load += new System.EventHandler(this.PurchaseOrderView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pur_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView pur_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn pur_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn rm_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn sup_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pur_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pur_qty;
        private System.Windows.Forms.Label label5;
    }
}