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
    class Supplier
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public string Sup_ID;
        public string Sup_Name;
        public string Sup_Add;
        public string Sup_Com;
        public int Sup_TP;
  


        public Supplier()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }

        public void Supplier_Save(string sup_id,string sup_name,string sup_add, int sup_tp,string sup_com)
        {
            Sup_ID = sup_id;
            Sup_Name = sup_name;
            Sup_Add = sup_add;
            Sup_Com = sup_com;
            Sup_TP = sup_tp;
           


            con.Open();
            cmd = new SqlCommand("Insert into Supplier values (@a,@b,@c,@d,@e) ", con);

            cmd.Parameters.AddWithValue("a", Sup_ID);
            cmd.Parameters.AddWithValue("b", Sup_Name);
            cmd.Parameters.AddWithValue("c", Sup_Add);
            cmd.Parameters.AddWithValue("d", Sup_TP);
            cmd.Parameters.AddWithValue("e", Sup_Com);
           

            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
            cmd.Dispose();


        }
        public void Supplier_update(string sup_id, string sup_name, string sup_add, int sup_tp, string sup_com)
        {
            Sup_ID = sup_id;
            Sup_Name = sup_name;
            Sup_Add = sup_add;
            Sup_Com = sup_com;
            Sup_TP = sup_tp;



            con.Open();
            cmd = new SqlCommand("update Supplier set Sup_Name=@a,Sup_Address=@b,Sup_TP=@c,Company_Name=@d where Sup_ID=@e", con);

           
            cmd.Parameters.AddWithValue("a", Sup_Name);
            cmd.Parameters.AddWithValue("b", Sup_Add);
            cmd.Parameters.AddWithValue("c", Sup_TP);
            cmd.Parameters.AddWithValue("d", Sup_Com);
            cmd.Parameters.AddWithValue("e", Sup_ID);


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
