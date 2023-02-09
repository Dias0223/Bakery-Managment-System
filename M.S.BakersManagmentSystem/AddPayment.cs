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
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void btn_rm_save_Click(object sender, EventArgs e)
        {
            try
            {

                Payment pay = new Payment ();

                string pay_id = txt_pay_id.Text;
                string invoice_id = txt_invoice.Text;
                string pay_date = pay_picker.Value.ToString("MM-dd-yyyy");
                string amount = txt_pay_amount.Text;
                double pay_amount = Convert.ToDouble(amount);
                string comment = txt_descrip.Text;


                pay.Payment_Save(pay_id, invoice_id, pay_date, pay_amount, comment);

                clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear()
        {
            txt_pay_id.Clear();
            txt_invoice.Clear();
            txt_pay_amount.Clear();
            txt_descrip.Clear();
        }
    }
}
