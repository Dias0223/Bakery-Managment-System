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
    class Product
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public string P_ID;               //Product_Varibales
        public string P_Name;
        public double P_Unit_Price;


        public Product()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }
        
        public void Product_save(string p_id,string p_name,double p_unit_price)
        {
            P_ID = p_id;
            P_Name = p_name;
            P_Unit_Price = p_unit_price;


        con.Open();
                cmd = new SqlCommand("Insert into Product values (@a,@b,@c) ", con);

                cmd.Parameters.AddWithValue("a", P_ID);
                cmd.Parameters.AddWithValue("b", P_Name);
                cmd.Parameters.AddWithValue("c", P_Unit_Price);

            int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
           
        }
        public void Product_Update(string p_id, string p_name, double p_unit_price)
        {
            P_ID = p_id;
            P_Name = p_name;
            P_Unit_Price = p_unit_price;

            con.Open();
            cmd = new SqlCommand("update Product set P_Name=@a,P_Unit_Price=@b where P_ID=@c", con);


            
            cmd.Parameters.AddWithValue("a", P_Name);
            cmd.Parameters.AddWithValue("b", P_Unit_Price);
            cmd.Parameters.AddWithValue("c", P_ID);


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
