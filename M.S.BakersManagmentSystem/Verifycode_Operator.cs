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
using System.Net;
using System.Net.Mail;

namespace M.S.BakersManagmentSystem
{
    public partial class Verifycode_Operator : Form
    {
        string randomCode;
        public static string to;
        public Verifycode_Operator()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
            con.Open();
            SqlDataAdapter dr = new SqlDataAdapter("SELECT * from LoginAccount where Account_Email = '" + txt_email.Text + "' and Account_ID = 'Operator'", con);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                try
                {

                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("ms.bakery.ms@gmail.com");
                    msg.To.Add(txt_email.Text);
                    msg.Subject = "Password Resetting Code";
                    msg.Body = "Your Reset Code is " + randomCode;

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = "ms.bakery.ms@gmail.com";
                    ntcd.Password = "ms@12345";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Mail sent Successfully");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Verifycode_Operator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginForm obj = new LoginForm();
            obj.Show();
        }

        private void btn_verifycode_Click(object sender, EventArgs e)
        {
            if (randomCode == (txt_otp.Text).ToString())
            {
                to = txt_email.Text;
                Password_Reset obj = new Password_Reset();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct Verification Code!");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm obj = new LoginForm();
            obj.Show();
        }
    }
}
