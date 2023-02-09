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
    public partial class SupplierInvoice : Form
    {
        public SupplierInvoice()
        {
            InitializeComponent();
            MaximizeBox = false;

        }

        private void SupplierInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                invoiceSupplier sup_in = new invoiceSupplier();

                string invoice_id = txt_in_id.Text;
                string grn_no = txt_grn_no.Text;
                string sup_id = txt_sup_id.Text;
                string si_date = inSu_picker.Value.ToString("MM-dd-yyyy");
                string price = txt_amont.Text;
                double si_total_amount = Convert.ToDouble(price);

                sup_in.Sup_Invoice_save(invoice_id, grn_no, sup_id, si_date, si_total_amount);
                clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear()
        {
            txt_in_id.Clear();
            txt_grn_no.Clear();
            txt_sup_id.Clear();
            txt_amont.Clear();
        }
    }
}
