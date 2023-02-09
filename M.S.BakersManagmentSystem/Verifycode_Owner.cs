using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace M.S.BakersManagmentSystem
{
    public partial class Verifycode_Owner : Form
    {
        string randomCode;
        public static string to;
        public Verifycode_Owner()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            from = "ms.bakery.ms@gmail.com";
            pass = "ms@12345";
            to = ("ms.bakery.ms@gmail.com").ToString();
            messagebody = "Your Reset Code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Password Resetting Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Sent Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_verifycode_Click(object sender, EventArgs e)
        {
            if (randomCode == (txt_otp.Text).ToString())
            {
                to = "ms.bakery.ms@gmail.com";
                Password_Reset obj = new Password_Reset();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct Verification Code!");
            }
        }

        private void Verifycode_Owner_Load(object sender, EventArgs e)
        {
            label3.Text = "ms.b********@gmail.com";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm obj = new LoginForm();
            obj.Show();
        }
    }
}
