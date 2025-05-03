using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace PharmacySystem.Admin
{
    public partial class UC_Order : UserControl
    {
       // string query;
        function fn = new function();
        private string currentEmployeeID;  

        public UC_Order()
        {
            InitializeComponent();

        }
        public void SetEmployeeID(string employeeID)
        {
            currentEmployeeID = employeeID;
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Order_Load(this, null);
        }
        // ========== Load dữ liệu datagridview ==========
        private void UC_Order_Load(object sender, EventArgs e)
        {
            dgvOrder.RowTemplate.Height = 45;
            dgvOrderSave.RowTemplate.Height = 45;
            LoadMedicineData();
            LoadForOrder();

            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.CustomFormat = "dd/MM/yyyy";

            // Vẽ nút và xử lý click
            dgvOrder.CellPainting += dgvOrder_CellPainting;
            dgvOrder.CellClick += dgvOrder_CellClick;

            // Gán sự kiện cho các RadioButton
            rbnExpired.CheckedChanged += Filter_CheckedChanged;
            rbnLessExpired.CheckedChanged += Filter_CheckedChanged;
            rbnOutOfStock.CheckedChanged += Filter_CheckedChanged;
            rbnLessStock.CheckedChanged += Filter_CheckedChanged;
            rbnFull.CheckedChanged += Filter_CheckedChanged;
        }

        private void LoadMedicineData()
        {
            dgvOrder.Rows.Clear();
            DataTable dt = fn.GetAllMedicinesForOrder();

            foreach (DataRow row in dt.Rows)
            {
                DateTime mDate = Convert.ToDateTime(row["mDate"]);
                DateTime eDate = Convert.ToDateTime(row["eDate"]);

                dgvOrder.Rows.Add(
                    row["mid"].ToString(),
                    row["mname"].ToString(),
                    row["mnumber"].ToString(),
                    mDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    eDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    row["quantity"].ToString(),
                    row["SupplierId"].ToString(),
                    "Yêu cầu"
                );
            }
        }

        private void LoadForOrder()
        {
            dgvOrderSave.Rows.Clear();
            DataTable dt = fn.GetAllForOrder();

            foreach (DataRow row in dt.Rows)
            {
                DateTime orderdate = Convert.ToDateTime(row["OrderDate"]);
                dgvOrderSave.Rows.Add(
                    row["OrderID"].ToString(),
                    row["EmployeeID"].ToString(),
                    row["MNumber"].ToString(),
                    row["MedicineName"].ToString(),
                    row["Quantity"].ToString(),
                    orderdate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    row["SupplierName"].ToString(),
                    row["SupplierEmail"].ToString()
                );
            }
        }
        // ========== Lọc dữ liệu thuốc radiobutton ==========
        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnExpired.Checked) ApplyFilterExpired();
            else if (rbnLessExpired.Checked) ApplyFilterLessExpired();
            else if (rbnOutOfStock.Checked) ApplyFilterOutOfStock();
            else if (rbnLessStock.Checked) ApplyFilterLessStock();
            else if (rbnFull.Checked) LoadMedicineData();
        }

            // Quá hạn
        private void ApplyFilterExpired()
        {
            DateTime today = DateTime.Today;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                DateTime eDate = DateTime.ParseExact(row.Cells["coleDate"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                row.Visible = eDate < today;
            }
        }

            // Cận hết hạn (<= 30 ngày từ ngày sản xuất)
        private void ApplyFilterLessExpired()
        {
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                DateTime mDate = DateTime.ParseExact(row.Cells["colmDate"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime eDate = DateTime.ParseExact(row.Cells["coleDate"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                row.Visible = (eDate - mDate).TotalDays <= 30 && eDate >= DateTime.Today;
            }
        }

            // Hết hàng
        private void ApplyFilterOutOfStock()
        {
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                int qty = int.Parse(row.Cells["colQuantity"].Value.ToString());
                row.Visible = qty == 0;
            }
        }

            // Sắp hết hàng
        private void ApplyFilterLessStock()
        {
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                int qty = int.Parse(row.Cells["colQuantity"].Value.ToString());
                row.Visible = qty > 0 && qty <= 10;
            }
        }

        // ========= Chỉnh giao diện ==========
        private void dgvOrder_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvOrder.Columns[e.ColumnIndex].Name != "colRequest") return;

            e.Handled = true;
            using (var backBrush = new SolidBrush(Color.White))
                e.Graphics.FillRectangle(backBrush, e.CellBounds);

            var rect = new Rectangle(e.CellBounds.X + 4, e.CellBounds.Y + 4,
                                     e.CellBounds.Width - 8, e.CellBounds.Height - 8);

            bool hover = rect.Contains(dgvOrder.PointToClient(Cursor.Position));
            var color = hover ? Color.DarkOrange : Color.LightSalmon;
            using (var brush = new SolidBrush(color))
                e.Graphics.FillRectangle(brush, rect);

            TextRenderer.DrawText(
                e.Graphics, "Yêu cầu", dgvOrder.Font, rect, Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào cột "Yêu cầu"
            if (e.RowIndex < 0 || dgvOrder.Columns[e.ColumnIndex].Name != "colRequest")
                return;

            var row = dgvOrder.Rows[e.RowIndex];

            // Lấy thông tin từ các cột của dòng đã chọn
            string mnumber = row.Cells["colNumMedicine"].Value.ToString();
            string mname = row.Cells["colNameMedicine"].Value.ToString();
            string supId = row.Cells["colSupplierID"].Value.ToString();

            // Hiển thị thông báo xác nhận
            DialogResult result = MessageBox.Show($"Bạn có muốn đặt thuốc có mã số '{mnumber}'?",
                                                  "Xác nhận đặt hàng",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Mở form OrderRequest và truyền dữ liệu
                OrderRequest frm = new OrderRequest(mnumber, mname, supId, currentEmployeeID);
                frm.ShowDialog();
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tab = sender as TabControl;
            TabPage page = tab.TabPages[e.Index];

            // Kiểm tra tab đang được chọn
            bool isSelected = (tab.SelectedIndex == e.Index);

            Color backColor = isSelected ? Color.MediumSeaGreen : Color.White;
            Color textColor = isSelected ? Color.White : Color.Black;

            using (SolidBrush backBrush = new SolidBrush(backColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                // Vẽ nền tab
                e.Graphics.FillRectangle(backBrush, e.Bounds);

                // Vẽ tiêu đề
                e.Graphics.DrawString(page.Text, e.Font, textBrush, e.Bounds, sf);
            }
        }

        // ========== Tìm Kiếm & Xuất Excel ==========
        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpOrderDate.Value.Date;

            foreach (DataGridViewRow row in dgvOrderSave.Rows)
            {
                if (row.Cells["colOrderDate"].Value != null)
                {
                    // Parse từ chuỗi hiển thị thành DateTime
                    DateTime orderDate = DateTime.ParseExact(row.Cells["colOrderDate"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    // So sánh ngày
                    row.Visible = orderDate.Date == selectedDate;
                }
            }
        }

        private void txtSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchMedicine.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells["colNameMedicine"].Value != null)
                {
                    string medicineName = row.Cells["colNameMedicine"].Value.ToString().ToLower();
                    row.Visible = medicineName.Contains(searchText);
                }
            }
        }

        private void txtSearchMedOrder_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchMedOrder.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvOrderSave.Rows)
            {
                if (row.Cells["colMedicineName"].Value != null)
                {
                    string medicineName = row.Cells["colMedicineName"].Value.ToString().ToLower();
                    row.Visible = medicineName.Contains(searchText);
                }
            }
        }

        private void ExportToExcel_Table(DataGridView dgv)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp.Workbooks.Add();
            var sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int colCount = dgv.Columns.Count - 1; 

            try
            {
                // Tiêu đề cột
                for (int i = 0; i < colCount; i++)
                    sheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;

                int excelRow = 2; // bắt đầu từ dòng 2 trong Excel

                // Duyệt qua các dòng đang hiển thị (Visible = true)
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Visible)
                    {
                        for (int j = 0; j < colCount; j++)
                        {
                            sheet.Cells[excelRow, j + 1] = row.Cells[j].Value?.ToString();
                        }
                        excelRow++;
                    }
                }

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Files|*.xlsx", FileName = "DanhSach" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message);
            }
            finally
            {
                workbook.Close(false);
                excelApp.Quit();

                Marshal.ReleaseComObject(sheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);

                sheet = null; workbook = null; excelApp = null;

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel_Table(dgvOrder);
        }

     
    }
}


