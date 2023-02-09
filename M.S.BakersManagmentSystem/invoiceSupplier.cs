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
    class invoiceSupplier
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;

    

        public invoiceSupplier()
        {
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        }

        public string Invoice_ID;
        public string GRN_No;
        public string Sup_ID;
        public string SI_Date;
        public double SI_Total_Amount;


       public void Sup_Invoice_save(string invoice_id, string grn_no, string sup_id, string si_date, double si_total_amount)
        {
            Invoice_ID = invoice_id;
            GRN_No = grn_no;
            Sup_ID = sup_id;
            SI_Date = si_date;
            SI_Total_Amount = si_total_amount;

            con.Open();
            cmd = new SqlCommand("Insert into Supplier_Invoice values (@a,@b,@c,@d,@e) ", con);

            cmd.Parameters.AddWithValue("a", Invoice_ID);
            cmd.Parameters.AddWithValue("b", GRN_No);
            cmd.Parameters.AddWithValue("c", Sup_ID);
            cmd.Parameters.AddWithValue("d", SI_Date);
            cmd.Parameters.AddWithValue("e", SI_Total_Amount);

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
