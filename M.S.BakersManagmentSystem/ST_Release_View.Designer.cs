namespace M.S.BakersManagmentSystem
{
    partial class ST_Release_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ST_Release_View));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.grn_table = new System.Windows.Forms.DataGridView();
            this.sr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.re_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.re_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "STOCK RELEASE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.sr_id,
            this.pro_no,
            this.re_qty,
            this.re_date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grn_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.grn_table.EnableHeadersVisualStyles = false;
            this.grn_table.Location = new System.Drawing.Point(27, 65);
            this.grn_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grn_table.Name = "grn_table";
            this.grn_table.ReadOnly = true;
            this.grn_table.RowHeadersVisible = false;
            this.grn_table.RowTemplate.Height = 24;
            this.grn_table.Size = new System.Drawing.Size(1403, 610);
            this.grn_table.TabIndex = 130;
            this.grn_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grn_table_CellContentClick);
            // 
            // sr_id
            // 
            this.sr_id.DataPropertyName = "ST_ID";
            this.sr_id.HeaderText = "SR ID";
            this.sr_id.Name = "sr_id";
            this.sr_id.ReadOnly = true;
            // 
            // pro_no
            // 
            this.pro_no.DataPropertyName = "Pro_No";
            this.pro_no.HeaderText = "Production ID";
            this.pro_no.Name = "pro_no";
            this.pro_no.ReadOnly = true;
            // 
            // re_qty
            // 
            this.re_qty.DataPropertyName = "Release_Qty";
            this.re_qty.HeaderText = "Release Qty";
            this.re_qty.Name = "re_qty";
            this.re_qty.ReadOnly = true;
            // 
            // re_date
            // 
            this.re_date.DataPropertyName = "Release_Date";
            this.re_date.HeaderText = "Release Date";
            this.re_date.Name = "re_date";
            this.re_date.ReadOnly = true;
            // 
            // ST_Release_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1470, 718);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ST_Release_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grn_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grn_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn sr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn re_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn re_date;
    }
}