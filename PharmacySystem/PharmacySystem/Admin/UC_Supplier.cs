using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace PharmacySystem.Admin
{
    public partial class UC_Supplier : UserControl
    {
        public UC_Supplier()
        {
            InitializeComponent();
        }

        private void UC_Supplier_Load(object sender, EventArgs e)
        {
            dgvSupplier.RowTemplate.Height = 45;
            LoadSupplierData();
        }

        // --------- Chỉnh giao diện tab ---------
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tab = sender as TabControl;
            TabPage page = tab.TabPages[e.Index];

            // Kiểm tra tab đang được chọn
            bool isSelected = (tab.SelectedIndex == e.Index);

            // Màu nền và chữ khi được chọn và không được chọn
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

      
        // --------- Chỉnh giao diện datagridview ----------
        private void dgvSupplier_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var dgv = (DataGridView)sender;

            // Kiểm tra cột là nút
            if (dgv.Columns[e.ColumnIndex].Name == "btnEdit" || dgv.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                e.Handled = true;

                // Vẽ nền ô 
                using (SolidBrush backBrush = new SolidBrush(dgv.DefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(backBrush, e.CellBounds);
                }

                // Tạo hình chữ nhật cho button nhỏ hơn cell để tránh sát mép
                Rectangle buttonRect = new Rectangle(e.CellBounds.X + 4, e.CellBounds.Y + 4,
                                                     e.CellBounds.Width - 8, e.CellBounds.Height - 8);

                string text = dgv.Columns[e.ColumnIndex].Name == "btnEdit" ? "Sửa" : "Xóa";
                Color backColor = dgv.Columns[e.ColumnIndex].Name == "btnEdit" ? Color.LightSkyBlue : Color.LightCoral;
                Color hoverColor = dgv.Columns[e.ColumnIndex].Name == "btnEdit" ? Color.DeepSkyBlue : Color.Red;

                bool isMouseOver = buttonRect.Contains(dgv.PointToClient(Cursor.Position));

                using (SolidBrush buttonBrush = new SolidBrush(isMouseOver ? hoverColor : backColor))
                using (Pen borderPen = new Pen(Color.Gray))
                {
                    e.Graphics.FillRectangle(buttonBrush, buttonRect);
                    e.Graphics.DrawRectangle(borderPen, buttonRect);

                    TextRenderer.DrawText(e.Graphics, text, dgv.Font, buttonRect,
                                          Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }
        
       


        // ========== TAB SUPPLIER FORM ==========

                // -------- Thêm NCC ---------
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string supplierID = txtIDSupplier.Text.Trim();
            string supplierName = txtNameSupplier.Text.Trim();
            string email = txtEmailSupplier.Text.Trim();
            string contact = txtContactSupplier.Text.Trim();
            string drugsAvailable = txtDrugsAvailable.Text.Trim();

            function func = new function();
            bool success = func.AddSupplier(supplierID, supplierName, email, contact, drugsAvailable);

            if (success)
            {
                MessageBox.Show("Đăng ký nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSupplierForm();

                LoadSupplierData();
            }
        }

        private void ClearSupplierForm()
        {
            txtIDSupplier.Clear();
            txtNameSupplier.Clear();
            txtEmailSupplier.Clear();
            txtContactSupplier.Clear();
            txtDrugsAvailable.Clear();
        }

        // ========== TAB SUPPLIER LIST ==========

                // ------ Load dữ liệu lên datagridview ------

        private DataTable allSuppliersTable; // Dùng để lưu dữ liệu gốc không lọc
        private void LoadSupplierData()
        {
            dgvSupplier.Rows.Clear();
            function func = new function();
            allSuppliersTable = func.GetAllSuppliers(); // Lưu toàn bộ dữ liệu vào biến toàn cục

            foreach (DataRow row in allSuppliersTable.Rows)
            {
                dgvSupplier.Rows.Add(
                    row["SupplierID"].ToString(),
                    row["SupplierName"].ToString(),
                    row["Email"].ToString(),
                    row["Contact"].ToString(),
                    row["DrugsAvailable"].ToString()
                );
            }
        }


                 // ----- Xuất Excel -----
        private void ExportToExcel_Table(DataGridView dgv)
        {
            var excelApp = new Excel.Application();
            var workbook = excelApp.Workbooks.Add();
            var sheet = (Excel.Worksheet)workbook.Sheets[1];
            int colCount = dgv.Columns.Count - 2; // số cột hiện trong excel

            try
            {
                // Tiêu đề cột
                for (int i = 0; i < colCount; i++)
                    sheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;

                // Ghi dữ liệu
                for (int i = 0; i < dgv.Rows.Count; i++)
                    for (int j = 0; j < colCount; j++)
                        sheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString(); // ?.ToString(): Toán tử null-safe, nếu ô trống không bị lỗi

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Files|*.xlsx", FileName = "DanhSachNhaCungCap" })
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
                // thao tác hủy nếu không thực hiện tiếp
                workbook.Close(false);
                excelApp.Quit();

                Marshal.ReleaseComObject(sheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);

                sheet = null; workbook = null; excelApp = null;

                GC.Collect(); // Ép hệ thống dọn dẹp rác
                GC.WaitForPendingFinalizers(); // Đợi các tiến trình dọn dẹp kết thúc trước khi tiếp tục

            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel_Table(dgvSupplier);
        }

        // ------ Lọc tìm kiếm ------
        private void FilterSupplierList()
        {
            string idFilter = txtSearchID.Text.Trim().ToLower();
            string nameFilter = txtSearchName.Text.Trim().ToLower();
            string drugsFilter = txtSearchDrugs.Text.Trim().ToLower();

            dgvSupplier.Rows.Clear();

            foreach (DataRow row in allSuppliersTable.Rows)
            {
                string id = row["SupplierID"].ToString().ToLower();
                string name = row["SupplierName"].ToString().ToLower();
                string drugs = row["DrugsAvailable"].ToString().ToLower();

                if (id.Contains(idFilter) &&
                    name.Contains(nameFilter) &&
                    drugs.Contains(drugsFilter))
                {
                    dgvSupplier.Rows.Add(
                        row["SupplierID"].ToString(),
                        row["SupplierName"].ToString(),
                        row["Email"].ToString(),
                        row["Contact"].ToString(),
                        row["DrugsAvailable"].ToString()
                    );
                }
            }
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            FilterSupplierList();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            FilterSupplierList();
        }

        private void txtSearchDrugs_TextChanged(object sender, EventArgs e)
        {
            FilterSupplierList();
        }

                // --------- Thao tác cập nhật & xóa trên datagridview --------
        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string supplierID = dgvSupplier.Rows[e.RowIndex].Cells["colID"].Value.ToString();

            // Sửa
            if (e.ColumnIndex == dgvSupplier.Columns["btnEdit"].Index)
            {
                DialogResult dr = MessageBox.Show($"Bạn muốn sửa thông tin nhà cung cấp có mã '{supplierID}'?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SupplierUpdate frm = new SupplierUpdate(supplierID);
                    frm.FormClosed += (s, args) => LoadSupplierData(); 
                    frm.ShowDialog();
                }
            }
            // Xóa
            else if (e.ColumnIndex == dgvSupplier.Columns["btnDelete"].Index)
            {
                DialogResult dr = MessageBox.Show($"Bạn muốn xóa nhà cung cấp có mã '{supplierID}'?",
                            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    function func = new function();
                    func.DeleteSupplier(supplierID); 
                    LoadSupplierData(); 
                }
            }
        }

       
    }
}
