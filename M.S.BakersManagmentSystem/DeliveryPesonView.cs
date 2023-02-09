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
    public partial class DeliveryPesonView : Form
    {
        public DeliveryPesonView()
        {
            InitializeComponent();
            DP_Info_Load();
            MaximizeBox = false;
        }
        Database db = new Database();
        private void btn_search_Click(object sender, EventArgs e)
        {
            dp_table.DataSource = db.getData("Select * from Delivery_Person where DP_ID = '" + txt_sreach.Text + "'");
        }
        public void DP_Info_Load()
        {

            dp_table.DataSource = db.getData("Select * from Delivery_Person");

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DP_Info_Load();
        }
    }
}
