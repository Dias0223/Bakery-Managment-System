using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace M.S.BakersManagmentSystem
{
    public partial class StockView : Form
    {
        public StockView()
        {
            InitializeComponent();
            STV_Viewer_Load();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        public void STV_Viewer_Load()
        {
            SqlConnection con;
            SqlDataAdapter da;
            con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
            con.Open();
            da = new SqlDataAdapter("Select * from Rawmaterial_Stock", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            stock_viewer.DataSource = dt;
            con.Close();

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            STV_Viewer_Load();
        }
    }
}
