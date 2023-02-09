using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace M.S.BakersManagmentSystem
{
    public partial class ST_Release : Form
    {
        public ST_Release()
        {
            InitializeComponent();
            MaximizeBox = false;
            
        }


        public void st_save_btn_Click(object sender, EventArgs e)
        {
            if (txt_proid.Text.Trim().Equals(string.Empty))
            {
                er_proid.SetError(txt_proid, "Please enter Production ID!");
                txt_proid.Focus();
                return;
            }
            else if (txt_stid.Text.Trim().Equals(string.Empty))
            {
                er_stockid.SetError(txt_stid, "Please enter Stock ID!");
                txt_stid.Focus();
                return;
            }
            else if (txt_rqty.Text.Trim().Equals(string.Empty))
            {
                er_releaseqty.SetError(txt_rqty, "Please enter Release Quantity!");
                txt_rqty.Focus();
                return;
            }
           
            try
            {
                stock RS = new stock();
                string st_id = txt_stid.Text;
                string pro_no = txt_proid.Text;
                string Release_qty = txt_rqty.Text;
                int release_qty = Convert.ToInt32(Release_qty);


                string release_date = date_sr.Value.ToString("MM-dd-yyyy");


                RS.add_ReleaseStock(st_id,pro_no,release_qty,release_date);
                Update_Product_Ava_Qty();
                clear();

           }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        SqlConnection con;
        public void Update_Product_Ava_Qty()
        {
            int Release_After_Available_Qty; 
            string Re_qty = txt_rqty.Text;
            int re_qty = Convert.ToInt32(Re_qty);

            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ST_Ava_Qty from Stock where ST_ID = '" + txt_stid.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            StringBuilder sb = new StringBuilder();

            while (reader.Read())
            {
                int Available_Qty = Convert.ToInt32(reader[0]);
                Release_After_Available_Qty = Available_Qty - re_qty;
                string St_ID = txt_stid.Text;

                stock Release_After_Qty = new stock();
                Release_After_Qty.get_Release_stock_Qty(St_ID, Release_After_Available_Qty);

            }
            
            con.Close();

        }
        public void clear()
        {
            txt_stid.Clear();
            txt_rqty.Clear();
            txt_proid.Clear();
            date_sr.Value = DateTime.Now;
            

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_proid_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_proid.SetError(txt_proid, String.Empty);
        }

        private void txt_stid_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_stockid.SetError(txt_stid, String.Empty);    
        }

        private void txt_rqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_releaseqty.SetError(txt_rqty, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_releaseqty.SetError(txt_rqty, "This Field Cannot Contain Letters!");
                txt_rqty.Focus();

                return;

            }
        }
    }
}
