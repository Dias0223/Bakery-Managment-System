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
    class stock
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public string ST_ID;
        public string RM_ID;
        public int ST_Damage_Qty;
        public int ST_Ava_Qty;

        public string Pro_No;
        public string Release_Date;
        public int Release_Qty;

        public string Pur_No;
        public string Sup_ID;
        public string Purchases_Date;
        public int Purchases_Qty;

        public stock()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }

        public void add_rm(string st_id, string rm_id, int damage_qty, int ava_qty)
        {
            ST_ID = st_id;
            RM_ID = rm_id;
            ST_Damage_Qty = damage_qty;
            ST_Ava_Qty = ava_qty;

            con.Open();
            cmd = new SqlCommand("Insert into Stock values (@a,@b,@c,@d)", con);

            cmd.Parameters.AddWithValue("a", st_id);
            cmd.Parameters.AddWithValue("b", rm_id);
            cmd.Parameters.AddWithValue("c", damage_qty);
            cmd.Parameters.AddWithValue("d", ava_qty);
            

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            cmd.Dispose();


        }

        public void update_rm(string st_id, string rm_id, int damage_qty, int ava_qty)
        {
            ST_ID = st_id;
            RM_ID = rm_id;
            ST_Damage_Qty = damage_qty;
            ST_Ava_Qty = ava_qty;

        con.Open();
            cmd = new SqlCommand("update Stock set RM_No=@a,ST_Damage_Qty=@b,ST_Ava_Qty=@c where ST_ID=@d", con);


            cmd.Parameters.AddWithValue("a", rm_id);
            cmd.Parameters.AddWithValue("b", damage_qty);
            cmd.Parameters.AddWithValue("c", ava_qty);
            cmd.Parameters.AddWithValue("d", st_id);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            cmd.Dispose();


        }

        public void add_ReleaseStock(string st_id, string pro_no, int release_qty, string release_date)
        {
            ST_ID = st_id;
            Pro_No = pro_no;
            Release_Qty = release_qty;
            Release_Date = release_date;

            con.Open();
            cmd = new SqlCommand("Insert into Stock_Release values (@a,@b,@c,@d) ", con);

            cmd.Parameters.AddWithValue("a", st_id);
            cmd.Parameters.AddWithValue("b", pro_no);
            cmd.Parameters.AddWithValue("c", release_qty);
            cmd.Parameters.AddWithValue("d", release_date);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            cmd.Dispose();


        }
        public void add_PurOrder(string pur_no, string rm_id, string sup_id, string purchases_date, int purchases_qty)
        {
            Pur_No = pur_no;
            RM_ID = rm_id;
            Sup_ID = sup_id;
            Purchases_Date = purchases_date;
            Purchases_Qty = purchases_qty;

            con.Open();
            cmd = new SqlCommand("Insert into Purchase_Order values (@a,@b,@c,@d,@e) ", con);

            cmd.Parameters.AddWithValue("a", Pur_No);
            cmd.Parameters.AddWithValue("b", RM_ID);
            cmd.Parameters.AddWithValue("c", Sup_ID);
            cmd.Parameters.AddWithValue("d", Purchases_Date);
            cmd.Parameters.AddWithValue("e", Purchases_Qty);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            cmd.Dispose();


        }
        public void get_Release_stock_Qty(string St_ID, int Release_After_Available_Qty)
        {
            ST_ID = St_ID;
            ST_Ava_Qty = Release_After_Available_Qty;

            con.Open();
            cmd = new SqlCommand("update Stock set ST_Ava_Qty=@a where ST_ID=@b", con);
            cmd.Parameters.AddWithValue("a", ST_Ava_Qty);
            cmd.Parameters.AddWithValue("b", ST_ID);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)

                con.Close();
            cmd.Dispose();
        }
        public void get_New_Stock_Qty(string st_id, int New_Total_Qty)
        {

            ST_ID = st_id;
            ST_Ava_Qty = New_Total_Qty;

            con.Open();
            cmd = new SqlCommand("update Stock set ST_Ava_Qty=@a where ST_ID=@b", con);
            cmd.Parameters.AddWithValue("a", ST_Ava_Qty);
            cmd.Parameters.AddWithValue("b", ST_ID);

            int i = cmd.ExecuteNonQuery();
            if (i == 1)

                con.Close();
            cmd.Dispose();
        }


    }   
}
