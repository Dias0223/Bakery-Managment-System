namespace M.S.BakersManagmentSystem
{
    partial class AddProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.afternoon_pro = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.prod_id_txt = new System.Windows.Forms.TextBox();
            this.morning_pro = new System.Windows.Forms.RadioButton();
            this.pro_damage_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pt_picker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pro_qty_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pro_Table = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.er_proid = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_proqty = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_damageqty = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_protime = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_p_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pro_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Damage_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pro_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_damageqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_protime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txt_p_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.afternoon_pro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.prod_id_txt);
            this.panel1.Controls.Add(this.morning_pro);
            this.panel1.Controls.Add(this.pro_damage_txt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pt_picker);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pro_qty_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(968, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 578);
            this.panel1.TabIndex = 0;
            // 
            // afternoon_pro
            // 
            this.afternoon_pro.AutoSize = true;
            this.afternoon_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afternoon_pro.ForeColor = System.Drawing.Color.White;
            this.afternoon_pro.Location = new System.Drawing.Point(73, 309);
            this.afternoon_pro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.afternoon_pro.Name = "afternoon_pro";
            this.afternoon_pro.Size = new System.Drawing.Size(111, 24);
            this.afternoon_pro.TabIndex = 111;
            this.afternoon_pro.TabStop = true;
            this.afternoon_pro.Text = "Afternoon";
            this.afternoon_pro.UseVisualStyleBackColor = true;
            this.afternoon_pro.CheckedChanged += new System.EventHandler(this.afternoon_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 78;
            this.label2.Text = "PRODUCTION ";
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
            this.button2.Location = new System.Drawing.Point(261, 487);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
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
            this.btn_save.Location = new System.Drawing.Point(144, 487);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 41);
            this.btn_save.TabIndex = 90;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // prod_id_txt
            // 
            this.prod_id_txt.BackColor = System.Drawing.Color.White;
            this.prod_id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prod_id_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.prod_id_txt.Location = new System.Drawing.Point(68, 110);
            this.prod_id_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prod_id_txt.Name = "prod_id_txt";
            this.prod_id_txt.Size = new System.Drawing.Size(173, 24);
            this.prod_id_txt.TabIndex = 80;
            this.prod_id_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prod_id_txt_KeyPress);
            // 
            // morning_pro
            // 
            this.morning_pro.AutoSize = true;
            this.morning_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morning_pro.ForeColor = System.Drawing.Color.White;
            this.morning_pro.Location = new System.Drawing.Point(73, 264);
            this.morning_pro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.morning_pro.Name = "morning_pro";
            this.morning_pro.Size = new System.Drawing.Size(97, 24);
            this.morning_pro.TabIndex = 110;
            this.morning_pro.TabStop = true;
            this.morning_pro.Text = "Morning";
            this.morning_pro.UseVisualStyleBackColor = true;
            this.morning_pro.CheckedChanged += new System.EventHandler(this.morning_CheckedChanged);
            // 
            // pro_damage_txt
            // 
            this.pro_damage_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pro_damage_txt.BackColor = System.Drawing.Color.White;
            this.pro_damage_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pro_damage_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.pro_damage_txt.Location = new System.Drawing.Point(277, 182);
            this.pro_damage_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pro_damage_txt.Name = "pro_damage_txt";
            this.pro_damage_txt.Size = new System.Drawing.Size(168, 24);
            this.pro_damage_txt.TabIndex = 86;
            this.pro_damage_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_damage_txt_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(69, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 109;
            this.label10.Text = "Production Time";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(276, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "Damage Qty";
            // 
            // pt_picker
            // 
            this.pt_picker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.pt_picker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.pt_picker.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.pt_picker.Location = new System.Drawing.Point(73, 379);
            this.pt_picker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pt_picker.Name = "pt_picker";
            this.pt_picker.Size = new System.Drawing.Size(377, 31);
            this.pt_picker.TabIndex = 108;
            this.pt_picker.ValueChanged += new System.EventHandler(this.pt_picker_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(99, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Production ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(69, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 107;
            this.label9.Text = "Production Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pro_qty_txt
            // 
            this.pro_qty_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pro_qty_txt.BackColor = System.Drawing.Color.White;
            this.pro_qty_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pro_qty_txt.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.pro_qty_txt.Location = new System.Drawing.Point(277, 110);
            this.pro_qty_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pro_qty_txt.Name = "pro_qty_txt";
            this.pro_qty_txt.Size = new System.Drawing.Size(173, 24);
            this.pro_qty_txt.TabIndex = 105;
            this.pro_qty_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pro_qty_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 106;
            this.label1.Text = "Production Qty";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.Pro_Table);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 578);
            this.panel2.TabIndex = 1;
            // 
            // Pro_Table
            // 
            this.Pro_Table.AllowUserToAddRows = false;
            this.Pro_Table.AllowUserToDeleteRows = false;
            this.Pro_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Pro_Table.BackgroundColor = System.Drawing.Color.White;
            this.Pro_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pro_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Pro_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Pro_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pro_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_no,
            this.Pro_Qty,
            this.Pro_Damage_Qty,
            this.Pro_Date,
            this.time,
            this.P_ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Pro_Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.Pro_Table.EnableHeadersVisualStyles = false;
            this.Pro_Table.Location = new System.Drawing.Point(21, 76);
            this.Pro_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pro_Table.Name = "Pro_Table";
            this.Pro_Table.ReadOnly = true;
            this.Pro_Table.RowHeadersVisible = false;
            this.Pro_Table.RowTemplate.Height = 24;
            this.Pro_Table.Size = new System.Drawing.Size(905, 476);
            this.Pro_Table.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "PRODUCTION INFORMATION ";
            // 
            // er_proid
            // 
            this.er_proid.ContainerControl = this;
            this.er_proid.Icon = ((System.Drawing.Icon)(resources.GetObject("er_proid.Icon")));
            // 
            // er_proqty
            // 
            this.er_proqty.ContainerControl = this;
            this.er_proqty.Icon = ((System.Drawing.Icon)(resources.GetObject("er_proqty.Icon")));
            // 
            // er_damageqty
            // 
            this.er_damageqty.ContainerControl = this;
            this.er_damageqty.Icon = ((System.Drawing.Icon)(resources.GetObject("er_damageqty.Icon")));
            // 
            // er_protime
            // 
            this.er_protime.ContainerControl = this;
            this.er_protime.Icon = ((System.Drawing.Icon)(resources.GetObject("er_protime.Icon")));
            // 
            // txt_p_id
            // 
            this.txt_p_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_p_id.BackColor = System.Drawing.Color.White;
            this.txt_p_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_p_id.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_p_id.Location = new System.Drawing.Point(69, 182);
            this.txt_p_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_p_id.Name = "txt_p_id";
            this.txt_p_id.Size = new System.Drawing.Size(172, 24);
            this.txt_p_id.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 112;
            this.label6.Text = "Product ID";
            // 
            // pro_no
            // 
            this.pro_no.DataPropertyName = "Pro_No";
            this.pro_no.HeaderText = "Production No";
            this.pro_no.Name = "pro_no";
            this.pro_no.ReadOnly = true;
            // 
            // Pro_Qty
            // 
            this.Pro_Qty.DataPropertyName = "Pro_Qty";
            this.Pro_Qty.HeaderText = "Production Qty";
            this.Pro_Qty.Name = "Pro_Qty";
            this.Pro_Qty.ReadOnly = true;
            // 
            // Pro_Damage_Qty
            // 
            this.Pro_Damage_Qty.DataPropertyName = "Pro_Damage_Qty";
            this.Pro_Damage_Qty.HeaderText = "Damage Qty";
            this.Pro_Damage_Qty.Name = "Pro_Damage_Qty";
            this.Pro_Damage_Qty.ReadOnly = true;
            // 
            // Pro_Date
            // 
            this.Pro_Date.DataPropertyName = "Pro_Date";
            this.Pro_Date.HeaderText = "Date";
            this.Pro_Date.Name = "Pro_Date";
            this.Pro_Date.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "Pro_Time";
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // P_ID
            // 
            this.P_ID.DataPropertyName = "P_ID";
            this.P_ID.HeaderText = "Product ID";
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            // 
            // AddProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1500, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pro_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_proqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_damageqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_protime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox pro_damage_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prod_id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pro_qty_txt;
        private System.Windows.Forms.DateTimePicker pt_picker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton afternoon_pro;
        private System.Windows.Forms.RadioButton morning_pro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Pro_Table;
        private System.Windows.Forms.ErrorProvider er_proid;
        private System.Windows.Forms.ErrorProvider er_proqty;
        private System.Windows.Forms.ErrorProvider er_damageqty;
        private System.Windows.Forms.ErrorProvider er_protime;
        private System.Windows.Forms.TextBox txt_p_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Damage_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
    }
}