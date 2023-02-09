using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M.S.BakersManagmentSystem
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            MaximizeBox = false;
            Pro_Load();
        }

        private void pro_save_btn_Click_1(object sender, EventArgs e)
        {
            if (pro_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_proID.SetError(pro_id_txt, "Please enter Product ID!");
                pro_id_txt.Focus();
                return;
            }
            else if (pro_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_proName.SetError(pro_name_txt, "Please enter Product Name!");
                pro_name_txt.Focus();
                return;
            }
            else if (pro_price_txt.Text.Trim().Equals(string.Empty))
            {
                er_proUPrice.SetError(pro_price_txt, "Please enter Unit Price of the Product!");
                pro_price_txt.Focus();
                return;
            }
            

           try
            {

                Product pro = new Product();

                string p_id = pro_id_txt.Text;
                string p_name = pro_name_txt.Text;
                string price = pro_price_txt.Text;
                double p_unit_price = Convert.ToDouble(price);

                pro.Product_save(p_id, p_name, p_unit_price);
                Pro_Load();
                clear();
                
           }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Database db = new Database();

        public void Pro_Load()
        {

            pro_table.DataSource = db.getData("Select * from Product");

        }
        public void clear()
        {
            pro_id_txt.Clear();
            pro_name_txt.Clear();
            pro_price_txt.Clear();
            txt_proID.Clear();



        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear(); 
        }

        private void pro_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (pro_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_proID.SetError(pro_id_txt, "Please enter Product ID!");
                pro_id_txt.Focus();
                return;
            }
            else if (pro_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_proName.SetError(pro_name_txt, "Please enter Product Name!");
                pro_name_txt.Focus();
                return;
            }
            else if (pro_price_txt.Text.Trim().Equals(string.Empty))
            {
                er_proUPrice.SetError(pro_price_txt, "Please enter Unit Price of the Product!");
                pro_price_txt.Focus();
                return;
            }

            try
            {

                Product pro = new Product();

                string p_id = pro_id_txt.Text;
                string p_name = pro_name_txt.Text;
                string price = pro_price_txt.Text;
                double p_unit_price = Convert.ToDouble(price);

                pro.Product_Update(p_id, p_name, p_unit_price);
                Pro_Load();
                clear();
            
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_proID.Text.Trim().Equals(string.Empty))
            {
                er_searchproid.SetError(txt_proID, "Please enter Valid Product ID!");
                txt_proID.Focus();
                return;
            }

            pro_table.DataSource = db.getData("Select * from Product where P_ID = '" + txt_proID.Text + "'");
            clear();
        }

        private void lll_Click(object sender, EventArgs e)
        {
            Pro_Load();
        }

        private void pro_table_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (pro_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                pro_id_txt.Text = pro_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                pro_name_txt.Text = pro_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                pro_price_txt.Text = pro_table.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void txt_proID_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_proID.SetError(txt_proID, String.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Remove Button Validations

            if (pro_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_proID.SetError(pro_id_txt, "Please enter Product ID!");
                pro_id_txt.Focus();
                return;
            }
            else if (pro_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_proName.SetError(pro_name_txt, "Please enter Product Name!");
                pro_name_txt.Focus();
                return;
            }
            else if (pro_price_txt.Text.Trim().Equals(string.Empty))
            {
                er_proUPrice.SetError(pro_price_txt, "Please enter Unit Price of the Product!");
                pro_price_txt.Focus();
                return;
            }

            // Coding Here

        }

        private void pro_id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_proID.SetError(pro_id_txt, String.Empty);
        }

        private void pro_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_proName.SetError(pro_name_txt, String.Empty);
        }

        private void pro_price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_proUPrice.SetError(pro_price_txt, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_proUPrice.SetError(pro_price_txt, "This Field Cannot Contain Letters!");
                pro_price_txt.Focus();

                return;

            }
        }
    }
}
