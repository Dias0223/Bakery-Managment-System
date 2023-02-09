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
    class invoiceSale
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

        public string SI_ID;
        public string DP_ID;
        public string P_ID;
        public string Sale_Date;
        public int Sale_Qty;
        public double Sale_Unit_Price;
        public double Sale_Total_Amount;


        public invoiceSale()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }

        public void Sale_Invoice_save(string si_id, string dp_id,string p_id, string sale_Date, int sale_qty, double sale_unit_price, double sale_total_amount)

        {
            SI_ID = si_id;
            DP_ID = dp_id;
            Sale_Date = sale_Date;
            P_ID = p_id;
            Sale_Qty = sale_qty;
            Sale_Unit_Price = sale_unit_price;
            Sale_Total_Amount = sale_total_amount;

            con.Open();
            cmd = new SqlCommand("Insert into Sale_Invoice values (@a,@b,@c,@d,@e,@f,@g) ", con);

            cmd.Parameters.AddWithValue("a", SI_ID);
            cmd.Parameters.AddWithValue("b", DP_ID);
            cmd.Parameters.AddWithValue("c", P_ID);
            cmd.Parameters.AddWithValue("d", Sale_Date);
            cmd.Parameters.AddWithValue("e", Sale_Qty);
            cmd.Parameters.AddWithValue("f", Sale_Unit_Price);
            cmd.Parameters.AddWithValue("g", Sale_Total_Amount);

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
