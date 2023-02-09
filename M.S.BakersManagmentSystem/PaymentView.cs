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
    public partial class PaymentView : Form
    {
        public PaymentView()
        {
            InitializeComponent();
            MaximizeBox = false;
            Payment_Load();
        }

        private void PaymentView_Load(object sender, EventArgs e)
        {

        }
        Database db = new Database();
        public void Payment_Load()
        {

            grn_table.DataSource = db.getData("Select * from Payment");

        }
    }
}
