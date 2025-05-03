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
    public partial class US_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query, query1;
        public void SetEmployeeID(string employeeID)
        {
            txtUser.Text = employeeID;
        }

        public US_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            txtmDate.ResetText();
            txteDate.ResetText();
            txtMediQuantity.Clear();
            txtAddQuantity.Clear();
            txtMediPricePerUnit.Clear();
            txtSupplierId.Clear();
            txtUser.Clear();
            if (txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mname = txtMedicineName.Text;
            string mnumber = txtMedicineNumber.Text;
            string mdate = txtmDate.Text;
            string edate = txteDate.Text;
            Int64 addQuantity = Int64.Parse(txtMediQuantity.Text);
            Int64 quantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtMediPricePerUnit.Text);
            string supplierId = txtSupplierId.Text;
            string employeeID = txtUser.Text;
            totalQuantity = quantity + addQuantity;
            query1 = "SELECT * FROM Supplier WHERE supplierID = '" + supplierId + "'";
            DataSet ds1 = fn.getData(query1);
            if (ds1.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Nhập sai mã ID nhà cung cấp.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierId.Focus();
                return;
            }
            query = "update medicine set mname = '" + mname + "', mnumber = '" + mnumber + "', mdate = '" + mdate + "', edate = '" + edate + "', quantity = " + totalQuantity + ", perunit = " + unitprice + ", supplierID = '" + supplierId + "', employeeID = '" + employeeID + "' where mid = '" + txtMedicineId.Text + "'";
            fn.setData(query, "Đã cập nhật chi tiết thuốc.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "")
            {
                query = "select * from medicine where mid = '" + txtMedicineId.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtmDate.Text = ds.Tables[0].Rows[0][3].ToString();
                    txteDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMediQuantity.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtMediPricePerUnit.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtSupplierId.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtUser.Text = ds.Tables[0].Rows[0][8].ToString();
                }
                else
                {
                    MessageBox.Show("Không có thuốc ID này: " + txtMedicineId + "", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }



        private void US_UpdateMedicine_Load_1(object sender, EventArgs e)
        {
            txteDate.Format = DateTimePickerFormat.Custom;
            txteDate.CustomFormat = "dd/MM/yyyy";

            txtmDate.Format = DateTimePickerFormat.Custom;
            txtmDate.CustomFormat = "dd/MM/yyyy";
        }
    }
}
