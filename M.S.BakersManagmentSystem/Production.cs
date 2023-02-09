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
    class Production
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public string pro_ID;   // Production Save Variable
        public string P_ID;
        public int pro_Qty;
        public int pro_Damge;
        public int pro_Ava_Qty;
        public string Pro_Date;
        public string pro_Time;




        public Production()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }

        public void Production_save(string pro_id,int pro_qty,int pro_damage,string pro_date,string pro_time,string p_id) //Production Details Data Save 
        {
            pro_ID = pro_id;
            pro_Qty = pro_qty;
            pro_Damge = pro_damage;
            Pro_Date = pro_date;
            pro_Time = pro_time;
            P_ID = p_id;

            con.Open();
            cmd = new SqlCommand("Insert into Production values (@a,@b,@c,@d,@e,@f) ", con);

            cmd.Parameters.AddWithValue("a", pro_ID);
            cmd.Parameters.AddWithValue("b", pro_Qty);
            cmd.Parameters.AddWithValue("c", pro_Damge);
            cmd.Parameters.AddWithValue("d", Pro_Date);
            cmd.Parameters.AddWithValue("e", pro_Time);
            cmd.Parameters.AddWithValue("f", P_ID);



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
