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
    public partial class addRawmattirials : Form
    {
        public addRawmattirials()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void addRawmattirials_Load(object sender, EventArgs e)
        {

        }

        private void btn_rm_save_Click(object sender, EventArgs e)
        {
            if (txt_rm_id.Text.Trim().Equals(string.Empty))
            {
                er_rmno.SetError(txt_rm_id, "Please enter Raw Material Number!");
                txt_rm_id.Focus();
                return;
            }
            else if (txt_rm_name.Text.Trim().Equals(string.Empty))
            {
                er_rmname.SetError(txt_rm_name, "Please enter Raw Material Name!");
                txt_rm_name.Focus();
                return;
            }

            try
            {

                raw_material rm = new raw_material();

                string rm_no = txt_rm_id.Text;
                string rm_name = txt_rm_name.Text;

                rm.add_RM(rm_no,rm_name);

                clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear()
        {
            txt_rm_id.Clear();
            txt_rm_name.Clear();
        }

        private void btn_rm_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_rm_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_rmno.SetError(txt_rm_id, String.Empty);
        }

        private void txt_rm_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            er_rmname.SetError(txt_rm_name, String.Empty);
        }
    }
}
