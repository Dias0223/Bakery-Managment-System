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
    class raw_material
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public string RM_No;
        public string RM_Name;

        public raw_material()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }

        public void add_RM(string rm_no, string rm_name)
        {
            RM_No = rm_no;
            RM_Name = rm_name;
           

            con.Open();
            cmd = new SqlCommand("Insert into Raw_Material values (@a,@b) ", con);

            cmd.Parameters.AddWithValue("a", rm_no);
            cmd.Parameters.AddWithValue("b", rm_name);

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
