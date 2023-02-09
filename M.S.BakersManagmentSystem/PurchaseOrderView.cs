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
    public partial class PurchaseOrderView : Form
    {
        public PurchaseOrderView()
        {
            InitializeComponent();
            MaximizeBox = false;
            pur_Load();
        }

        private void PurchaseOrderView_Load(object sender, EventArgs e)
        {

        }
        Database db = new Database();
        public void pur_Load()
        {

            pur_Table.DataSource = db.getData("Select * from Purchase_Order");

        }
    }
}
