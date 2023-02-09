namespace M.S.BakersManagmentSystem
{
    partial class DeliveryPesonView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sreach = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dp_table = new System.Windows.Forms.DataGridView();
            this.DP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DP_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp_tp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.dp_table);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_sreach);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1383, 670);
            this.panel2.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(678, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 94;
            this.label7.Text = "DP ID";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1251, 29);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(105, 35);
            this.btn_refresh.TabIndex = 60;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "DELIVERY PERSON DETAILS";
            // 
            // txt_sreach
            // 
            this.txt_sreach.BackColor = System.Drawing.Color.White;
            this.txt_sreach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sreach.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sreach.Location = new System.Drawing.Point(787, 30);
            this.txt_sreach.Name = "txt_sreach";
            this.txt_sreach.Size = new System.Drawing.Size(322, 29);
            this.txt_sreach.TabIndex = 42;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(1140, 29);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 35);
            this.btn_search.TabIndex = 41;
            this.btn_search.Text = "SERACH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dp_table
            // 
            this.dp_table.AllowUserToAddRows = false;
            this.dp_table.AllowUserToDeleteRows = false;
            this.dp_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dp_table.BackgroundColor = System.Drawing.Color.White;
            this.dp_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dp_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dp_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dp_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dp_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DP_ID,
            this.DP_Name,
            this.dp_address,
            this.dp_tp});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dp_table.DefaultCellStyle = dataGridViewCellStyle8;
            this.dp_table.EnableHeadersVisualStyles = false;
            this.dp_table.Location = new System.Drawing.Point(12, 86);
            this.dp_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_table.Name = "dp_table";
            this.dp_table.ReadOnly = true;
            this.dp_table.RowHeadersVisible = false;
            this.dp_table.RowTemplate.Height = 24;
            this.dp_table.Size = new System.Drawing.Size(1356, 562);
            this.dp_table.TabIndex = 97;
            // 
            // DP_ID
            // 
            this.DP_ID.DataPropertyName = "DP_ID";
            this.DP_ID.HeaderText = "DP ID";
            this.DP_ID.Name = "DP_ID";
            this.DP_ID.ReadOnly = true;
            // 
            // DP_Name
            // 
            this.DP_Name.DataPropertyName = "DP_Name";
            this.DP_Name.HeaderText = "DP Name";
            this.DP_Name.Name = "DP_Name";
            this.DP_Name.ReadOnly = true;
            // 
            // dp_address
            // 
            this.dp_address.DataPropertyName = "DP_Address";
            this.dp_address.HeaderText = "DP Address";
            this.dp_address.Name = "dp_address";
            this.dp_address.ReadOnly = true;
            // 
            // dp_tp
            // 
            this.dp_tp.DataPropertyName = "DP_TP";
            this.dp_tp.HeaderText = "DP Contact No";
            this.dp_tp.Name = "dp_tp";
            this.dp_tp.ReadOnly = true;
            // 
            // DeliveryPesonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1403, 691);
            this.Controls.Add(this.panel2);
            this.Name = "DeliveryPesonView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryPesonView";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sreach;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dp_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn DP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DP_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp_tp;
    }
}