using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PharmacySystem.Admin
{
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        String currentUser = "";

        private DataGridViewRow selectedRow = null;
        private string originalUsername = "";

        public UC_ViewUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }


        String userName;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = guna2DataGridView1.Rows[e.RowIndex];
                try
                {
                    userName = selectedRow.Cells["username"].Value.ToString(); // Cập nhật userName luôn tại đây
                }
                catch
                {
                    userName = "";
                }
            }
        }
        //========== LOAD DANH SÁCH NGƯỜI DÙNG LÊN DATAGRIDVIEW ==========
        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.RowTemplate.Height = 45;
            query = "select * from users";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            SetSaveButtonState(false); // Vô hiệu hóa nút Lưu khi khởi động
        }


        //========== TÌM KIẾM TÀI KHOẢN THEO USERNAME ==========
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }



        // =========== XÓA TÀI KHOẢN (KHÔNG XÓA CỦA NGƯỜI DÙNG) & CẬP NHẬT BẢNG ==========
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy username của dòng được chọn
            string selectedUsername = selectedRow.Cells["username"].Value.ToString();

            if (selectedUsername == currentUser)
            {
                MessageBox.Show("Bạn không thể xóa tài khoản đang đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xác nhận xóa
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản '{selectedUsername}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"DELETE FROM users WHERE username = '{selectedUsername}'";
                fn.setData(query, "Tài khoản đã được xóa thành công!");
                UC_ViewUser_Load(this, null);
                selectedRow = null;
                userName = "";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        // ========== CHỌN CẬP NHẬT DỮ LIỆU ==========
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // chọn dòng trên DataGridView
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = guna2DataGridView1.Rows[e.RowIndex];
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy username của dòng được chọn
            string selectedUsername = selectedRow.Cells["username"].Value.ToString();

            try
            {
                txtUpName.Text = selectedRow.Cells["name"].Value.ToString();
                txtUpPassWord.Text = selectedRow.Cells["password"].Value.ToString();
                txtUpUserName.Text = selectedRow.Cells["username"].Value.ToString();
                txtUpEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txtUpRole.Text = selectedRow.Cells["userRole"].Value.ToString();

                // Nếu là tài khoản hiện tại đang đăng nhập -> Khóa ô username và role
                if (selectedUsername == currentUser)
                {
                    txtUpUserName.Enabled = false;
                    txtUpRole.Enabled = false;
                }
                else
                {
                    txtUpUserName.Enabled = true;
                    txtUpRole.Enabled = true;
                }

                // Lưu lại username gốc để dùng khi cập nhật
                originalUsername = selectedUsername;

                // Cho phép lưu và đổi màu nút
                btnSave.Enabled = true;
                btnSave.FillColor = Color.SeaGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổ dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetSaveButtonState(bool enabled) 
        {
            btnSave.Enabled = enabled;
            btnSave.FillColor = enabled ? Color.SeaGreen : Color.Gray;
        }

        // ========== (Xử Lý) Lưu Dữ Liệu =========
        private void btnSave_Click(object sender, EventArgs e)
        {
            // KIỂM TRA ĐIỀU KIỆN TRƯỜNG DỮ LIỆU
            if (string.IsNullOrWhiteSpace(txtUpName.Text) || txtUpName.Text.Length < 6)
            {
                MessageBox.Show("Tên người dùng phải từ 6 ký tự trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUpUserName.Text))
            {
                MessageBox.Show("Tên tài khoản không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpUserName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUpPassWord.Text) || txtUpPassWord.Text.Length <= 5)
            {
                MessageBox.Show("Mật khẩu phải dài hơn 5 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpPassWord.Focus();
                return;
            }


            string email = txtUpEmail.Text.Trim();
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUpRole.Text))
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUpRole.Focus();
                return;
            }



            string name = txtUpName.Text.Trim();
            string password = txtUpPassWord.Text.Trim();
            string username = txtUpUserName.Text.Trim();
            string role = txtUpRole.Text.Trim();
            string query = $"UPDATE users SET name = N'{name}', password = '{password}', username = '{username}', email = '{email}', userRole = N'{role}' WHERE username = '{originalUsername}'";

            fn.setData(query, "Tài khoản đã được cập nhật thành công!");

            UC_ViewUser_Load(this, null);
            selectedRow = null;
            userName = "";
            ResetInputFields();
            SetSaveButtonState(false); // Tắt nút Lưu sau khi lưu
        }

        //========== THAO TÁC HỦY ==========
        private void btnCancel_Click(object sender, EventArgs e)
        {
            selectedRow = null;
            userName = "";
            ResetInputFields();
            SetSaveButtonState(false); // Tắt nút Lưu khi hủy
        }

        //========== RESET Ô NHẬP ==========
        private void ResetInputFields()
        {
            txtUpName.Clear();
            txtUpPassWord.Clear();
            txtUpUserName.Clear();
            txtUpEmail.Clear();
            txtUpRole.SelectedIndex = -1;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}



