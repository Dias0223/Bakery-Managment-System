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
    public partial class SupplierInvoiceView : Form
    {
        public SupplierInvoiceView()
        {
            InitializeComponent();
            MaximizeBox = false;
            Sup_Invoice_Load();
        }

        private void SupplierInvoiceView_Load(object sender, EventArgs e)
        {
            
        }
        Database db = new Database();
        public void Sup_Invoice_Load()
        {

            grn_table.DataSource = db.getData("Select * from Supplier_Invoice");

        }
    }
}
