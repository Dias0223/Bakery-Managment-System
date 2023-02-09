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
    public partial class ManagerOwnerHomePage : Form
    {
        public ManagerOwnerHomePage()
        {
            InitializeComponent();



        }


        

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            LoginForm obj = new LoginForm();
            obj.Show();
        }

        private void loginManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        Database db = new Database();
        
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddSupplier obj = new AddSupplier();
            obj.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayment obj = new AddPayment();
            obj.Show();
        }

        private void addIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionView obj = new ProductionView();
            obj.Show();
        }

        private void productionTargetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void custermOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editVehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addVehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryPersoncs obj = new DeliveryPersoncs();
            obj.Show();
        }

        private void viewVehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void removeVehicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewFinanceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewSellDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stockToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AddStock obj = new AddStock();
            obj.Show();
        }

        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void goodRecivedNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GN_View obj = new GN_View();
            obj.Show();
        }

        private void stockReleaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ST_Release_View obj = new ST_Release_View();
            obj.Show();
        }

        private void productRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct obj = new AddProduct();
            obj.Show();
        }

        private void productionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionView obj = new ProductionView();
            obj.Show();
        }

        private void deliveryProductInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addProductionTagertToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ManagerOwnerHomePage_Load(object sender, EventArgs e)
        {

            
        }

        private void productionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProductionReport obj = new ProductionReport();
            obj.Show();
        }

        private void deliveryProductionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellsReport obj = new SellsReport();
            obj.Show();
        }

        private void stockToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        
 
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addRowmattirialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addRawmattirials obj = new addRawmattirials();
            obj.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurOrder obj = new PurOrder();
            obj.Show();
        }

        private void viewRowmattirialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMView obj = new RMView();
            obj.Show();
        }

        private void addPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void paymentViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentView obj = new PaymentView();
            obj.Show();
        }

        private void incomeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void supplierInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierInvoiceView obj = new SupplierInvoiceView();
            obj.Show();
        }

        private void sellInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellInvoiceView obj = new SellInvoiceView();
            obj.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StPurchaseReport obj = new StPurchaseReport();
            obj.Show();
        }

        private void stockReleaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StReleaseReport obj = new StReleaseReport();
            obj.Show();
        }
    }
}
