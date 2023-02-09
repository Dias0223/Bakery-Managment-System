namespace M.S.BakersManagmentSystem
{
    partial class SupplierView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierView));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Supplier_Table = new System.Windows.Forms.DataGridView();
            this.Sup_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sreach = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.Supplier_Table);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_sreach);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1383, 670);
            this.panel2.TabIndex = 46;
            // 
            // Supplier_Table
            // 
            this.Supplier_Table.AllowUserToAddRows = false;
            this.Supplier_Table.AllowUserToDeleteRows = false;
            this.Supplier_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Supplier_Table.BackgroundColor = System.Drawing.Color.White;
            this.Supplier_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Supplier_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Supplier_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Supplier_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Supplier_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sup_ID,
            this.Sup_Name,
            this.Sup_Add,
            this.Sup_TP,
            this.Company_Name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Supplier_Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.Supplier_Table.EnableHeadersVisualStyles = false;
            this.Supplier_Table.Location = new System.Drawing.Point(12, 81);
            this.Supplier_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Supplier_Table.Name = "Supplier_Table";
            this.Supplier_Table.ReadOnly = true;
            this.Supplier_Table.RowHeadersVisible = false;
            this.Supplier_Table.RowTemplate.Height = 24;
            this.Supplier_Table.Size = new System.Drawing.Size(1356, 570);
            this.Supplier_Table.TabIndex = 96;
            // 
            // Sup_ID
            // 
            this.Sup_ID.DataPropertyName = "Sup_ID";
            this.Sup_ID.HeaderText = "ID";
            this.Sup_ID.Name = "Sup_ID";
            this.Sup_ID.ReadOnly = true;
            // 
            // Sup_Name
            // 
            this.Sup_Name.DataPropertyName = "Sup_Name";
            this.Sup_Name.HeaderText = "Name";
            this.Sup_Name.Name = "Sup_Name";
            this.Sup_Name.ReadOnly = true;
            // 
            // Sup_Add
            // 
            this.Sup_Add.DataPropertyName = "Sup_Address";
            this.Sup_Add.HeaderText = "Address";
            this.Sup_Add.Name = "Sup_Add";
            this.Sup_Add.ReadOnly = true;
            // 
            // Sup_TP
            // 
            this.Sup_TP.DataPropertyName = "Sup_TP";
            this.Sup_TP.HeaderText = "Contact No";
            this.Sup_TP.Name = "Sup_TP";
            this.Sup_TP.ReadOnly = true;
            // 
            // Company_Name
            // 
            this.Company_Name.DataPropertyName = "Company_Name";
            this.Company_Name.HeaderText = "Company";
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(678, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 94;
            this.label7.Text = "Supplier ID";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1263, 24);
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
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "SUPPLIER DETAILS";
            // 
            // txt_sreach
            // 
            this.txt_sreach.BackColor = System.Drawing.Color.White;
            this.txt_sreach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sreach.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sreach.Location = new System.Drawing.Point(801, 30);
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
            this.btn_search.Location = new System.Drawing.Point(1142, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 35);
            this.btn_search.TabIndex = 41;
            this.btn_search.Text = "SERACH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.sup_serach_btn_Click);
            // 
            // SupplierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1403, 691);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sreach;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Supplier_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_TP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Name;
    }
}