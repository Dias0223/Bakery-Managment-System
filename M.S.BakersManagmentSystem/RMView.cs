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
    public partial class RMView : Form
    {
        public RMView()
        {
            InitializeComponent();
            MaximizeBox = false;
            Product_Table_Load();
        }

        private void rm_info_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Database db = new Database();
        public void Product_Table_Load()
        {

            rm_info_table.DataSource = db.getData("Select * from Raw_Material");

        }
    }
}
