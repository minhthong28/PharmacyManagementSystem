using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace PharmacySystem.User
{
    public partial class US_SellMedicine : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        protected int n, totalAmount = 0;
        protected Int64 quantity, NoOfQuantity;
        int valueAmount;
        string valueId;
        protected Int64 noOfUnit;

        public void SetEmployeeID(string employeeID)
        {
            txtEmployeeId.Text = employeeID;
        }
        public US_SellMedicine()
        {
            InitializeComponent();
        }


        private void US_SellMedicine_Load(object sender, EventArgs e)
        {
            txtExpriceDate.Format = DateTimePickerFormat.Custom;
            txtExpriceDate.CustomFormat = "dd/MM/yyyy";

            listBoxMedicines.Items.Clear();
            query = "select mname from medicine where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                listBoxMedicines.Font = new Font("Segoe UI", 12);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medicine where mname like '" + txtSearch.Text + "%' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                listBoxMedicines.Font = new Font("Segoe UI", 12);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text != "" && txtNoOfUnit.Text != "")
            {
                query = "select quantity from medicine where mid = '" + txtMedicineId.Text + "'";
                DataSet ds = fn.getData(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                NoOfQuantity = Int64.Parse(txtNoOfUnit.Text);
                Int64 newQuantity = quantity - NoOfQuantity;
                if (NoOfQuantity <= quantity)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedicineId.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedicineName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpriceDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtNoOfUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotal.Text;
                    totalAmount = totalAmount + int.Parse(txtTotal.Text);
                    lblTotal.Text = totalAmount.ToString() + " VNĐ";

                    query = "update medicine set quantity = '" + newQuantity + "' where mid = '" + txtMedicineId.Text + "'";
                    fn.setData(query, "Thuốc đã được thêm vào giỏ hàng.");
                }
                else
                {
                    MessageBox.Show("Thuốc hết hàng.\n Số lượng còn lại là: " + quantity, "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                US_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Chọn thuốc và nhập số lượng mua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void clearAll()
        {
            txtMedicineId.Clear();
            txtMedicineName.Clear();
            txtExpriceDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnit.Clear();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    query = "select quantity from medicine where mid = '" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    NoOfQuantity = quantity + noOfUnit;

                    query = "update medicine set quantity = '" + NoOfQuantity + "' where mid = '" + valueId + "'";
                    fn.setData(query, "Thuốc đã được loại bỏ khỏi giỏ hàng.");
                    totalAmount = totalAmount - valueAmount;
                    lblTotal.Text = totalAmount.ToString() + " VNĐ";
                }
                US_SellMedicine_Load(this, null);
            }
        }

        private string GenerateNewInvoiceID()
        {
            string prefix = "HĐ";
            string query = "SELECT TOP 1 InvoiceID FROM Invoice WHERE InvoiceID LIKE 'HĐ%' ORDER BY InvoiceID DESC";
            DataSet ds = fn.getData(query);

            int nextNumber = 1;
            if (ds.Tables[0].Rows.Count > 0)
            {
                string lastId = ds.Tables[0].Rows[0][0].ToString(); 
                string numberPart = lastId.Substring(2); 

                int parsedNumber;
                if (int.TryParse(numberPart, out parsedNumber))
                {
                    nextNumber = parsedNumber + 1;
                }
            }

            return prefix + nextNumber.ToString("D3"); 
        }

        private void btnPayAndPrint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmployeeId.Text))
            {
                try
                {
                    string employeeId = txtEmployeeId.Text;
                    Int64 total = totalAmount;

                    // Tạo mã hóa đơn không trùng
                    string newInvoiceId = GenerateNewInvoiceID();

                    // Thêm hóa đơn
                    query = "INSERT INTO Invoice (InvoiceID, InvoiceDate, TotalAmount, EmployeeID) " +
                            "VALUES ('" + newInvoiceId + "', GETDATE(), " + total + ", '" + employeeId + "')";
                    fn.setData(query, null);

                    // Thêm chi tiết hóa đơn
                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            string medicineId = row.Cells[0].Value.ToString();
                            string medicineName = row.Cells[1].Value.ToString();
                            int quantity = int.Parse(row.Cells[4].Value.ToString());
                            Int64 unitPrice = Int64.Parse(row.Cells[3].Value.ToString());
                            Int64 totalPrice = Int64.Parse(row.Cells[5].Value.ToString());

                            query = "INSERT INTO InvoiceDetail (InvoiceID, MedicineID, MedicineName, Quantity, UnitPrice, Total) " +
                                    "VALUES ('" + newInvoiceId + "', '" + medicineId + "', N'" + medicineName + "', " + quantity + ", " + unitPrice + ", " + totalPrice + ")";
                            fn.setData(query, null);
                        }
                    }

                    MessageBox.Show("Hóa đơn và chi tiết đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // In hóa đơn
                    DGVPrinter print = new DGVPrinter();
                    print.Title = "Hóa Đơn Thuốc";
                    print.SubTitle = string.Format("Ngày: {0}", DateTime.Now.Date.ToShortDateString());
                    print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    print.PageNumbers = true;
                    print.PageNumberInHeader = false;
                    print.PorportionalColumns = true;
                    print.HeaderCellAlignment = StringAlignment.Near;
                    print.Footer = "Tổng số tiền phải trả : " + lblTotal.Text;
                    print.FooterSpacing = 15;
                    print.PrintDataGridView(guna2DataGridView1);

                    // Reset
                    totalAmount = 0;
                    lblTotal.Text = "00 VNĐ";
                    guna2DataGridView1.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã ID nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            US_SellMedicine_Load(this, null);
        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnit.Clear();
            string name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMedicineName.Text = name;
            query = "select mid, eDate, perUnit from medicine where mname = '" + name + "'";
            ds = fn.getData(query);
            txtMedicineId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpriceDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoOfUnit_TextChanged(object sender, EventArgs e)
        {
            if (txtNoOfUnit.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoOfUnit.Text);
                Int64 total = unitPrice * noOfUnit;
                txtTotal.Text = total.ToString();
            }
            else
            {
                txtTotal.Clear();
            }
        }
    }
}
