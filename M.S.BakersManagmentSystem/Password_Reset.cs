using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace M.S.BakersManagmentSystem
{
    public partial class Password_Reset : Form
    {
        public Password_Reset()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Please Enter Your New Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_cpass.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Please Confirm Your Password Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_pass.Text == txt_cpass.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE[dbo].[LoginAccount] SET [Account_Password] = '" + txt_cpass.Text + "'WHERE Account_UserName ='" + txt_username.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Reset Successfully");
            }
            else
            {
                MessageBox.Show("Password do not match eachother!");
            }
        }

        private void Password_Reset_Load(object sender, EventArgs e)
        {
            txt_username.Text = LoginForm.cmbval;
            txt_pass.UseSystemPasswordChar = true;
            txt_cpass.UseSystemPasswordChar = true;
        }

        private void Password_Reset_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginForm obj = new LoginForm();
            obj.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {

                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txt_cpass.UseSystemPasswordChar = false;
            }
            else
            {

                txt_cpass.UseSystemPasswordChar = true;
            }
        }
    }
}
