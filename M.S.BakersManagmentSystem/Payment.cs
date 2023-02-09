using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace M.S.BakersManagmentSystem
{
    class Payment
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public string Pay_ID;
        public string Invoice_ID;
        public string Pay_Date;
        public double Pay_Amount;
        public string Pay_Discription;

        public Payment()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }

        public void Payment_Save(string pay_id,string invoice_id,string pay_date,double pay_amount ,string comment)
        {
            Pay_ID = pay_id;
            Invoice_ID = invoice_id;
            Pay_Date = pay_date;
            Pay_Amount = pay_amount;
            Pay_Discription = comment;

            con.Open();
            cmd = new SqlCommand("Insert into Payment values (@a,@b,@c,@d,@e) ", con);

            cmd.Parameters.AddWithValue("a", Pay_ID);
            cmd.Parameters.AddWithValue("b", Invoice_ID);
            cmd.Parameters.AddWithValue("c", Pay_Date);
            cmd.Parameters.AddWithValue("d", Pay_Amount);
            cmd.Parameters.AddWithValue("e", Pay_Discription);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            cmd.Dispose();


        }
    }
}
