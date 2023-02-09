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
    public partial class SupplierView : Form
    {
        public SupplierView()
        {
            InitializeComponent();
            MaximizeBox = false;
            Sup_Info_Load();
        }
        Database db = new Database();
        public void Sup_Info_Load()
        {

            Supplier_Table.DataSource = db.getData("Select * from Supplier");

        }
        private void sup_serach_btn_Click(object sender, EventArgs e)
        {
            Supplier_Table.DataSource = db.getData("Select * from Supplier where Sup_ID = '" + txt_sreach.Text + "'");
        }
        public void clear()
        {

            txt_sreach.Clear();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Sup_Info_Load();
        }
    }
}
