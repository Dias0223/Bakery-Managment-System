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
    public partial class ProductionView : Form
    {
        public ProductionView()
        {
            InitializeComponent();
            Pro_Info_Load();
            MaximizeBox = false;
        }
        Database db = new Database();
        public void Pro_Info_Load()
        {

            prod_table.DataSource = db.getData("Select * from Production");

        }
        private void btn_search_Click(object sender, EventArgs e)
        {
        }
        public void clear()
        {

            datetimepicker.Value = DateTime.Now;

        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Pro_Info_Load();
            
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            prod_table.DataSource = db.getData("select * from Production where Pro_Date='" + datetimepicker.Value + "'");
            
        }
    }
}
