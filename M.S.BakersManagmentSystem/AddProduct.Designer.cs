namespace M.S.BakersManagmentSystem
{
    partial class AddProduct
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pro_price_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pro_name_txt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pro_id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pro_table = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_up = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_proID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pro_refresh = new System.Windows.Forms.Button();
            this.er_proID = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_proName = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_proUPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_searchproid = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pro_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proUPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_searchproid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.pro_price_txt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pro_name_txt);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.pro_id_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(987, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 542);
            this.panel1.TabIndex = 0;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(221, 481);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 37);
            this.btn_update.TabIndex = 91;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(109, 481);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 37);
            this.btn_save.TabIndex = 90;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.pro_save_btn_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(332, 481);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(105, 37);
            this.btn_clear.TabIndex = 89;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pro_price_txt
            // 
            this.pro_price_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pro_price_txt.BackColor = System.Drawing.Color.White;
            this.pro_price_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pro_price_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.pro_price_txt.Location = new System.Drawing.Point(69, 274);
            this.pro_price_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pro_price_txt.Name = "pro_price_txt";
            this.pro_price_txt.Size = new System.Drawing.Size(317, 24);
            this.pro_price_txt.TabIndex = 88;
            this.pro_price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_price_txt_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(64, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 87;
            this.label10.Text = "Product Unit Price";
            // 
            // pro_name_txt
            // 
            this.pro_name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pro_name_txt.BackColor = System.Drawing.Color.White;
            this.pro_name_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pro_name_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.pro_name_txt.Location = new System.Drawing.Point(69, 177);
            this.pro_name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pro_name_txt.Name = "pro_name_txt";
            this.pro_name_txt.Size = new System.Drawing.Size(317, 24);
            this.pro_name_txt.TabIndex = 86;
            this.pro_name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_name_txt_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(65, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 20);
            this.label15.TabIndex = 85;
            this.label15.Text = "Product Name";
            // 
            // pro_id_txt
            // 
            this.pro_id_txt.BackColor = System.Drawing.Color.White;
            this.pro_id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pro_id_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.pro_id_txt.Location = new System.Drawing.Point(69, 96);
            this.pro_id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pro_id_txt.Name = "pro_id_txt";
            this.pro_id_txt.Size = new System.Drawing.Size(323, 24);
            this.pro_id_txt.TabIndex = 84;
            this.pro_id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_id_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Product Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pro_table);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.txt_proID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_pro_refresh);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 542);
            this.panel2.TabIndex = 1;
            // 
            // pro_table
            // 
            this.pro_table.AllowUserToAddRows = false;
            this.pro_table.AllowUserToDeleteRows = false;
            this.pro_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pro_table.BackgroundColor = System.Drawing.Color.White;
            this.pro_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pro_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pro_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pro_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pro_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_ID,
            this.p_Name,
            this.p_up});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pro_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.pro_table.EnableHeadersVisualStyles = false;
            this.pro_table.Location = new System.Drawing.Point(35, 82);
            this.pro_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pro_table.Name = "pro_table";
            this.pro_table.ReadOnly = true;
            this.pro_table.RowHeadersVisible = false;
            this.pro_table.RowTemplate.Height = 24;
            this.pro_table.Size = new System.Drawing.Size(899, 378);
            this.pro_table.TabIndex = 96;
            this.pro_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pro_table_CellClick_1);
            // 
            // P_ID
            // 
            this.P_ID.DataPropertyName = "P_ID";
            this.P_ID.HeaderText = "Product ID";
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            // 
            // p_Name
            // 
            this.p_Name.DataPropertyName = "P_Name";
            this.p_Name.HeaderText = "Product Name";
            this.p_Name.Name = "p_Name";
            this.p_Name.ReadOnly = true;
            // 
            // p_up
            // 
            this.p_up.DataPropertyName = "P_Unit_Price";
            this.p_up.HeaderText = "Unit Price";
            this.p_up.Name = "p_up";
            this.p_up.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(327, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "Product ID";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(831, 16);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(111, 34);
            this.btn_search.TabIndex = 94;
            this.btn_search.Text = "Serach";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_proID
            // 
            this.txt_proID.BackColor = System.Drawing.Color.White;
            this.txt_proID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_proID.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_proID.Location = new System.Drawing.Point(469, 20);
            this.txt_proID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_proID.Name = "txt_proID";
            this.txt_proID.Size = new System.Drawing.Size(323, 24);
            this.txt_proID.TabIndex = 93;
            this.txt_proID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_proID_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "PRODUCT TABLE";
            // 
            // btn_pro_refresh
            // 
            this.btn_pro_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pro_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_pro_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pro_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pro_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_pro_refresh.Location = new System.Drawing.Point(831, 481);
            this.btn_pro_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pro_refresh.Name = "btn_pro_refresh";
            this.btn_pro_refresh.Size = new System.Drawing.Size(111, 38);
            this.btn_pro_refresh.TabIndex = 91;
            this.btn_pro_refresh.Text = "Refresh";
            this.btn_pro_refresh.UseVisualStyleBackColor = false;
            this.btn_pro_refresh.Click += new System.EventHandler(this.lll_Click);
            // 
            // er_proID
            // 
            this.er_proID.ContainerControl = this;
            this.er_proID.Icon = ((System.Drawing.Icon)(resources.GetObject("er_proID.Icon")));
            // 
            // er_proName
            // 
            this.er_proName.ContainerControl = this;
            this.er_proName.Icon = ((System.Drawing.Icon)(resources.GetObject("er_proName.Icon")));
            // 
            // er_proUPrice
            // 
            this.er_proUPrice.ContainerControl = this;
            this.er_proUPrice.Icon = ((System.Drawing.Icon)(resources.GetObject("er_proUPrice.Icon")));
            // 
            // er_searchproid
            // 
            this.er_searchproid.ContainerControl = this;
            this.er_searchproid.Icon = ((System.Drawing.Icon)(resources.GetObject("er_searchproid.Icon")));
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1468, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pro_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proUPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_searchproid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox pro_price_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pro_name_txt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox pro_id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pro_refresh;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_proID;
        private System.Windows.Forms.DataGridView pro_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_up;
        private System.Windows.Forms.ErrorProvider er_proID;
        private System.Windows.Forms.ErrorProvider er_proName;
        private System.Windows.Forms.ErrorProvider er_proUPrice;
        private System.Windows.Forms.ErrorProvider er_searchproid;
    }
}