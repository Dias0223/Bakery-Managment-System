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
    public partial class ST_Release_View : Form
    {
        public ST_Release_View()
        {
            InitializeComponent();
            MaximizeBox = false;
            Product_Table_Load();
        }
        Database db = new Database();
        public void Product_Table_Load()
        {

            grn_table.DataSource = db.getData("Select * from Stock_Release");

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void R_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grn_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
