namespace M.S.BakersManagmentSystem
{
    partial class GN_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GN_View));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grn_table = new System.Windows.Forms.DataGridView();
            this.btn_grnv_clear = new System.Windows.Forms.Button();
            this.grn_search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grn_search_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.grn_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pur_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grn_arrival_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grn_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.grn_table);
            this.panel1.Controls.Add(this.btn_grnv_clear);
            this.panel1.Controls.Add(this.grn_search_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grn_search_Txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 694);
            this.panel1.TabIndex = 1;
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
            this.grn_no,
            this.st_id,
            this.pur_no,
            this.grn_arrival_qty,
            this.unit_price,
            this.total_amount});
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
            // btn_grnv_clear
            // 
            this.btn_grnv_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_grnv_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_grnv_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grnv_clear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grnv_clear.ForeColor = System.Drawing.Color.White;
            this.btn_grnv_clear.Location = new System.Drawing.Point(1191, 10);
            this.btn_grnv_clear.Name = "btn_grnv_clear";
            this.btn_grnv_clear.Size = new System.Drawing.Size(111, 37);
            this.btn_grnv_clear.TabIndex = 128;
            this.btn_grnv_clear.Text = "Clear";
            this.btn_grnv_clear.UseVisualStyleBackColor = false;
            this.btn_grnv_clear.Click += new System.EventHandler(this.btn_grnv_clear_Click);
            // 
            // grn_search_btn
            // 
            this.grn_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grn_search_btn.BackColor = System.Drawing.Color.Transparent;
            this.grn_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grn_search_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grn_search_btn.ForeColor = System.Drawing.Color.White;
            this.grn_search_btn.Location = new System.Drawing.Point(1076, 10);
            this.grn_search_btn.Name = "grn_search_btn";
            this.grn_search_btn.Size = new System.Drawing.Size(109, 37);
            this.grn_search_btn.TabIndex = 127;
            this.grn_search_btn.Text = "Search";
            this.grn_search_btn.UseVisualStyleBackColor = false;
            this.grn_search_btn.Click += new System.EventHandler(this.grn_search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(683, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "GRN No";
            // 
            // grn_search_Txt
            // 
            this.grn_search_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grn_search_Txt.BackColor = System.Drawing.Color.White;
            this.grn_search_Txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grn_search_Txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grn_search_Txt.Location = new System.Drawing.Point(807, 16);
            this.grn_search_Txt.Name = "grn_search_Txt";
            this.grn_search_Txt.Size = new System.Drawing.Size(241, 25);
            this.grn_search_Txt.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "GOOD RECIVED NOTES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1308, 10);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(111, 37);
            this.btn_refresh.TabIndex = 130;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // grn_no
            // 
            this.grn_no.DataPropertyName = "GRN_No";
            this.grn_no.HeaderText = "GRN No";
            this.grn_no.Name = "grn_no";
            this.grn_no.ReadOnly = true;
            // 
            // st_id
            // 
            this.st_id.DataPropertyName = "ST_ID";
            this.st_id.HeaderText = "Stock ID";
            this.st_id.Name = "st_id";
            this.st_id.ReadOnly = true;
            // 
            // pur_no
            // 
            this.pur_no.DataPropertyName = "Pur_No";
            this.pur_no.HeaderText = "PO No";
            this.pur_no.Name = "pur_no";
            this.pur_no.ReadOnly = true;
            // 
            // grn_arrival_qty
            // 
            this.grn_arrival_qty.DataPropertyName = "GRN_Arrival_Qty";
            this.grn_arrival_qty.HeaderText = "Arrival Qty";
            this.grn_arrival_qty.Name = "grn_arrival_qty";
            this.grn_arrival_qty.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.DataPropertyName = "Unit_Price";
            this.unit_price.HeaderText = "Unit Price";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // total_amount
            // 
            this.total_amount.DataPropertyName = "Total_Amount";
            this.total_amount.HeaderText = "Total Amount";
            this.total_amount.Name = "total_amount";
            this.total_amount.ReadOnly = true;
            // 
            // GN_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1470, 718);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GN_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grn_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grn_search_Txt;
        private System.Windows.Forms.Button btn_grnv_clear;
        private System.Windows.Forms.Button grn_search_btn;
        private System.Windows.Forms.DataGridView grn_table;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn grn_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pur_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn grn_arrival_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_amount;
    }
}