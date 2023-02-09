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
using System.Windows.Forms.DataVisualization.Charting;

namespace M.S.BakersManagmentSystem
{
    public partial class UserHomePage : Form
    {
        public UserHomePage()
        {
            InitializeComponent();


        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMView obj = new RMView();
            obj.Show();
        }


        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockView obj = new StockView();
            obj.Show();
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddProduction obj = new AddProduction();
            obj.Show();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

       

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SupplierView obj = new SupplierView();
            obj.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            LoginForm obj = new LoginForm();
            obj.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddSell obj = new AddSell();
            obj.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addGoodRecivedNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stockReleaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deliveryProductDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deliveryVahicaleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        Database db = new Database();

        
        
        private void st_order_ser_btn_Click(object sender, EventArgs e)
        {

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void load1_btn_Click(object sender, EventArgs e)
        {
        
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Good_Note obj = new Good_Note();
            obj.Show();
        }

        private void viewGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GN_View obj = new GN_View();
            obj.Show();
        }

        private void addSRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ST_Release obj = new ST_Release();
            obj.Show();
        }

        private void viewSRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ST_Release_View obj = new ST_Release_View();
            obj.Show();
        }

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddStock obj = new AddStock();
            obj.Show();
        }

        private void addSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduction obj = new AddProduction();
            obj.Show();
        }

        private void viewProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionView obj = new ProductionView();
            obj.Show();
        }

        private void deliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryPesonView obj = new DeliveryPesonView();
            obj.Show();
        }

        private void addSaleInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addIncomeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void supplierInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierInvoice obj = new SupplierInvoice();
            obj.Show();
        }

        private void saleInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void purchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrderView obj = new PurchaseOrderView();
            obj.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductView obj = new ProductView();
            obj.Show();
        }

        private void supplierInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupplierInvoiceView obj = new SupplierInvoiceView();
            obj.Show();
        }

        private void saleInvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaleInvoice obj = new SaleInvoice();
            obj.Show();
        }

        private void saleInvoiceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellInvoiceView obj = new SellInvoiceView();
            obj.Show();
        }

        private void incomeHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
