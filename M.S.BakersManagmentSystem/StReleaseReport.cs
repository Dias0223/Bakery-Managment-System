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
    public partial class StReleaseReport : Form
    {
        public StReleaseReport()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CGOGL0J;Initial Catalog=M_S_Bakery;Integrated Security=True");
        string date1;
        string date2;
        SqlCommand cmd;
        SqlDataAdapter dr;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            date1 = Pro_From_Data.Value.Year + "-" + Pro_From_Data.Value.Month + "-" + Pro_From_Data.Value.Day;
            date2 = Pro_To_Date.Value.Year + "-" + Pro_To_Date.Value.Month + "-" + Pro_To_Date.Value.Day;

            con.Open();

            DataTable dt = new DataTable();

            cmd = new SqlCommand("select*from Stock_Release where Release_Date between '" + date1 + "' and '" + date2 + "'", con);
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dt);

            StReleaseRep cr = new StReleaseRep();
            cr.Database.Tables["Stock_Release"].SetDataSource(dt);
            TextObject Pro_Date_From = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["DateStRRFrom"];
            TextObject Pro_Date_To = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["DateStRRTo"];
            Pro_Date_From.Text = Pro_From_Data.Text;
            Pro_Date_To.Text = Pro_To_Date.Text;
            this.crystalReportViewer1.ReportSource = cr;
            con.Close();
        }
    }
}
