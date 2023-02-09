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
    public partial class SellInvoiceView : Form
    {
        public SellInvoiceView()
        {
            InitializeComponent();
            MaximizeBox = false;
            Sale_Invoice_Load();
        }

        private void SellInvoiceView_Load(object sender, EventArgs e)
        {

        }
        Database db = new Database();
        public void Sale_Invoice_Load()
        {

            grn_table.DataSource = db.getData("Select * from  Sale_Invoice");

        }
    }
}
