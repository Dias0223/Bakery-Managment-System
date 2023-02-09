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
    public partial class SaleInvoice : Form
    {
        public SaleInvoice()
        {
            InitializeComponent();
            MaximizeBox = false;

        }

        private void SaleInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           try
            {

                invoiceSale IS = new invoiceSale();

                string si_id = txt_si_id.Text;
                string dp_id = txt_dp_id.Text;
                string sale_Date = pt_picker.Value.ToString("MM-dd-yyyy");
                string p_id = txt_p_id.Text;
                string s_qty = txt_sale_qty.Text;
                int sale_qty = Convert.ToInt32(s_qty);
                string price = txt_up.Text;
                double sale_unit_price = Convert.ToDouble(price);
                string total_amount = txt_totalp.Text;
                double sale_total_amount = Convert.ToDouble(total_amount);

                IS.Sale_Invoice_save(si_id, dp_id,p_id, sale_Date, sale_qty, sale_unit_price, sale_total_amount);
                clear();

           }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear()
        {
            txt_si_id.Clear();
            txt_dp_id.Clear();
            txt_p_id.Clear();
            txt_sale_qty.Clear();
            txt_up.Clear();
            txt_totalp.Clear();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
