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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please Select The Usertype!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_pass.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Please enter your Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
            con.Open();
            SqlDataAdapter dr = new SqlDataAdapter("Select * from LoginAccount where Account_UserName = '" + txt_username.Text + "' and Account_Password='" + txt_pass.Text + "'", con);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (cmb_lgtype.SelectedItem == null)
                {
                    MessageBox.Show("Please select the user profile first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmb_lgtype.SelectedIndex == 0)
                {
                    this.Hide();
                    UserHomePage obj = new UserHomePage();
                    obj.Show();
                }
                else if (cmb_lgtype.SelectedIndex == 1)
                {
                    this.Hide();
                    ManagerOwnerHomePage obj = new ManagerOwnerHomePage();
                    obj.Show();
                }
            }
            else
            {
                MessageBox.Show("Please Check your Password again!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pass.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_lgtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_lgtype.SelectedIndex == 0)
            {
                txt_username.Text = "Staff";
            }
            else if (cmb_lgtype.SelectedIndex == 1)
            {
                txt_username.Text = "Administrator";
            }
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

        private void btn_recoverypass_Click(object sender, EventArgs e)
        {
            cmbval = txt_username.Text;

            if (cmb_lgtype.SelectedItem == null)
            {
                MessageBox.Show("Please select the user profile first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmb_lgtype.SelectedIndex == 0)
            {

                this.Hide();
                Verifycode_Operator obj = new Verifycode_Operator();
                obj.Show();
            }
            else if (cmb_lgtype.SelectedIndex == 1)
            {

                this.Hide();
                Verifycode_Owner obj = new Verifycode_Owner();
                obj.Show();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;

            cmb_lgtype.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select DISTINCT Account_ID FROM LoginAccount";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


                foreach (DataRow dr in dt.Rows)
                {
                    cmb_lgtype.Items.Add(dr["Account_ID"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static string cmbval
        {

            get; set;
        }
    }
}
