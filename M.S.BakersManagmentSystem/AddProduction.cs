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
    public partial class AddProduction : Form
    {
        public AddProduction()
        {
            InitializeComponent();
            MaximizeBox = false;
            Pro_Load();
        }
    
        string pro_time;
        public void btn_save_Click(object sender, EventArgs e)
        {
            if (prod_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_proid.SetError(prod_id_txt, "Please enter Production ID!");
                prod_id_txt.Focus();
                return;
            }
            else if (pro_qty_txt.Text.Trim().Equals(string.Empty))
            {
                er_proqty.SetError(pro_qty_txt, "Please Select Production Quantity!");
                pro_qty_txt.Focus();
                return;
            }
            else if (pro_damage_txt.Text.Trim().Equals(string.Empty))
            {
                er_damageqty.SetError(pro_damage_txt, "Please enter Damage Quantity!");
                pro_damage_txt.Focus();
                return;
            }
            if (!morning_pro.Checked && !afternoon_pro.Checked)
            {
                er_protime.SetError(label10, "Please Select an Option!");
                label10.Focus();
                return;
            }
            else
            {
                er_protime.SetError(label10, String.Empty);
            }

            try {
            
                Production add_pro = new Production();

                string pro_id = prod_id_txt.Text;
                string Pro_Qty = pro_qty_txt.Text;
                string p_id = txt_p_id.Text;
                int pro_qty = Convert.ToInt32(Pro_Qty);
                string pro_Damage = pro_damage_txt.Text;
                int pro_damage = Convert.ToInt32(pro_Damage);
                string pro_date = pt_picker.Value.ToString("MM-dd-yyyy");

                add_pro.Production_save(pro_id,pro_qty,pro_damage,pro_date, pro_time,p_id);
                Pro_Load();
                clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        SqlConnection con;
       
        private void button1_Click(object sender, EventArgs e)
        {

        }
        Database db = new Database();
        public void Pro_Load()
        {

            Pro_Table.DataSource = db.getData("Select * from Production");

        }
        public void clear()
        {
            prod_id_txt.Clear();
            pro_qty_txt.Clear();
            pro_damage_txt.Clear();
            txt_p_id.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
       
        

        private void morning_CheckedChanged(object sender, EventArgs e)
        {
            pro_time = "Morning";
        }

        private void afternoon_CheckedChanged(object sender, EventArgs e)
        {
            pro_time = "Afternoon";
        }

        private void prod_id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_proid.SetError(prod_id_txt, String.Empty);
        }

        private void pro_qty_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_proqty.SetError(pro_qty_txt, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_proqty.SetError(pro_qty_txt, "This Field Cannot Contain Letters!");
                pro_qty_txt.Focus();

                return;

            }
        }

        private void pro_damage_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_damageqty.SetError(pro_damage_txt, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_damageqty.SetError(pro_damage_txt, "This Field Cannot Contain Letters!");
                pro_damage_txt.Focus();

                return;

            }
        }

        private void pt_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}