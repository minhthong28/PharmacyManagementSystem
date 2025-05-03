using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.User
{
    public partial class US_AddMedicine : UserControl
    {
        function fn = new function();
        string query, query1, query2;
        string user = "";

        public void SetEmployeeID(string employeeID)
        {
            txtUser.Text = employeeID;
        }

        public US_AddMedicine()
        {
            InitializeComponent();
            var parentForm = this.FindForm() as frmSignIn;
            if (parentForm != null)
            {
                user = parentForm.username;
                txtSupplierId.Text = "USER1";
            }
            txtSupplierId.Text = user;
        }


        private void btnAddP_Click(object sender, EventArgs e)
        {
            if (txtMediId.Text != "" && txtMediName.Text != "" && txtMediNumber.Text != "" && txtPricePerUnit.Text != "" && txtManuFact.Value < txtExpireMedi.Value && txtSupplierId.Text != "")
            {
                string mid = txtMediId.Text;
                string mname = txtMediName.Text;
                string mnumber = txtMediNumber.Text;
                string mdate = txtManuFact.Value.ToString("yyyy-MM-dd");
                string edate = txtExpireMedi.Value.ToString("yyyy-MM-dd");
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);
                string supplierID = txtSupplierId.Text;
                string employeeID = txtUser.Text;

                query1 = "SELECT * FROM Supplier WHERE supplierID = '" + supplierID + "'";
                DataSet ds1 = fn.getData(query1);
                if (ds1.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Nhập sai mã ID nhà cung cấp.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierId.Focus();
                    return;
                }

                query2 = "SELECT * FROM medicine WHERE mid = '" + mid + "'";
                DataSet ds2 = fn.getData(query2);
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Đã có mã ID thuốc này.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMediId.Focus();
                    return;
                }

                string importDate = DateTime.Today.ToString("yyyy-MM-dd"); // Ngày nhập mặc định là hôm nay

                query = "Insert into medicine (mid, mname, mnumber, mDate, eDate, quantity, perUnit, supplierID, employeeID, importDate) " +
                        "values ('" + mid + "', '" + mname + "', '" + mnumber + "', '" + mdate + "', '" + edate + "', " + quantity + ", " + perunit + ", '" + supplierID + "', '" + employeeID + "', '" + importDate + "')";

                fn.setData(query, "Thuốc được thêm vào dữ liệu");
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu hoặc sai ngày hết hạn thuốc!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMediId.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtPricePerUnit.Clear();
            txtQuantity.Clear();
            txtManuFact.ResetText();
            txtExpireMedi.ResetText();
            txtSupplierId.Clear();
            txtUser.Clear();
        }

        private void US_AddMedicine_Load(object sender, EventArgs e)
        {
            txtExpireMedi.Format = DateTimePickerFormat.Custom;
            txtExpireMedi.CustomFormat = "dd/MM/yyyy";

            txtManuFact.Format = DateTimePickerFormat.Custom;
            txtManuFact.CustomFormat = "dd/MM/yyyy";
        }
    }
}
