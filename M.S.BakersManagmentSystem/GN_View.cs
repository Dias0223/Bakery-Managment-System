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
    public partial class GN_View : Form
    {
        public GN_View()
        {
            InitializeComponent();
            MaximizeBox = false;
            GRN_Table_Load();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Database db = new Database();
        public void GRN_Table_Load()
        {

            grn_table.DataSource = db.getData("Select * from Goods_Recive_Note");

        }

        private void btn_grnv_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void grn_search_btn_Click(object sender, EventArgs e)
        {
            /* if (grn_search_Txt.Text.Trim().Equals(string.Empty))
             {
                 er_searchproid.SetError(grn_search_Txt, "Please enter Valid Product ID!");
                 grn_search_Txt.Focus();
                 return;
             }*/

            grn_table.DataSource = db.getData("Select * from Goods_Recive_Note where GRN_No = '" + grn_search_Txt.Text + "'");
            grn_table.DataSource = db.getData("Select * from Goods_Recive_Note where GRN_No = '" + grn_search_Txt.Text + "'");
            grn_table.DataSource = db.getData("Select * from Goods_Recive_Note where GRN_No = '" + grn_search_Txt.Text + "'");
            grn_table.DataSource = db.getData("Select * from Goods_Recive_Note where GRN_No = '" + grn_search_Txt.Text + "'");
            clear();
        }
        public void clear()
        {
            grn_search_Txt.Clear();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            GRN_Table_Load();
        }
    }
}
