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
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
            MaximizeBox = false;
            Pro_Load();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {

        }
        Database db = new Database();

        public void Pro_Load()
        {

            pro_table.DataSource = db.getData("Select * from Product");

        }
    }
}
