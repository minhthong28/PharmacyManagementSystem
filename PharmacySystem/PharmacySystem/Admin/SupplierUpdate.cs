using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.Admin
{
    public partial class SupplierUpdate : Form
    {
        private readonly string supplierID;

        public SupplierUpdate(string supplierID)
        {
            InitializeComponent();
            this.supplierID = supplierID;
        }

        private void SupplierUpdate_Load(object sender, EventArgs e)
        {
            var data = new function().GetSupplierByID(supplierID);
            if (data != null)
            {
                txtID.Text = data["SupplierID"].ToString();
                txtID.Enabled = false;
                txtName.Text = data["SupplierName"].ToString();
                txtEmail.Text = data["Email"].ToString();
                txtContact.Text = data["Contact"].ToString();
                txtDrugsAvailable.Text = data["DrugsAvailable"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool success = new function().UpdateSupplier(
                txtID.Text,
                txtName.Text,
                txtEmail.Text,
                txtContact.Text,
                txtDrugsAvailable.Text
            );
            if (success)
                this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát mà không lưu thay đổi?",
                                          "Lưu ý",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }

}
