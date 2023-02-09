namespace M.S.BakersManagmentSystem
{
    partial class ST_Release
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ST_Release));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_proid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sr_clear = new System.Windows.Forms.Button();
            this.btn_sr_save = new System.Windows.Forms.Button();
            this.date_sr = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stid = new System.Windows.Forms.TextBox();
            this.txt_rqty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.er_proid = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_stockid = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_releaseqty = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_proid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_stockid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_releaseqty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_proid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_sr_clear);
            this.panel2.Controls.Add(this.btn_sr_save);
            this.panel2.Controls.Add(this.date_sr);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_stid);
            this.panel2.Controls.Add(this.txt_rqty);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 560);
            this.panel2.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(53, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Production ID";
            // 
            // txt_proid
            // 
            this.txt_proid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_proid.BackColor = System.Drawing.Color.White;
            this.txt_proid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_proid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proid.Location = new System.Drawing.Point(57, 108);
            this.txt_proid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_proid.Name = "txt_proid";
            this.txt_proid.Size = new System.Drawing.Size(213, 23);
            this.txt_proid.TabIndex = 92;
            this.txt_proid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_proid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "STOCK RELEASE";
            // 
            // btn_sr_clear
            // 
            this.btn_sr_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sr_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_sr_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sr_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sr_clear.ForeColor = System.Drawing.Color.White;
            this.btn_sr_clear.Location = new System.Drawing.Point(288, 443);
            this.btn_sr_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sr_clear.Name = "btn_sr_clear";
            this.btn_sr_clear.Size = new System.Drawing.Size(131, 39);
            this.btn_sr_clear.TabIndex = 80;
            this.btn_sr_clear.Text = "Clear";
            this.btn_sr_clear.UseVisualStyleBackColor = false;
            this.btn_sr_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_sr_save
            // 
            this.btn_sr_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sr_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_sr_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sr_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sr_save.ForeColor = System.Drawing.Color.White;
            this.btn_sr_save.Location = new System.Drawing.Point(144, 443);
            this.btn_sr_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sr_save.Name = "btn_sr_save";
            this.btn_sr_save.Size = new System.Drawing.Size(129, 39);
            this.btn_sr_save.TabIndex = 79;
            this.btn_sr_save.Text = "SAVE";
            this.btn_sr_save.UseVisualStyleBackColor = false;
            this.btn_sr_save.Click += new System.EventHandler(this.st_save_btn_Click);
            // 
            // date_sr
            // 
            this.date_sr.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.date_sr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_sr.Location = new System.Drawing.Point(57, 270);
            this.date_sr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_sr.Name = "date_sr";
            this.date_sr.Size = new System.Drawing.Size(445, 27);
            this.date_sr.TabIndex = 85;
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
            this.label6.Location = new System.Drawing.Point(284, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "Stock ID";
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
            this.label3.Location = new System.Drawing.Point(53, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Release Qty";
            // 
            // txt_stid
            // 
            this.txt_stid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_stid.BackColor = System.Drawing.Color.White;
            this.txt_stid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stid.Location = new System.Drawing.Point(288, 108);
            this.txt_stid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_stid.Name = "txt_stid";
            this.txt_stid.Size = new System.Drawing.Size(214, 23);
            this.txt_stid.TabIndex = 90;
            this.txt_stid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stid_KeyPress);
            // 
            // txt_rqty
            // 
            this.txt_rqty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_rqty.BackColor = System.Drawing.Color.White;
            this.txt_rqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rqty.Location = new System.Drawing.Point(57, 176);
            this.txt_rqty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_rqty.Name = "txt_rqty";
            this.txt_rqty.Size = new System.Drawing.Size(445, 23);
            this.txt_rqty.TabIndex = 61;
            this.txt_rqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rqty_KeyPress);
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
            this.label4.Location = new System.Drawing.Point(53, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Release Date";
            // 
            // er_proid
            // 
            this.er_proid.ContainerControl = this;
            this.er_proid.Icon = ((System.Drawing.Icon)(resources.GetObject("er_proid.Icon")));
            // 
            // er_stockid
            // 
            this.er_stockid.ContainerControl = this;
            this.er_stockid.Icon = ((System.Drawing.Icon)(resources.GetObject("er_stockid.Icon")));
            // 
            // er_releaseqty
            // 
            this.er_releaseqty.ContainerControl = this;
            this.er_releaseqty.Icon = ((System.Drawing.Icon)(resources.GetObject("er_releaseqty.Icon")));
            // 
            // ST_Release
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(596, 583);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ST_Release";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er_proid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_stockid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_releaseqty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sr_clear;
        private System.Windows.Forms.Button btn_sr_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_sr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_stid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_proid;
        private System.Windows.Forms.ErrorProvider er_proid;
        private System.Windows.Forms.ErrorProvider er_stockid;
        private System.Windows.Forms.ErrorProvider er_releaseqty;
    }
}