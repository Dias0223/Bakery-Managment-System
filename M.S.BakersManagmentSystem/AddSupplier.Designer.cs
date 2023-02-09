namespace M.S.BakersManagmentSystem
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update_sup = new System.Windows.Forms.Button();
            this.btn_sup_clear = new System.Windows.Forms.Button();
            this.btn_sup_save = new System.Windows.Forms.Button();
            this.sup_add_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tp_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.com_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sup_name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sup_id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_serach_sup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sreach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.Supplier_Table = new System.Windows.Forms.DataGridView();
            this.Sup_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.er_supid = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_supname = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_address = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_companyname = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_tp = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_searchsup = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_supid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_supname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_companyname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_tp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_searchsup)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_update_sup);
            this.panel1.Controls.Add(this.btn_sup_clear);
            this.panel1.Controls.Add(this.btn_sup_save);
            this.panel1.Controls.Add(this.sup_add_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tp_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.com_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sup_name_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sup_id_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(975, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 594);
            this.panel1.TabIndex = 0;
            // 
            // btn_update_sup
            // 
            this.btn_update_sup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_sup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btn_update_sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_sup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.btn_update_sup.Location = new System.Drawing.Point(180, 514);
            this.btn_update_sup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update_sup.Name = "btn_update_sup";
            this.btn_update_sup.Size = new System.Drawing.Size(105, 34);
            this.btn_update_sup.TabIndex = 103;
            this.btn_update_sup.Text = "Update";
            this.btn_update_sup.UseVisualStyleBackColor = false;
            this.btn_update_sup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sup_clear
            // 
            this.btn_sup_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btn_sup_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sup_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.btn_sup_clear.Location = new System.Drawing.Point(291, 514);
            this.btn_sup_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sup_clear.Name = "btn_sup_clear";
            this.btn_sup_clear.Size = new System.Drawing.Size(105, 34);
            this.btn_sup_clear.TabIndex = 102;
            this.btn_sup_clear.Text = "Clear";
            this.btn_sup_clear.UseVisualStyleBackColor = false;
            this.btn_sup_clear.Click += new System.EventHandler(this.btn_sup_clear_Click);
            // 
            // btn_sup_save
            // 
            this.btn_sup_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sup_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btn_sup_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sup_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sup_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.btn_sup_save.Location = new System.Drawing.Point(69, 514);
            this.btn_sup_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sup_save.Name = "btn_sup_save";
            this.btn_sup_save.Size = new System.Drawing.Size(105, 34);
            this.btn_sup_save.TabIndex = 101;
            this.btn_sup_save.Text = "Save";
            this.btn_sup_save.UseVisualStyleBackColor = false;
            this.btn_sup_save.Click += new System.EventHandler(this.btn_sup_save_Click_1);
            // 
            // sup_add_txt
            // 
            this.sup_add_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sup_add_txt.BackColor = System.Drawing.Color.White;
            this.sup_add_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sup_add_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_add_txt.Location = new System.Drawing.Point(75, 295);
            this.sup_add_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sup_add_txt.Name = "sup_add_txt";
            this.sup_add_txt.Size = new System.Drawing.Size(323, 27);
            this.sup_add_txt.TabIndex = 100;
            this.sup_add_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sup_add_txt_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(69, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 99;
            this.label5.Text = "Address";
            // 
            // tp_txt
            // 
            this.tp_txt.BackColor = System.Drawing.Color.White;
            this.tp_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tp_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_txt.Location = new System.Drawing.Point(75, 455);
            this.tp_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_txt.Name = "tp_txt";
            this.tp_txt.Size = new System.Drawing.Size(323, 27);
            this.tp_txt.TabIndex = 98;
            this.tp_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tp_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(69, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Telephone Number";
            // 
            // com_txt
            // 
            this.com_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.com_txt.BackColor = System.Drawing.Color.White;
            this.com_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.com_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_txt.Location = new System.Drawing.Point(75, 375);
            this.com_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_txt.Name = "com_txt";
            this.com_txt.Size = new System.Drawing.Size(323, 27);
            this.com_txt.TabIndex = 96;
            this.com_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.com_txt_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label6.Location = new System.Drawing.Point(69, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "Company Name";
            // 
            // sup_name_txt
            // 
            this.sup_name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sup_name_txt.BackColor = System.Drawing.Color.White;
            this.sup_name_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sup_name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_name_txt.Location = new System.Drawing.Point(75, 212);
            this.sup_name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sup_name_txt.Name = "sup_name_txt";
            this.sup_name_txt.Size = new System.Drawing.Size(323, 27);
            this.sup_name_txt.TabIndex = 94;
            this.sup_name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sup_name_txt_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(69, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Supplier Name";
            // 
            // sup_id_txt
            // 
            this.sup_id_txt.BackColor = System.Drawing.Color.White;
            this.sup_id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sup_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_id_txt.Location = new System.Drawing.Point(75, 137);
            this.sup_id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sup_id_txt.Name = "sup_id_txt";
            this.sup_id_txt.Size = new System.Drawing.Size(323, 27);
            this.sup_id_txt.TabIndex = 92;
            this.sup_id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sup_id_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(69, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Supplier ID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(69, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 90;
            this.label2.Text = "SUPPLIER INFORMATION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btn_serach_sup);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_sreach);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.Supplier_Table);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 591);
            this.panel2.TabIndex = 1;
            // 
            // btn_serach_sup
            // 
            this.btn_serach_sup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_serach_sup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btn_serach_sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_serach_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serach_sup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.btn_serach_sup.Location = new System.Drawing.Point(824, 43);
            this.btn_serach_sup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_serach_sup.Name = "btn_serach_sup";
            this.btn_serach_sup.Size = new System.Drawing.Size(105, 30);
            this.btn_serach_sup.TabIndex = 101;
            this.btn_serach_sup.Text = "Search";
            this.btn_serach_sup.UseVisualStyleBackColor = false;
            this.btn_serach_sup.Click += new System.EventHandler(this.btn_serach_sup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label7.Location = new System.Drawing.Point(473, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 100;
            this.label7.Text = "Supplier ID";
            // 
            // txt_sreach
            // 
            this.txt_sreach.BackColor = System.Drawing.Color.White;
            this.txt_sreach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sreach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sreach.Location = new System.Drawing.Point(597, 44);
            this.txt_sreach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sreach.Name = "txt_sreach";
            this.txt_sreach.Size = new System.Drawing.Size(207, 27);
            this.txt_sreach.TabIndex = 99;
            this.txt_sreach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sreach_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.label9.Location = new System.Drawing.Point(27, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 25);
            this.label9.TabIndex = 97;
            this.label9.Text = "SUPPLIER INFORMATION";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.btn_refresh.Location = new System.Drawing.Point(824, 512);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(105, 34);
            this.btn_refresh.TabIndex = 96;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
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
            this.Supplier_Table.Location = new System.Drawing.Point(31, 103);
            this.Supplier_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Supplier_Table.Name = "Supplier_Table";
            this.Supplier_Table.ReadOnly = true;
            this.Supplier_Table.RowHeadersVisible = false;
            this.Supplier_Table.RowTemplate.Height = 24;
            this.Supplier_Table.Size = new System.Drawing.Size(899, 378);
            this.Supplier_Table.TabIndex = 95;
            this.Supplier_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Supplier_Table_CellClick);
            this.Supplier_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Supplier_Table_CellContentClick);
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
            // er_supid
            // 
            this.er_supid.ContainerControl = this;
            this.er_supid.Icon = ((System.Drawing.Icon)(resources.GetObject("er_supid.Icon")));
            // 
            // er_supname
            // 
            this.er_supname.ContainerControl = this;
            this.er_supname.Icon = ((System.Drawing.Icon)(resources.GetObject("er_supname.Icon")));
            // 
            // er_address
            // 
            this.er_address.ContainerControl = this;
            this.er_address.Icon = ((System.Drawing.Icon)(resources.GetObject("er_address.Icon")));
            // 
            // er_companyname
            // 
            this.er_companyname.ContainerControl = this;
            this.er_companyname.Icon = ((System.Drawing.Icon)(resources.GetObject("er_companyname.Icon")));
            // 
            // er_tp
            // 
            this.er_tp.ContainerControl = this;
            this.er_tp.Icon = ((System.Drawing.Icon)(resources.GetObject("er_tp.Icon")));
            // 
            // er_searchsup
            // 
            this.er_searchsup.ContainerControl = this;
            this.er_searchsup.Icon = ((System.Drawing.Icon)(resources.GetObject("er_searchsup.Icon")));
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1451, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_supid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_supname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_companyname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_tp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_searchsup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sup_clear;
        private System.Windows.Forms.Button btn_sup_save;
        private System.Windows.Forms.TextBox sup_add_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tp_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox com_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sup_name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sup_id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_serach_sup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sreach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView Supplier_Table;
        private System.Windows.Forms.Button btn_update_sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_TP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Name;
        private System.Windows.Forms.ErrorProvider er_supid;
        private System.Windows.Forms.ErrorProvider er_supname;
        private System.Windows.Forms.ErrorProvider er_address;
        private System.Windows.Forms.ErrorProvider er_companyname;
        private System.Windows.Forms.ErrorProvider er_tp;
        private System.Windows.Forms.ErrorProvider er_searchsup;
    }
}