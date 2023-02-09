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
    public partial class Good_Note : Form
    {
        public Good_Note()
        {
            InitializeComponent();
        }

        private void st_save_btn_Click(object sender, EventArgs e)
        {
           
        }

        
        private void load_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void Good_Note_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public void total_amount()
        {
            string Grn_arrival_qty = txt_arr_qty.Text;
            string Unit_price = txt_up.Text;
            
            double arr_qty = Convert.ToDouble(Grn_arrival_qty);
            double uprice = Convert.ToDouble(Unit_price);


            double amount = arr_qty * uprice;

            txt_ta.Text = "" + amount;
        }
        

        private void Ava_qty_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            total_amount();
        }

       
        public void clear()
        {

        
            txt_st_no.Clear();
            txt_grn_no.Clear();
            txt_arr_qty.Clear();
            txt_up.Clear();
            txt_ta.Clear();
            txt_pur_no.Clear();
            txt_grn_date.Value = DateTime.Now;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_grn_save_Click(object sender, EventArgs e)
        {
            if (txt_grn_no.Text.Trim().Equals(string.Empty))
            {
                er_grn_no.SetError(txt_grn_no, "Please enter Good Recieved Note Number!");
                txt_grn_no.Focus();
                return;
            }
            else if (txt_st_no.Text.Trim().Equals(string.Empty))
            {
                er_stockid.SetError(txt_st_no, "Please Enter Stock ID!");
                txt_st_no.Focus();
                return;
            }
            else if (txt_pur_no.Text.Trim().Equals(string.Empty))
            {
                er_purchaseno.SetError(txt_pur_no, "Please Enter Purchase Number!");
                txt_pur_no.Focus();
                return;
            }
            else if (txt_arr_qty.Text.Trim().Equals(string.Empty))
            {
                er_arrivalqty.SetError(txt_arr_qty, "Please enter Arrival Quantity!");
                txt_arr_qty.Focus();
                return;
            }
            else if (txt_up.Text.Trim().Equals(string.Empty))
            {
                er_unitprice.SetError(txt_up, "Please Enter Unit Price!");
                txt_up.Focus();
                return;
            }
            else if (txt_ta.Text.Trim().Equals(string.Empty))
            {
                er_totalamount.SetError(txt_ta, "Please Select Total Amount!");
                txt_ta.Focus();
                return;
            }

            try
            {

                good_recieved_note note = new good_recieved_note();

                string grn_no = txt_grn_no.Text;
                string st_id = txt_st_no.Text;
                string pur_no = txt_pur_no.Text;
                string Grn_arrival_qty = txt_arr_qty.Text;
                string Unit_price = txt_up.Text;
                string Total_amount = txt_ta.Text;
                string receive_date = txt_grn_date.Value.ToString("MM-dd-yyyy");

                int grn_arrival_qty = Convert.ToInt32(Grn_arrival_qty);
                double unit_price = Convert.ToDouble(Unit_price);
                double total_amount = Convert.ToDouble(Total_amount);

                note.addGRN(grn_no, st_id,pur_no,receive_date,grn_arrival_qty,unit_price,total_amount);
                Add_New_Stock_Qty();
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_grn_claer_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_grn_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_grn_no.SetError(txt_grn_no, String.Empty);
        }
        SqlConnection con;
        public void Add_New_Stock_Qty()
        {
            string Ava_Qty = txt_arr_qty.Text;
            int ava_qty = Convert.ToInt32(Ava_Qty);
            int New_Total_Qty;
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ST_Ava_Qty from Stock where ST_ID= '" + txt_st_no.Text + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            StringBuilder sb = new StringBuilder();

            while (reader.Read())
            {
                int Ava_Product_Qty = Convert.ToInt32(reader[0]);
                New_Total_Qty = Ava_Product_Qty + ava_qty;

                string st_id = txt_st_no.Text;

                stock Add_After_Qty = new stock();
                Add_After_Qty.get_New_Stock_Qty(st_id, New_Total_Qty);

            }
            con.Close();

        }
        private void txt_st_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_stockid.SetError(txt_st_no, String.Empty);
        }

        private void txt_pur_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_purchaseno.SetError(txt_pur_no, String.Empty);   
        }

        private void txt_arr_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_arrivalqty.SetError(txt_arr_qty, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_arrivalqty.SetError(txt_arr_qty, "This Field Cannot Contain Letters!");
                txt_arr_qty.Focus();

                return;

            }
        }

        private void txt_up_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_unitprice.SetError(txt_up, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_unitprice.SetError(txt_up, "This Field Cannot Contain Letters!");
                txt_up.Focus();

                return;

            }
        }
    }
}
