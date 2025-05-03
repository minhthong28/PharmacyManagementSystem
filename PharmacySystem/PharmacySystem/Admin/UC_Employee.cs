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
using System.Globalization;

namespace PharmacySystem.Admin
{
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
        }

        private function fn = new function(); // Khởi tạo class function


        private void LoadEmployeeData()
        {
            dgvEmployee.Rows.Clear();
            DataTable dt = fn.GetAllEmployees();
            foreach (DataRow row in dt.Rows)
            {
                dgvEmployee.Rows.Add(
                    row["employeeID"].ToString(),
                    row["name"].ToString(),
                    Convert.ToDateTime(row["birthDate"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    row["phoneNumber"].ToString(),
                    row["gender"].ToString(),
                    Convert.ToDateTime(row["hireDate"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    row["userID"].ToString()
                );
            }
        }



        private void UC_Employee_Load(object sender, EventArgs e)
        {
            dgvEmployee.RowTemplate.Height = 45;
            dtDOB.Format = DateTimePickerFormat.Custom;
            dtDOB.CustomFormat = "dd/MM/yyyy";
            dtHireDate.Format = DateTimePickerFormat.Custom;
            dtHireDate.CustomFormat = "dd/MM/yyyy";

            btnSave.Enabled = false;
            LoadEmployeeData();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string empID = txtIDEmployee.Text.Trim();
            string name = txtName.Text.Trim();
            DateTime birthDate = dtDOB.Value;
            string phone = txtPhone.Text.Trim();
            string gender = cbGender.SelectedItem?.ToString() ?? "";
            DateTime hireDate = dtHireDate.Value;
            string userID = txtIDUsername.Text.Trim();

            if (string.IsNullOrEmpty(empID) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||
    string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = fn.AddEmployee(empID, name, birthDate, phone, gender, hireDate, userID);

            if (result)
            {
                MessageBox.Show("Thêm thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeeData(); 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có dòng nào được chọn
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string employeeID = dgvEmployee.CurrentRow.Cells[0].Value.ToString();

            // Hiển thị thông báo xác nhận
            DialogResult result = MessageBox.Show(
                $"Bạn muốn xóa thông tin nhân viên có mã {employeeID}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                fn.DeleteEmployee(employeeID);
                LoadEmployeeData(); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa chọn dòng
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy employeeID từ dòng được chọn
            string employeeID = dgvEmployee.CurrentRow.Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show($"Bạn muốn cập nhật thông tin nhân viên có mã {employeeID}?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đổ dữ liệu dòng đang chọn lên các ô nhập liệu
                DataGridViewRow selectedRow = dgvEmployee.SelectedRows[0];

                txtIDEmployee.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                //dtDOB.Value = Convert.ToDateTime(selectedRow.Cells[2].Value);
                dtDOB.Value = DateTime.ParseExact(selectedRow.Cells[2].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                txtPhone.Text = selectedRow.Cells[3].Value.ToString();
                cbGender.Text = selectedRow.Cells[4].Value.ToString();
                //dtHireDate.Value = Convert.ToDateTime(selectedRow.Cells[5].Value);
                dtHireDate.Value = DateTime.ParseExact(selectedRow.Cells[5].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                txtIDUsername.Text = selectedRow.Cells[6].Value.ToString();

                txtIDEmployee.Enabled = false;
                btnDelete.Enabled = false;
                btnExportExcel.Enabled = false;
                btnSignUp.Enabled = false;
                btnSave.Enabled = true;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtIDEmployee.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtIDUsername.Text = "";
            cbGender.SelectedIndex = -1;

            dtDOB.Value = DateTime.Now;
            dtHireDate.Value = DateTime.Now;

            txtIDEmployee.Enabled = true;

            btnDelete.Enabled = true;
            btnExportExcel.Enabled = true;
            btnSignUp.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtIDEmployee.Text.Trim();
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string gender = cbGender.Text.Trim();
            string userID = txtIDUsername.Text.Trim();
            DateTime birth = dtDOB.Value;
            DateTime hire = dtHireDate.Value;

            bool result = fn.UpdateEmployee(id, name, birth, phone, gender, hire, userID);

            if (result)
            {
                LoadEmployeeData();
                btnCancel.PerformClick();
            }
            else
            {

            }
        }


        private void ExportToExcel_Table(DataGridView dgv)
        {
            var excelApp = new Excel.Application();
            var workbook = excelApp.Workbooks.Add();
            var sheet = (Excel.Worksheet)workbook.Sheets[1];
            int colCount = dgv.Columns.Count; // số cột hiện trong excel

            try
            {
                // Tiêu đề cột
                for (int i = 0; i < colCount; i++)
                    sheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;

                // Ghi dữ liệu
                for (int i = 0; i < dgv.Rows.Count; i++)
                    for (int j = 0; j < colCount; j++)
                        sheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString(); // ?.ToString(): Toán tử null-safe, nếu ô trống không bị lỗi

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Files|*.xlsx", FileName = "DanhSachNhanVien" })
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
            ExportToExcel_Table(dgvEmployee);
        }
    }
}
