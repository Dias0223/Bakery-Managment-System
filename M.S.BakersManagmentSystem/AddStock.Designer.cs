namespace M.S.BakersManagmentSystem
{
    partial class AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.stock_table = new System.Windows.Forms.DataGridView();
            this.St_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damage_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ava_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.st_name_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.st_id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save_st = new System.Windows.Forms.Button();
            this.st_ava_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.st_update_btn = new System.Windows.Forms.Button();
            this.st_damage_txt = new System.Windows.Forms.TextBox();
            this.er_StockID = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_StockName = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_Damageqty = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_Availableqty = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_table)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_StockID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_StockName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_Damageqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_Availableqty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.stock_table);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 560);
            this.panel1.TabIndex = 0;
            // 
            // stock_table
            // 
            this.stock_table.AllowUserToAddRows = false;
            this.stock_table.AllowUserToDeleteRows = false;
            this.stock_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stock_table.BackgroundColor = System.Drawing.Color.White;
            this.stock_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stock_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stock_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stock_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.St_ID,
            this.rm_id,
            this.damage_qty,
            this.ava_qty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stock_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.stock_table.EnableHeadersVisualStyles = false;
            this.stock_table.Location = new System.Drawing.Point(19, 75);
            this.stock_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stock_table.Name = "stock_table";
            this.stock_table.ReadOnly = true;
            this.stock_table.RowHeadersVisible = false;
            this.stock_table.RowTemplate.Height = 24;
            this.stock_table.Size = new System.Drawing.Size(864, 462);
            this.stock_table.TabIndex = 96;
            this.stock_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stock_table_CellClick);
            // 
            // St_ID
            // 
            this.St_ID.DataPropertyName = "ST_ID";
            this.St_ID.HeaderText = "ID";
            this.St_ID.Name = "St_ID";
            this.St_ID.ReadOnly = true;
            // 
            // rm_id
            // 
            this.rm_id.DataPropertyName = "RM_No";
            this.rm_id.HeaderText = "RM No";
            this.rm_id.Name = "rm_id";
            this.rm_id.ReadOnly = true;
            // 
            // damage_qty
            // 
            this.damage_qty.DataPropertyName = "ST_Damage_Qty";
            this.damage_qty.HeaderText = "Damage Qty";
            this.damage_qty.Name = "damage_qty";
            this.damage_qty.ReadOnly = true;
            // 
            // ava_qty
            // 
            this.ava_qty.DataPropertyName = "ST_Ava_Qty";
            this.ava_qty.HeaderText = "Available Qty";
            this.ava_qty.Name = "ava_qty";
            this.ava_qty.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "STOCK TABLE";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(336, 497);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 39);
            this.button2.TabIndex = 80;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(43, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 71;
            this.label9.Text = "Damage Qty";
            // 
            // st_name_txt
            // 
            this.st_name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.st_name_txt.BackColor = System.Drawing.Color.White;
            this.st_name_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.st_name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_name_txt.Location = new System.Drawing.Point(187, 146);
            this.st_name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.st_name_txt.Name = "st_name_txt";
            this.st_name_txt.Size = new System.Drawing.Size(289, 23);
            this.st_name_txt.TabIndex = 65;
            this.st_name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.st_name_txt_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(43, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "RM ID";
            // 
            // st_id_txt
            // 
            this.st_id_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.st_id_txt.BackColor = System.Drawing.Color.White;
            this.st_id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.st_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_id_txt.Location = new System.Drawing.Point(187, 89);
            this.st_id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.st_id_txt.Name = "st_id_txt";
            this.st_id_txt.Size = new System.Drawing.Size(289, 23);
            this.st_id_txt.TabIndex = 61;
            this.st_id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.st_id_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Stock ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btn_save_st);
            this.panel2.Controls.Add(this.st_ava_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.st_update_btn);
            this.panel2.Controls.Add(this.st_damage_txt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.st_id_txt);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.st_name_txt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(920, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 560);
            this.panel2.TabIndex = 1;
            // 
            // btn_save_st
            // 
            this.btn_save_st.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_st.BackColor = System.Drawing.Color.Transparent;
            this.btn_save_st.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_st.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_st.ForeColor = System.Drawing.Color.White;
            this.btn_save_st.Location = new System.Drawing.Point(83, 497);
            this.btn_save_st.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save_st.Name = "btn_save_st";
            this.btn_save_st.Size = new System.Drawing.Size(124, 39);
            this.btn_save_st.TabIndex = 85;
            this.btn_save_st.Text = "Save";
            this.btn_save_st.UseVisualStyleBackColor = false;
            this.btn_save_st.Click += new System.EventHandler(this.btn_save_st_Click);
            // 
            // st_ava_txt
            // 
            this.st_ava_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.st_ava_txt.BackColor = System.Drawing.Color.White;
            this.st_ava_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.st_ava_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_ava_txt.Location = new System.Drawing.Point(187, 258);
            this.st_ava_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.st_ava_txt.Name = "st_ava_txt";
            this.st_ava_txt.Size = new System.Drawing.Size(289, 23);
            this.st_ava_txt.TabIndex = 84;
            this.st_ava_txt.TextChanged += new System.EventHandler(this.st_ava_txt_TextChanged);
            this.st_ava_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.st_ava_txt_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Available Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "STOCK";
            // 
            // st_update_btn
            // 
            this.st_update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.st_update_btn.BackColor = System.Drawing.Color.Transparent;
            this.st_update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.st_update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_update_btn.ForeColor = System.Drawing.Color.White;
            this.st_update_btn.Location = new System.Drawing.Point(212, 497);
            this.st_update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.st_update_btn.Name = "st_update_btn";
            this.st_update_btn.Size = new System.Drawing.Size(117, 39);
            this.st_update_btn.TabIndex = 81;
            this.st_update_btn.Text = "Update";
            this.st_update_btn.UseVisualStyleBackColor = false;
            this.st_update_btn.Click += new System.EventHandler(this.RS_btn_Click);
            // 
            // st_damage_txt
            // 
            this.st_damage_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.st_damage_txt.BackColor = System.Drawing.Color.White;
            this.st_damage_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.st_damage_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_damage_txt.Location = new System.Drawing.Point(187, 206);
            this.st_damage_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.st_damage_txt.Name = "st_damage_txt";
            this.st_damage_txt.Size = new System.Drawing.Size(289, 23);
            this.st_damage_txt.TabIndex = 72;
            this.st_damage_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.st_damage_txt_KeyPress);
            // 
            // er_StockID
            // 
            this.er_StockID.ContainerControl = this;
            this.er_StockID.Icon = ((System.Drawing.Icon)(resources.GetObject("er_StockID.Icon")));
            // 
            // er_StockName
            // 
            this.er_StockName.ContainerControl = this;
            this.er_StockName.Icon = ((System.Drawing.Icon)(resources.GetObject("er_StockName.Icon")));
            // 
            // er_Damageqty
            // 
            this.er_Damageqty.ContainerControl = this;
            this.er_Damageqty.Icon = ((System.Drawing.Icon)(resources.GetObject("er_Damageqty.Icon")));
            // 
            // er_Availableqty
            // 
            this.er_Availableqty.ContainerControl = this;
            this.er_Availableqty.Icon = ((System.Drawing.Icon)(resources.GetObject("er_Availableqty.Icon")));
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1459, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_table)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_StockID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_StockName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_Damageqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_Availableqty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox st_name_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox st_id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button st_update_btn;
        private System.Windows.Forms.TextBox st_damage_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox st_ava_txt;
        private System.Windows.Forms.Button btn_save_st;
        private System.Windows.Forms.DataGridView stock_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn damage_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ava_qty;
        private System.Windows.Forms.ErrorProvider er_StockID;
        private System.Windows.Forms.ErrorProvider er_StockName;
        private System.Windows.Forms.ErrorProvider er_Damageqty;
        private System.Windows.Forms.ErrorProvider er_Availableqty;
    }
}