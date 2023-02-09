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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
            Stock_Table_Load();
        }

       

        
        public void clear()
        {
            st_id_txt.Clear();
            st_name_txt.Clear();
            st_damage_txt.Clear();
            st_ava_txt.Clear();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void RS_btn_Click(object sender, EventArgs e)
        {
            if (st_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_StockID.SetError(st_id_txt, "Please enter Stock ID!");
                st_id_txt.Focus();
                return;
            }
            else if (st_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_StockName.SetError(st_name_txt, "Please enter Stock Name!");
                st_name_txt.Focus();
                return;
            }
            else if (st_damage_txt.Text.Trim().Equals(string.Empty))
            {
                er_Damageqty.SetError(st_damage_txt, "Please enter Damaged Quantity!");
                st_damage_txt.Focus();
                return;
            }
            else if (st_ava_txt.Text.Trim().Equals(string.Empty))
            {
                er_Availableqty.SetError(st_ava_txt, "Please enter Available Quantity!");
                st_ava_txt.Focus();
                return;
            }

            try
            { 

            stock st = new stock();



                string st_id = st_id_txt.Text;
                string st_name = st_name_txt.Text;
                string damage = st_damage_txt.Text;
                string ava = st_ava_txt.Text;


                int st_damage = Convert.ToInt32(damage);
                int st_ava = Convert.ToInt32(ava);



                st.update_rm(st_id, st_name, st_damage, st_ava);
                Stock_Table_Load();
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Database db = new Database();
        public void Stock_Table_Load()
        {

            stock_table.DataSource = db.getData("Select * from Stock");

        }
        private void rst_viewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void st_ava_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_Availableqty.SetError(st_ava_txt, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_Availableqty.SetError(st_ava_txt, "This Field Cannot Contain Letters!");
                st_ava_txt.Focus();
                return;
            }
        }

        private void st_ava_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_st_Click(object sender, EventArgs e)
        {
            if (st_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_StockID.SetError(st_id_txt, "Please enter Stock ID!");
                st_id_txt.Focus();
                return;
            }
            else if (st_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_StockName.SetError(st_name_txt, "Please enter Stock Name!");
                st_name_txt.Focus();
                return;
            }
            else if (st_damage_txt.Text.Trim().Equals(string.Empty))
            {
                er_Damageqty.SetError(st_damage_txt, "Please enter Damaged Quantity!");
                st_damage_txt.Focus();
                return;
            }
            else if (st_ava_txt.Text.Trim().Equals(string.Empty))
            {
                er_Availableqty.SetError(st_ava_txt, "Please enter Available Quantity!");
                st_ava_txt.Focus();
                return;
            }

            try
            {

                stock st = new stock();



                string st_id = st_id_txt.Text;
                string st_name = st_name_txt.Text;
                string Damage = st_damage_txt.Text;
                string Ava = st_ava_txt.Text;


                int st_damage = Convert.ToInt32(Damage);
                int st_ava = Convert.ToInt32(Ava);



                st.add_rm(st_id, st_name, st_damage, st_ava);
                Stock_Table_Load();
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void st_id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_StockID.SetError(st_id_txt, String.Empty);
        }

        private void st_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_StockName.SetError(st_name_txt, String.Empty);
        }

        private void st_damage_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_Damageqty.SetError(st_damage_txt, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_Damageqty.SetError(st_damage_txt, "This Field Cannot Contain Letters!");
                st_damage_txt.Focus();
                return;
            }
        }

        private void stock_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stock_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                st_id_txt.Text = stock_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                st_name_txt.Text = stock_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                st_damage_txt.Text = stock_table.Rows[e.RowIndex].Cells[2].Value.ToString();
                st_ava_txt.Text = stock_table.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
        }
    }
}
