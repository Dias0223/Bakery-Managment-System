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
using CrystalDecisions.CrystalReports.Engine;
namespace M.S.BakersManagmentSystem
{
    public partial class ProductionReport : Form
    {
        public ProductionReport()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        string date1;
        string date2;
        SqlCommand cmd;
        SqlDataAdapter dr;
        private void btn_view_Click(object sender, EventArgs e)
        {
            date1 = prod_From_Data.Value.Year + "-" + prod_From_Data.Value.Month + "-" + prod_From_Data.Value.Day;
            date2 = prod_To_Date.Value.Year + "-" + prod_To_Date.Value.Month + "-" + prod_To_Date.Value.Day;

            con.Open();

            DataTable dt = new DataTable();

            cmd = new SqlCommand("select*from Production where Pro_Date between '" + date1 + "' and '" + date2 + "'", con);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            ProductionRep cr = new ProductionRep();
            cr.Database.Tables["Production"].SetDataSource(dt);
            TextObject Stock_Date_From = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["DateProFrom"];
            TextObject Stock_Date_To = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["DateProTo"];
            Stock_Date_From.Text = prod_From_Data.Text;
            Stock_Date_To.Text = prod_To_Date.Text;
            this.crystalReportViewer2.ReportSource = cr;
            con.Close();
        }

        private void ProductionReport_Load(object sender, EventArgs e)
        {

        }
    }
}
