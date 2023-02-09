namespace M.S.BakersManagmentSystem
{
    partial class DeliveryPersoncs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryPersoncs));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dp_table = new System.Windows.Forms.DataGridView();
            this.DP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DP_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp_tp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search_dp = new System.Windows.Forms.Button();
            this.txt_proID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pro_refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dp_tp_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_dp_update = new System.Windows.Forms.Button();
            this.btn_dp_save = new System.Windows.Forms.Button();
            this.btn_dp_clear = new System.Windows.Forms.Button();
            this.dp_add_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dp_name_txt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dp_id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.er_dpid = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_dpname = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_dpaddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_dpcontactno = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_searchdpid = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_table)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_dpid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_dpname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_dpaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_dpcontactno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_searchdpid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.dp_table);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_search_dp);
            this.panel2.Controls.Add(this.txt_proID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_pro_refresh);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 542);
            this.panel2.TabIndex = 3;
            // 
            // dp_table
            // 
            this.dp_table.AllowUserToAddRows = false;
            this.dp_table.AllowUserToDeleteRows = false;
            this.dp_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dp_table.BackgroundColor = System.Drawing.Color.White;
            this.dp_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dp_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dp_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dp_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dp_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DP_ID,
            this.DP_Name,
            this.dp_address,
            this.dp_tp});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dp_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.dp_table.EnableHeadersVisualStyles = false;
            this.dp_table.Location = new System.Drawing.Point(35, 82);
            this.dp_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_table.Name = "dp_table";
            this.dp_table.ReadOnly = true;
            this.dp_table.RowHeadersVisible = false;
            this.dp_table.RowTemplate.Height = 24;
            this.dp_table.Size = new System.Drawing.Size(899, 378);
            this.dp_table.TabIndex = 96;
            this.dp_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dp_table_CellClick);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(380, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "DP ID";
            // 
            // btn_search_dp
            // 
            this.btn_search_dp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_dp.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_dp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_dp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_dp.ForeColor = System.Drawing.Color.White;
            this.btn_search_dp.Location = new System.Drawing.Point(831, 14);
            this.btn_search_dp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_dp.Name = "btn_search_dp";
            this.btn_search_dp.Size = new System.Drawing.Size(103, 36);
            this.btn_search_dp.TabIndex = 94;
            this.btn_search_dp.Text = "Search";
            this.btn_search_dp.UseVisualStyleBackColor = false;
            this.btn_search_dp.Click += new System.EventHandler(this.btn_search_dp_Click);
            // 
            // txt_proID
            // 
            this.txt_proID.BackColor = System.Drawing.Color.White;
            this.txt_proID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_proID.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_proID.Location = new System.Drawing.Point(467, 20);
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
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "DELIVERY PERSON INFO";
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
            this.btn_pro_refresh.Size = new System.Drawing.Size(111, 40);
            this.btn_pro_refresh.TabIndex = 91;
            this.btn_pro_refresh.Text = "Refresh";
            this.btn_pro_refresh.UseVisualStyleBackColor = false;
            this.btn_pro_refresh.Click += new System.EventHandler(this.btn_pro_refresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.dp_tp_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_dp_update);
            this.panel1.Controls.Add(this.btn_dp_save);
            this.panel1.Controls.Add(this.btn_dp_clear);
            this.panel1.Controls.Add(this.dp_add_txt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dp_name_txt);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.dp_id_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(985, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 542);
            this.panel1.TabIndex = 2;
            // 
            // dp_tp_txt
            // 
            this.dp_tp_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dp_tp_txt.BackColor = System.Drawing.Color.White;
            this.dp_tp_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dp_tp_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.dp_tp_txt.Location = new System.Drawing.Point(68, 334);
            this.dp_tp_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_tp_txt.Name = "dp_tp_txt";
            this.dp_tp_txt.Size = new System.Drawing.Size(317, 24);
            this.dp_tp_txt.TabIndex = 93;
            this.dp_tp_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dp_tp_txt_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "DP Contact No";
            // 
            // btn_dp_update
            // 
            this.btn_dp_update.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dp_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_dp_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dp_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dp_update.ForeColor = System.Drawing.Color.White;
            this.btn_dp_update.Location = new System.Drawing.Point(175, 481);
            this.btn_dp_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dp_update.Name = "btn_dp_update";
            this.btn_dp_update.Size = new System.Drawing.Size(105, 39);
            this.btn_dp_update.TabIndex = 91;
            this.btn_dp_update.Text = "Update";
            this.btn_dp_update.UseVisualStyleBackColor = false;
            this.btn_dp_update.Click += new System.EventHandler(this.btn_dp_update_Click);
            // 
            // btn_dp_save
            // 
            this.btn_dp_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dp_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_dp_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dp_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_dp_save.ForeColor = System.Drawing.Color.White;
            this.btn_dp_save.Location = new System.Drawing.Point(63, 481);
            this.btn_dp_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dp_save.Name = "btn_dp_save";
            this.btn_dp_save.Size = new System.Drawing.Size(105, 39);
            this.btn_dp_save.TabIndex = 90;
            this.btn_dp_save.Text = "Save";
            this.btn_dp_save.UseVisualStyleBackColor = false;
            this.btn_dp_save.Click += new System.EventHandler(this.btn_dp_save_Click);
            // 
            // btn_dp_clear
            // 
            this.btn_dp_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dp_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_dp_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dp_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dp_clear.ForeColor = System.Drawing.Color.White;
            this.btn_dp_clear.Location = new System.Drawing.Point(285, 481);
            this.btn_dp_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dp_clear.Name = "btn_dp_clear";
            this.btn_dp_clear.Size = new System.Drawing.Size(105, 39);
            this.btn_dp_clear.TabIndex = 89;
            this.btn_dp_clear.Text = "Clear";
            this.btn_dp_clear.UseVisualStyleBackColor = false;
            this.btn_dp_clear.Click += new System.EventHandler(this.btn_dp_clear_Click);
            // 
            // dp_add_txt
            // 
            this.dp_add_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dp_add_txt.BackColor = System.Drawing.Color.White;
            this.dp_add_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dp_add_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.dp_add_txt.Location = new System.Drawing.Point(69, 258);
            this.dp_add_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_add_txt.Name = "dp_add_txt";
            this.dp_add_txt.Size = new System.Drawing.Size(317, 24);
            this.dp_add_txt.TabIndex = 88;
            this.dp_add_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dp_add_txt_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(64, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 87;
            this.label10.Text = "DP Address";
            // 
            // dp_name_txt
            // 
            this.dp_name_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dp_name_txt.BackColor = System.Drawing.Color.White;
            this.dp_name_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dp_name_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.dp_name_txt.Location = new System.Drawing.Point(69, 177);
            this.dp_name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_name_txt.Name = "dp_name_txt";
            this.dp_name_txt.Size = new System.Drawing.Size(317, 24);
            this.dp_name_txt.TabIndex = 86;
            this.dp_name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dp_name_txt_KeyPress);
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
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 85;
            this.label15.Text = "DP Name";
            // 
            // dp_id_txt
            // 
            this.dp_id_txt.BackColor = System.Drawing.Color.White;
            this.dp_id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dp_id_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.dp_id_txt.Location = new System.Drawing.Point(69, 96);
            this.dp_id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dp_id_txt.Name = "dp_id_txt";
            this.dp_id_txt.Size = new System.Drawing.Size(323, 24);
            this.dp_id_txt.TabIndex = 84;
            this.dp_id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dp_id_txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "DP ID";
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
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "DELIVERY PERSON";
            // 
            // er_dpid
            // 
            this.er_dpid.ContainerControl = this;
            this.er_dpid.Icon = ((System.Drawing.Icon)(resources.GetObject("er_dpid.Icon")));
            // 
            // er_dpname
            // 
            this.er_dpname.ContainerControl = this;
            this.er_dpname.Icon = ((System.Drawing.Icon)(resources.GetObject("er_dpname.Icon")));
            // 
            // er_dpaddress
            // 
            this.er_dpaddress.ContainerControl = this;
            this.er_dpaddress.Icon = ((System.Drawing.Icon)(resources.GetObject("er_dpaddress.Icon")));
            // 
            // er_dpcontactno
            // 
            this.er_dpcontactno.ContainerControl = this;
            this.er_dpcontactno.Icon = ((System.Drawing.Icon)(resources.GetObject("er_dpcontactno.Icon")));
            // 
            // er_searchdpid
            // 
            this.er_searchdpid.ContainerControl = this;
            this.er_searchdpid.Icon = ((System.Drawing.Icon)(resources.GetObject("er_searchdpid.Icon")));
            // 
            // DeliveryPersoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1468, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DeliveryPersoncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryPersoncs";
            this.Load += new System.EventHandler(this.DeliveryPersoncs_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dp_table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_dpid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_dpname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_dpaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_dpcontactno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_searchdpid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dp_table;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search_dp;
        private System.Windows.Forms.TextBox txt_proID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pro_refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dp_update;
        private System.Windows.Forms.Button btn_dp_save;
        private System.Windows.Forms.Button btn_dp_clear;
        private System.Windows.Forms.TextBox dp_add_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dp_name_txt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox dp_id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dp_tp_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DP_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp_tp;
        private System.Windows.Forms.ErrorProvider er_dpid;
        private System.Windows.Forms.ErrorProvider er_dpname;
        private System.Windows.Forms.ErrorProvider er_dpaddress;
        private System.Windows.Forms.ErrorProvider er_dpcontactno;
        private System.Windows.Forms.ErrorProvider er_searchdpid;
    }
}