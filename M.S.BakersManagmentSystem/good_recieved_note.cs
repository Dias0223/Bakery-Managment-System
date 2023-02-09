using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace M.S.BakersManagmentSystem
{
    class good_recieved_note
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public string GRN_No;
        public string ST_ID;
        public string Pur_No;
        public string Receive_Date;
        public int GRN_Arrival_Qty;
        public double Unit_Price;
        public double Total_Amount;


        public good_recieved_note()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }

        public void addGRN(string grn_no, string st_id, string pur_no, string receive_date,int grn_arrival_qty,double unit_price, double total_amount)
        {


            GRN_No = grn_no;
            ST_ID = st_id;
            Pur_No = pur_no;
            Receive_Date = receive_date;
            GRN_Arrival_Qty = grn_arrival_qty;
            Unit_Price = unit_price;
            Total_Amount = total_amount;

        con.Open();
            cmd = new SqlCommand("Insert into Goods_Recive_Note values (@a,@b,@c,@d,@e,@f,@g) ", con);

            cmd.Parameters.AddWithValue("a", grn_no);
            cmd.Parameters.AddWithValue("b", st_id);
            cmd.Parameters.AddWithValue("c", pur_no);
            cmd.Parameters.AddWithValue("d", receive_date);
            cmd.Parameters.AddWithValue("e", grn_arrival_qty);
            cmd.Parameters.AddWithValue("f", unit_price);
            cmd.Parameters.AddWithValue("g", total_amount);

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
