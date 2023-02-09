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
    class deliveryperson
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public deliveryperson()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }

        public string DP_ID;
        public string DP_Name;
        public string DP_Address;
        public int DP_TP;

        public void Delivery_Person_save(string dp_id, string dp_name, string dp_address, int dp_tp)
        {
            DP_ID = dp_id;
            DP_Name = dp_name;
            DP_Address = dp_address;
            DP_TP = dp_tp;

            con.Open();
            cmd = new SqlCommand("Insert into Delivery_Person values (@a,@b,@c,@d) ", con);

            cmd.Parameters.AddWithValue("a", DP_ID);
            cmd.Parameters.AddWithValue("b", DP_Name);
            cmd.Parameters.AddWithValue("c", DP_Address);
            cmd.Parameters.AddWithValue("d", DP_TP);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            cmd.Dispose();

        }
        public void Delivery_Person_Update(string dp_id, string dp_name, string dp_address, int dp_tp)
        {
            DP_ID = dp_id;
            DP_Name = dp_name;
            DP_Address = dp_address;
            DP_TP = dp_tp;

            con.Open();
            cmd = new SqlCommand("update Delivery_Person set DP_Name=@a,DP_Address=@b,DP_TP=@c where DP_ID=@d", con);


            cmd.Parameters.AddWithValue("a", DP_Name);
            cmd.Parameters.AddWithValue("b", DP_Address);
            cmd.Parameters.AddWithValue("c", DP_TP);
            cmd.Parameters.AddWithValue("d", DP_ID);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            cmd.Dispose();


        }

    }
}
