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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
            MaximizeBox = false;
            Supplier_Table_Load();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            sup_id_txt.Clear();
            sup_name_txt.Clear();
            sup_add_txt.Clear();
            com_txt.Clear();
            tp_txt.Clear();
            txt_sreach.Clear();


        }
        private void btn_sup_save_Click(object sender, EventArgs e)
        {
            
        }
        Database db = new Database();

        public void Supplier_Table_Load()
        {

            Supplier_Table.DataSource = db.getData("Select * from Supplier");

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btn_sup_save_Click_1(object sender, EventArgs e)
        {
            if (sup_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_supid.SetError(sup_id_txt, "Please enter Supplier ID!");
                sup_id_txt.Focus();
                return;
            }
            else if (sup_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_supname.SetError(sup_name_txt, "Please enter Supplier Name!");
                sup_name_txt.Focus();
                return;
            }
            else if (sup_add_txt.Text.Trim().Equals(string.Empty))
            {
                er_address.SetError(sup_add_txt, "Please enter Supplier Address!");
                sup_add_txt.Focus();
                return;
            }
            else if (com_txt.Text.Trim().Equals(string.Empty))
            {
                er_companyname.SetError(com_txt, "Please enter Company Name!");
                com_txt.Focus();
                return;
            }
            else if (tp_txt.Text.Trim().Equals(string.Empty))
            {
                er_tp.SetError(tp_txt, "Please enter Telephone Number!");
                tp_txt.Focus();
                return;
            }

            try
            {

                Supplier sup = new Supplier();

                string sup_id = sup_id_txt.Text;
                string sup_name = sup_name_txt.Text;
                string sup_add = sup_add_txt.Text;
                string sup_com = com_txt.Text;
                string Sup_TP = tp_txt.Text;
                int sup_tp = Convert.ToInt32(Sup_TP);



                sup.Supplier_Save(sup_id, sup_name, sup_add, sup_tp, sup_com);

                clear();
                Supplier_Table_Load();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sup_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Supplier_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_serach_sup_Click(object sender, EventArgs e)
        {
            if (txt_sreach.Text.Trim().Equals(string.Empty))
            {
                er_searchsup.SetError(txt_sreach, "Please enter valid Supplier ID!");
                txt_sreach.Focus();
                return;
            }
            Supplier_Table.DataSource = db.getData("Select * from Supplier where Sup_ID = '" + txt_sreach.Text + "'");
            clear();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Supplier_Table_Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Update Button Validations
            if (sup_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_supid.SetError(sup_id_txt, "Please enter Supplier ID!");
                sup_id_txt.Focus();
                return;
            }
            else if (sup_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_supname.SetError(sup_name_txt, "Please enter Supplier Name!");
                sup_name_txt.Focus();
                return;
            }
            else if (sup_add_txt.Text.Trim().Equals(string.Empty))
            {
                er_address.SetError(sup_add_txt, "Please enter Supplier Address!");
                sup_add_txt.Focus();
                return;
            }
            else if (com_txt.Text.Trim().Equals(string.Empty))
            {
                er_companyname.SetError(com_txt, "Please enter Company Name!");
                com_txt.Focus();
                return;
            }
            else if (tp_txt.Text.Trim().Equals(string.Empty))
            {
                er_tp.SetError(tp_txt, "Please enter Telephone Number!");
                tp_txt.Focus();
                return;
            }

            // Coding Here
            try
            {

                Supplier sup = new Supplier();

                string sup_id = sup_id_txt.Text;
                string sup_name = sup_name_txt.Text;
                string sup_add = sup_add_txt.Text;
                string sup_com = com_txt.Text;
                string Sup_TP = tp_txt.Text;
                int sup_tp = Convert.ToInt32(Sup_TP);



                sup.Supplier_update(sup_id, sup_name, sup_add, sup_tp, sup_com);

                clear();
                Supplier_Table_Load();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Remove Button Validations

            if (sup_id_txt.Text.Trim().Equals(string.Empty))
            {
                er_supid.SetError(sup_id_txt, "Please enter Supplier ID!");
                sup_id_txt.Focus();
                return;
            }
            else if (sup_name_txt.Text.Trim().Equals(string.Empty))
            {
                er_supname.SetError(sup_name_txt, "Please enter Supplier Name!");
                sup_name_txt.Focus();
                return;
            }
            else if (sup_add_txt.Text.Trim().Equals(string.Empty))
            {
                er_address.SetError(sup_add_txt, "Please enter Supplier Address!");
                sup_add_txt.Focus();
                return;
            }
            else if (com_txt.Text.Trim().Equals(string.Empty))
            {
                er_companyname.SetError(com_txt, "Please enter Company Name!");
                com_txt.Focus();
                return;
            }
            else if (tp_txt.Text.Trim().Equals(string.Empty))
            {
                er_tp.SetError(tp_txt, "Please enter Telephone Number!");
                tp_txt.Focus();
                return;
            }

            // Coding Here
        }

        private void tp_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_tp.SetError(tp_txt, String.Empty);

            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                er_tp.SetError(tp_txt, "This Field Cannot Contain Letters!");
                tp_txt.Focus();

                return;

            }
        }

        private void sup_id_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_supid.SetError(sup_id_txt, String.Empty);
        }

        private void sup_name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_supname.SetError(sup_name_txt, String.Empty);
        }

        private void sup_add_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_address.SetError(sup_add_txt, String.Empty);
        }

        private void com_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_companyname.SetError(com_txt, String.Empty);
        }

        private void txt_sreach_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_searchsup.SetError(txt_sreach, String.Empty);
        }

        private void Supplier_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Supplier_Table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                sup_id_txt.Text = Supplier_Table.Rows[e.RowIndex].Cells[0].Value.ToString();
                sup_name_txt.Text = Supplier_Table.Rows[e.RowIndex].Cells[1].Value.ToString();
                sup_add_txt.Text = Supplier_Table.Rows[e.RowIndex].Cells[2].Value.ToString();
                tp_txt.Text = Supplier_Table.Rows[e.RowIndex].Cells[3].Value.ToString();
                com_txt.Text = Supplier_Table.Rows[e.RowIndex].Cells[4].Value.ToString();
                
            }
        }
    }
}
