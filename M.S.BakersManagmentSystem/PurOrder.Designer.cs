namespace M.S.BakersManagmentSystem
{
    partial class PurOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurOrder));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pur_Table = new System.Windows.Forms.DataGridView();
            this.pur_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rm_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pur_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pur_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_sup_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pur_id_txt = new System.Windows.Forms.TextBox();
            this.pur_qty_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pur_picker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rm_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.er_purchaseno = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_rmno = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_supplierID = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_purchaseqty = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pur_Table)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_purchaseno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_rmno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_supplierID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_purchaseqty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pur_Table);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(9, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 470);
            this.panel2.TabIndex = 3;
            // 
            // pur_Table
            // 
            this.pur_Table.AllowUserToAddRows = false;
            this.pur_Table.AllowUserToDeleteRows = false;
            this.pur_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pur_Table.BackgroundColor = System.Drawing.Color.White;
            this.pur_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pur_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pur_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pur_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pur_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pur_no,
            this.rm_no,
            this.sup_id,
            this.pur_date,
            this.pur_qty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pur_Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.pur_Table.EnableHeadersVisualStyles = false;
            this.pur_Table.Location = new System.Drawing.Point(16, 62);
            this.pur_Table.Margin = new System.Windows.Forms.Padding(2);
            this.pur_Table.Name = "pur_Table";
            this.pur_Table.ReadOnly = true;
            this.pur_Table.RowHeadersVisible = false;
            this.pur_Table.RowTemplate.Height = 24;
            this.pur_Table.Size = new System.Drawing.Size(679, 387);
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
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "PURCHASE ORDER INFORMATION ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txt_sup_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.pur_id_txt);
            this.panel1.Controls.Add(this.pur_qty_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pur_picker);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rm_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(726, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 470);
            this.panel1.TabIndex = 2;
            // 
            // txt_sup_id
            // 
            this.txt_sup_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sup_id.BackColor = System.Drawing.Color.White;
            this.txt_sup_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sup_id.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_sup_id.Location = new System.Drawing.Point(51, 146);
            this.txt_sup_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sup_id.Name = "txt_sup_id";
            this.txt_sup_id.Size = new System.Drawing.Size(130, 20);
            this.txt_sup_id.TabIndex = 112;
            this.txt_sup_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sup_id_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 113;
            this.label6.Text = "Supplier ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "PURCHASE ORDER";
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
            this.button2.Location = new System.Drawing.Point(196, 396);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 33);
            this.button2.TabIndex = 91;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(108, 396);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 33);
            this.btn_save.TabIndex = 90;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pur_id_txt
            // 
            this.pur_id_txt.BackColor = System.Drawing.Color.White;
            this.pur_id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pur_id_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.pur_id_txt.Location = new System.Drawing.Point(51, 89);
            this.pur_id_txt.Margin = new System.Windows.Forms.Padding(2);
            this.pur_id_txt.Name = "pur_id_txt";
            this.pur_id_txt.Size = new System.Drawing.Size(130, 20);
            this.pur_id_txt.TabIndex = 80;
            this.pur_id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pur_id_txt_KeyPress);
            // 
            // pur_qty_txt
            // 
            this.pur_qty_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pur_qty_txt.BackColor = System.Drawing.Color.White;
            this.pur_qty_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pur_qty_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.pur_qty_txt.Location = new System.Drawing.Point(208, 146);
            this.pur_qty_txt.Margin = new System.Windows.Forms.Padding(2);
            this.pur_qty_txt.Name = "pur_qty_txt";
            this.pur_qty_txt.Size = new System.Drawing.Size(126, 20);
            this.pur_qty_txt.TabIndex = 86;
            this.pur_qty_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pur_qty_txt_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(207, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Purchase Qty";
            // 
            // pur_picker
            // 
            this.pur_picker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.pur_picker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pur_picker.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.pur_picker.Location = new System.Drawing.Point(51, 216);
            this.pur_picker.Margin = new System.Windows.Forms.Padding(2);
            this.pur_picker.Name = "pur_picker";
            this.pur_picker.Size = new System.Drawing.Size(284, 27);
            this.pur_picker.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(74, 404);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Purchase No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(48, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 107;
            this.label9.Text = "Purchase Date";
            // 
            // rm_txt
            // 
            this.rm_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rm_txt.BackColor = System.Drawing.Color.White;
            this.rm_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rm_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.rm_txt.Location = new System.Drawing.Point(208, 89);
            this.rm_txt.Margin = new System.Windows.Forms.Padding(2);
            this.rm_txt.Name = "rm_txt";
            this.rm_txt.Size = new System.Drawing.Size(130, 20);
            this.rm_txt.TabIndex = 105;
            this.rm_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rm_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "RM No";
            // 
            // er_purchaseno
            // 
            this.er_purchaseno.ContainerControl = this;
            this.er_purchaseno.Icon = ((System.Drawing.Icon)(resources.GetObject("er_purchaseno.Icon")));
            // 
            // er_rmno
            // 
            this.er_rmno.ContainerControl = this;
            this.er_rmno.Icon = ((System.Drawing.Icon)(resources.GetObject("er_rmno.Icon")));
            // 
            // er_supplierID
            // 
            this.er_supplierID.ContainerControl = this;
            this.er_supplierID.Icon = ((System.Drawing.Icon)(resources.GetObject("er_supplierID.Icon")));
            // 
            // er_purchaseqty
            // 
            this.er_purchaseqty.ContainerControl = this;
            this.er_purchaseqty.Icon = ((System.Drawing.Icon)(resources.GetObject("er_purchaseqty.Icon")));
            // 
            // PurOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1125, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PurOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurOrder";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pur_Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_purchaseno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_rmno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_supplierID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_purchaseqty)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_sup_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox pur_id_txt;
        private System.Windows.Forms.TextBox pur_qty_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker pur_picker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rm_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider er_purchaseno;
        private System.Windows.Forms.ErrorProvider er_rmno;
        private System.Windows.Forms.ErrorProvider er_supplierID;
        private System.Windows.Forms.ErrorProvider er_purchaseqty;
    }
}