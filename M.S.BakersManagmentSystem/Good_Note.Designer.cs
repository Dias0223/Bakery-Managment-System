namespace M.S.BakersManagmentSystem
{
    partial class Good_Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Good_Note));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pur_no = new System.Windows.Forms.TextBox();
            this.btn_grn_claer = new System.Windows.Forms.Button();
            this.btn_grn_save = new System.Windows.Forms.Button();
            this.txt_grn_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_up = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_arr_qty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_st_no = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_grn_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.er_grn_no = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_stockid = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_purchaseno = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_arrivalqty = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_unitprice = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_totalamount = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_grn_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_stockid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_purchaseno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_arrivalqty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_unitprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_totalamount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_pur_no);
            this.panel2.Controls.Add(this.btn_grn_claer);
            this.panel2.Controls.Add(this.btn_grn_save);
            this.panel2.Controls.Add(this.txt_grn_date);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_ta);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_up);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_arr_qty);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_st_no);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_grn_no);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 434);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.label3.Location = new System.Drawing.Point(34, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 127;
            this.label3.Text = "Purchase No";
            // 
            // txt_pur_no
            // 
            this.txt_pur_no.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pur_no.BackColor = System.Drawing.Color.White;
            this.txt_pur_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pur_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pur_no.Location = new System.Drawing.Point(38, 142);
            this.txt_pur_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pur_no.Name = "txt_pur_no";
            this.txt_pur_no.Size = new System.Drawing.Size(170, 19);
            this.txt_pur_no.TabIndex = 128;
            this.txt_pur_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pur_no_KeyPress);
            // 
            // btn_grn_claer
            // 
            this.btn_grn_claer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_grn_claer.BackColor = System.Drawing.Color.Transparent;
            this.btn_grn_claer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grn_claer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grn_claer.ForeColor = System.Drawing.Color.White;
            this.btn_grn_claer.Location = new System.Drawing.Point(223, 375);
            this.btn_grn_claer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_grn_claer.Name = "btn_grn_claer";
            this.btn_grn_claer.Size = new System.Drawing.Size(83, 31);
            this.btn_grn_claer.TabIndex = 126;
            this.btn_grn_claer.Text = "Clear";
            this.btn_grn_claer.UseVisualStyleBackColor = false;
            this.btn_grn_claer.Click += new System.EventHandler(this.btn_grn_claer_Click);
            // 
            // btn_grn_save
            // 
            this.btn_grn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_grn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_grn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grn_save.ForeColor = System.Drawing.Color.White;
            this.btn_grn_save.Location = new System.Drawing.Point(136, 375);
            this.btn_grn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_grn_save.Name = "btn_grn_save";
            this.btn_grn_save.Size = new System.Drawing.Size(82, 31);
            this.btn_grn_save.TabIndex = 125;
            this.btn_grn_save.Text = "Save";
            this.btn_grn_save.UseVisualStyleBackColor = false;
            this.btn_grn_save.Click += new System.EventHandler(this.btn_grn_save_Click);
            // 
            // txt_grn_date
            // 
            this.txt_grn_date.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.txt_grn_date.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_grn_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grn_date.Location = new System.Drawing.Point(146, 262);
            this.txt_grn_date.Margin = new System.Windows.Forms.Padding(2);
            this.txt_grn_date.Name = "txt_grn_date";
            this.txt_grn_date.Size = new System.Drawing.Size(284, 24);
            this.txt_grn_date.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Date";
            // 
            // txt_ta
            // 
            this.txt_ta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ta.BackColor = System.Drawing.Color.White;
            this.txt_ta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ta.Location = new System.Drawing.Point(260, 208);
            this.txt_ta.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ta.Name = "txt_ta";
            this.txt_ta.Size = new System.Drawing.Size(170, 19);
            this.txt_ta.TabIndex = 87;
            this.txt_ta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ava_qty_txt_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(256, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Total Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "GOOD RECIVED NOTE";
            // 
            // txt_up
            // 
            this.txt_up.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_up.BackColor = System.Drawing.Color.White;
            this.txt_up.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_up.Location = new System.Drawing.Point(38, 208);
            this.txt_up.Margin = new System.Windows.Forms.Padding(2);
            this.txt_up.Name = "txt_up";
            this.txt_up.Size = new System.Drawing.Size(170, 19);
            this.txt_up.TabIndex = 84;
            this.txt_up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_up_KeyPress);
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
            this.label5.Location = new System.Drawing.Point(34, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "Unit Price";
            // 
            // txt_arr_qty
            // 
            this.txt_arr_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_arr_qty.BackColor = System.Drawing.Color.White;
            this.txt_arr_qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_arr_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arr_qty.Location = new System.Drawing.Point(258, 142);
            this.txt_arr_qty.Margin = new System.Windows.Forms.Padding(2);
            this.txt_arr_qty.Name = "txt_arr_qty";
            this.txt_arr_qty.Size = new System.Drawing.Size(170, 19);
            this.txt_arr_qty.TabIndex = 72;
            this.txt_arr_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_arr_qty_KeyPress);
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
            this.label12.Location = new System.Drawing.Point(255, 61);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 62;
            this.label12.Text = "Stock ID";
            // 
            // txt_st_no
            // 
            this.txt_st_no.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_st_no.BackColor = System.Drawing.Color.White;
            this.txt_st_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_st_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_st_no.Location = new System.Drawing.Point(258, 86);
            this.txt_st_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_st_no.Name = "txt_st_no";
            this.txt_st_no.Size = new System.Drawing.Size(170, 19);
            this.txt_st_no.TabIndex = 65;
            this.txt_st_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_st_no_KeyPress);
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
            this.label9.Location = new System.Drawing.Point(32, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 71;
            this.label9.Text = "GRN No";
            // 
            // txt_grn_no
            // 
            this.txt_grn_no.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_grn_no.BackColor = System.Drawing.Color.White;
            this.txt_grn_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_grn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grn_no.Location = new System.Drawing.Point(35, 86);
            this.txt_grn_no.Margin = new System.Windows.Forms.Padding(2);
            this.txt_grn_no.Name = "txt_grn_no";
            this.txt_grn_no.Size = new System.Drawing.Size(170, 19);
            this.txt_grn_no.TabIndex = 68;
            this.txt_grn_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_grn_no_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(256, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Arrival Qty";
            // 
            // er_grn_no
            // 
            this.er_grn_no.ContainerControl = this;
            this.er_grn_no.Icon = ((System.Drawing.Icon)(resources.GetObject("er_grn_no.Icon")));
            // 
            // er_stockid
            // 
            this.er_stockid.ContainerControl = this;
            this.er_stockid.Icon = ((System.Drawing.Icon)(resources.GetObject("er_stockid.Icon")));
            // 
            // er_purchaseno
            // 
            this.er_purchaseno.ContainerControl = this;
            this.er_purchaseno.Icon = ((System.Drawing.Icon)(resources.GetObject("er_purchaseno.Icon")));
            // 
            // er_arrivalqty
            // 
            this.er_arrivalqty.ContainerControl = this;
            this.er_arrivalqty.Icon = ((System.Drawing.Icon)(resources.GetObject("er_arrivalqty.Icon")));
            // 
            // er_unitprice
            // 
            this.er_unitprice.ContainerControl = this;
            this.er_unitprice.Icon = ((System.Drawing.Icon)(resources.GetObject("er_unitprice.Icon")));
            // 
            // er_totalamount
            // 
            this.er_totalamount.ContainerControl = this;
            this.er_totalamount.Icon = ((System.Drawing.Icon)(resources.GetObject("er_totalamount.Icon")));
            // 
            // Good_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Good_Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Good_Note_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_grn_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_stockid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_purchaseno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_arrivalqty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_unitprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_totalamount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_up;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_arr_qty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_st_no;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_grn_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txt_grn_date;
        private System.Windows.Forms.Button btn_grn_claer;
        private System.Windows.Forms.Button btn_grn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pur_no;
        private System.Windows.Forms.ErrorProvider er_grn_no;
        private System.Windows.Forms.ErrorProvider er_stockid;
        private System.Windows.Forms.ErrorProvider er_purchaseno;
        private System.Windows.Forms.ErrorProvider er_arrivalqty;
        private System.Windows.Forms.ErrorProvider er_unitprice;
        private System.Windows.Forms.ErrorProvider er_totalamount;
    }
}