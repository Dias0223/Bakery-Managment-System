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
    public partial class DeliveryPersoncs : Form
    {
        public DeliveryPersoncs()
        {
            InitializeComponent();
            MaximizeBox = false;
            dp_Load();
        }

        private void DeliveryPersoncs_Load(object sender, EventArgs e)
        {

        }

        private void btn_dp_save_Click(object sender, EventArgs e)
        {
            if (dp_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpid.SetError(dp_id_txt, "Please enter Delivery Person's ID!");
                dp_id_txt.Focus();
                return;
            }
            else if (dp_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpname.SetError(dp_name_txt, "Please enter Delivery Person's Name!");
                dp_name_txt.Focus();
                return;
            }
            else if (dp_add_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpaddress.SetError(dp_add_txt, "Please enter Delivery Person's Address!");
                dp_add_txt.Focus();
                return;
            }
            else if (dp_tp_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpcontactno.SetError(dp_tp_txt, "Please enter Delivery Person's Contact Number!");
                dp_tp_txt.Focus();
                return;
            }

            try
            {

                deliveryperson dp = new deliveryperson();

                string dp_id = dp_id_txt.Text;
                string dp_name = dp_name_txt.Text;
                string dp_address = dp_add_txt.Text;
                string tp = dp_tp_txt.Text;
                int dp_tp = Convert.ToInt32(tp);

                dp.Delivery_Person_save(dp_id,dp_name, dp_address,dp_tp);
                dp_Load();
                clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear()
        {
            dp_id_txt.Clear();
            dp_name_txt.Clear();
            dp_add_txt.Clear();
            dp_tp_txt.Clear();
            txt_proID.Clear();

        }

        private void btn_dp_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        Database db = new Database();
        public void dp_Load()
        {

            dp_table.DataSource = db.getData("Select * from Delivery_Person");

        }

        private void btn_dp_update_Click(object sender, EventArgs e)
        {
            if (dp_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpid.SetError(dp_id_txt, "Please enter Delivery Person's ID!");
                dp_id_txt.Focus();
                return;
            }
            else if (dp_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpname.SetError(dp_name_txt, "Please enter Delivery Person's Name!");
                dp_name_txt.Focus();
                return;
            }
            else if (dp_add_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpaddress.SetError(dp_add_txt, "Please enter Delivery Person's Address!");
                dp_add_txt.Focus();
                return;
            }
            else if (dp_tp_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpcontactno.SetError(dp_tp_txt, "Please enter Delivery Person's Contact Number!");
                dp_tp_txt.Focus();
                return;
            }

            try
            {

                deliveryperson dp = new deliveryperson();

                string dp_id = dp_id_txt.Text;
                string dp_name = dp_name_txt.Text;
                string dp_address = dp_add_txt.Text;
                string tp = dp_tp_txt.Text;
                int dp_tp = Convert.ToInt32(tp);

                dp.Delivery_Person_Update(dp_id, dp_name, dp_address, dp_tp);
                dp_Load();
                clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dp_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dp_table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dp_id_txt.Text = dp_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                dp_name_txt.Text = dp_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                dp_add_txt.Text = dp_table.Rows[e.RowIndex].Cells[2].Value.ToString();
                dp_tp_txt.Text = dp_table.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btn_search_dp_Click(object sender, EventArgs e)
        {
            if (txt_proID.Text.Trim().Equals(string.Empty))
            {
                er_searchdpid.SetError(txt_proID, "Please enter Valid Delivery Person's ID!");
                txt_proID.Focus();
                return;
            }

            dp_table.DataSource = db.getData("Select * from Delivery_Person where DP_ID = '" + txt_proID.Text + "'");
            clear();
        }

        private void btn_pro_refresh_Click(object sender, EventArgs e)
        {
            dp_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Remove button validations

            if (dp_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpid.SetError(dp_id_txt, "Please enter Delivery Person's ID!");
                dp_id_txt.Focus();
                return;
            }
            else if (dp_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpname.SetError(dp_name_txt, "Please enter Delivery Person's Name!");
                dp_name_txt.Focus();
                return;
            }
            else if (dp_add_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpaddress.SetError(dp_add_txt, "Please enter Delivery Person's Address!");
                dp_add_txt.Focus();
                return;
            }
            else if (dp_tp_txt.Text.Trim().Equals(string.Empty))
            {
                er_dpcontactno.SetError(dp_tp_txt, "Please enter Delivery Person's Contact Number!");
                dp_tp_txt.Focus();
                return;
            }

            // Coding Here
        }

        private void txt_proID_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_searchdpid.SetError(txt_proID, String.Empty);
        }

        private void dp_id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_dpid.SetError(dp_id_txt, String.Empty);  
        }

        private void dp_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_dpname.SetError(dp_name_txt, String.Empty);
        }

        private void dp_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_dpaddress.SetError(dp_add_txt, String.Empty);
        }

        private void dp_tp_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_dpcontactno.SetError(dp_tp_txt, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_dpcontactno.SetError(dp_tp_txt, "This Field Cannot Contain Letters!");
                dp_tp_txt.Focus();

                return;

            }
        }
    }
}
