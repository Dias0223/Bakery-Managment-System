namespace M.S.BakersManagmentSystem
{
    partial class ProductionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.prod_table = new System.Windows.Forms.DataGridView();
            this.pro_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_damage_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.prod_table);
            this.panel1.Controls.Add(this.datetimepicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 694);
            this.panel1.TabIndex = 1;
            // 
            // datetimepicker
            // 
            this.datetimepicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.datetimepicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.datetimepicker.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepicker.Location = new System.Drawing.Point(978, 15);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(322, 30);
            this.datetimepicker.TabIndex = 112;
            this.datetimepicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(823, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 87;
            this.label3.Text = "Production ID";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1322, 14);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(105, 35);
            this.btn_refresh.TabIndex = 86;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 23);
            this.label8.TabIndex = 40;
            this.label8.Text = "PRODUCTION INFORMATION TABLE";
            // 
            // prod_table
            // 
            this.prod_table.AllowUserToAddRows = false;
            this.prod_table.AllowUserToDeleteRows = false;
            this.prod_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prod_table.BackgroundColor = System.Drawing.Color.White;
            this.prod_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prod_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prod_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.prod_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prod_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_no,
            this.pro_qty,
            this.pro_damage_qty,
            this.pro_date,
            this.pro_time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prod_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.prod_table.EnableHeadersVisualStyles = false;
            this.prod_table.Location = new System.Drawing.Point(21, 63);
            this.prod_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prod_table.Name = "prod_table";
            this.prod_table.ReadOnly = true;
            this.prod_table.RowHeadersVisible = false;
            this.prod_table.RowTemplate.Height = 24;
            this.prod_table.Size = new System.Drawing.Size(1406, 610);
            this.prod_table.TabIndex = 130;
            // 
            // pro_no
            // 
            this.pro_no.DataPropertyName = "Pro_No";
            this.pro_no.HeaderText = "Pro No";
            this.pro_no.Name = "pro_no";
            this.pro_no.ReadOnly = true;
            // 
            // pro_qty
            // 
            this.pro_qty.DataPropertyName = "Pro_Qty";
            this.pro_qty.HeaderText = "Production Qty";
            this.pro_qty.Name = "pro_qty";
            this.pro_qty.ReadOnly = true;
            // 
            // pro_damage_qty
            // 
            this.pro_damage_qty.DataPropertyName = "Pro_Damage_Qty";
            this.pro_damage_qty.HeaderText = "Production Damge Qty";
            this.pro_damage_qty.Name = "pro_damage_qty";
            this.pro_damage_qty.ReadOnly = true;
            // 
            // pro_date
            // 
            this.pro_date.DataPropertyName = "Pro_Date";
            this.pro_date.HeaderText = "Data";
            this.pro_date.Name = "pro_date";
            this.pro_date.ReadOnly = true;
            // 
            // pro_time
            // 
            this.pro_time.DataPropertyName = "Pro_Time";
            this.pro_time.HeaderText = "Time";
            this.pro_time.Name = "pro_time";
            this.pro_time.ReadOnly = true;
            // 
            // ProductionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1470, 718);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.DataGridView prod_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_damage_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_time;
    }
}