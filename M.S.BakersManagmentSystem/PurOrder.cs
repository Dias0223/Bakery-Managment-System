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
    public partial class PurOrder : Form
    {
        public PurOrder()
        {
            InitializeComponent();
            MaximizeBox = false;
            pur_Load();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (pur_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_purchaseno.SetError(pur_id_txt, "Please enter Purchase ID!");
                pur_id_txt.Focus();
                return;
            }
            else if (rm_txt.Text.Trim().Equals(string.Empty))
            {
                er_rmno.SetError(rm_txt, "Please enter Raw Material Number!");
                rm_txt.Focus();
                return;
            }
            else if (txt_sup_id.Text.Trim().Equals(string.Empty))
            {
                er_supplierID.SetError(txt_sup_id, "Please enter Supplier ID!");
                txt_sup_id.Focus();
                return;
            }
            else if (pur_qty_txt.Text.Trim().Equals(string.Empty))
            {
                er_purchaseqty.SetError(pur_qty_txt, "Please enter Purchase Quantity!");
                pur_qty_txt.Focus();
                return;
            }

            try
            {

                stock po = new stock();

                string pur_no = pur_id_txt.Text;
                string rm_id = rm_txt.Text;
                string sup_id = txt_sup_id.Text;
                string Purchases_qty = pur_qty_txt.Text;
                int purchases_qty = Convert.ToInt32(Purchases_qty);
                string purchases_date = pur_picker.Value.ToString("MM-dd-yyyy");

                po.add_PurOrder(pur_no, rm_id, sup_id, purchases_date, purchases_qty);
                pur_Load();
                clear();

           }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Database db = new Database();
        public void pur_Load()
        {

            pur_Table.DataSource = db.getData("Select * from Purchase_Order");

        }
        public void clear()
        {
            pur_id_txt.Clear();
            rm_txt.Clear();
            txt_sup_id.Clear();
            pur_qty_txt.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pur_id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_purchaseno.SetError(pur_id_txt, String.Empty);
        }

        private void rm_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_rmno.SetError(rm_txt, String.Empty);
        }

        private void txt_sup_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_supplierID.SetError(txt_sup_id, String.Empty);
        }

        private void pur_qty_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_purchaseqty.SetError(pur_qty_txt, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_purchaseqty.SetError(pur_qty_txt, "This Field Cannot Contain Letters!");
                pur_qty_txt.Focus();

                return;

            }
        }
    }
}
