using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Text.RegularExpressions;

namespace PharmacySystem.Admin
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;

        ToolTip errorTooltip = new ToolTip();

        public UC_AddUser()
        {
            InitializeComponent();


            // Kiểm tra các ô sau khi nhập
            txtUserID.Leave += (s, e) => ValidateUserID();
            txtEmail.Leave += (s, e) => ValidateEmail();
            txtName.Leave += (s, e) => ValidateName();
            txtPassword.Leave += (s, e) => ValidatePassword();
            txtRole.Leave += (s, e) => ValidateRole();
        }


        //================= ĐIỀU KIỆN TỪNG TRƯỜNG DỮ LIỆU ===================

        private void ValidateUserID()
        {
            string userID = txtUserID.Text.Trim();
            if (!Regex.IsMatch(userID, @"^(?=.*[A-Za-z])(?=.*\d).+$"))
            {
                ShowError(txtUserID, "Mã tài khoản phải chứa cả chữ và số!");
                return;
            }

            query = "SELECT * FROM users WHERE id = '" + userID + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ShowError(txtUserID, "Mã tài khoản đã tồn tại!");
            }
            else
            {
                ClearError(txtUserID);
            }
        }

        private void ValidateEmail()
        {
            string email = txtEmail.Text.Trim();
            bool isValid = true;

            if (string.IsNullOrEmpty(email))
            {
                ShowError(txtEmail, "Email không được để trống!");
                isValid = false;
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ShowError(txtEmail, "Email chưa đúng định dạng!");
                isValid = false;
            }
            if (isValid)
                ClearError(txtEmail);
        }

        private void ValidateName()
        {
            string name = txtName.Text.Trim();
            bool isValid = true;
            if (string.IsNullOrEmpty(name))
            {
                ShowError(txtName, "Tên không được để trống!");
                isValid = false;
            }
            else if (name.Length < 6)
            {
                ShowError(txtName, "Tên người dùng phải từ 6 ký tự!");
                isValid = false;
            }
            if (isValid)
                ClearError(txtName);
        }

        private void ValidatePassword()
        {
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(password) || password.Length <= 5)
                ShowError(txtPassword, "Mật khẩu phải dài hơn 5 ký tự!");
            else
                ClearError(txtPassword);
        }


        private void ValidateRole()
        {
            if (string.IsNullOrWhiteSpace(txtRole.Text))
                ShowErrorComboBox(txtRole, "Vui lòng chọn vai trò!");
            else
                ClearErrorComboBox(txtRole);
        }


        // ================= TOOLTIP THÔNG BÁO LỖI ===================

        private void ShowError(Guna2TextBox control, string message)
        {
            control.FillColor = Color.MistyRose;
            errorTooltip.ToolTipTitle = "Lỗi nhập liệu";
            errorTooltip.ToolTipIcon = ToolTipIcon.Warning;
            errorTooltip.Show(message, control, control.Width + 5, 0, 3000);
        }

        private void ClearError(Guna2TextBox control)
        {
            control.FillColor = Color.White;
            errorTooltip.Hide(control);
        }

        private void ShowErrorComboBox(Guna2ComboBox comboBox, string message)
        {
            comboBox.FillColor = Color.MistyRose;
            errorTooltip.ToolTipTitle = "Lỗi nhập liệu";
            errorTooltip.ToolTipIcon = ToolTipIcon.Warning;
            errorTooltip.Show(message, comboBox, 0, comboBox.Height + 5, 3000);
        }

        private void ClearErrorComboBox(Guna2ComboBox comboBox)
        {
            comboBox.FillColor = Color.White;
            errorTooltip.Hide(comboBox);
        }

        private void ShowErrorDateTime(Guna2DateTimePicker dtp, string message)
        {
            dtp.FillColor = Color.MistyRose;
            errorTooltip.ToolTipTitle = "Lỗi nhập liệu";
            errorTooltip.ToolTipIcon = ToolTipIcon.Warning;
            errorTooltip.Show(message, dtp, dtp.Width + 5, 0, 3000);
        }

        private void ClearErrorDateTime(Guna2DateTimePicker dtp)
        {
            dtp.FillColor = Color.White;
            errorTooltip.Hide(dtp);
        }

        // ================= RESET ===================
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtUserID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtRole.SelectedIndex = -1;
            picTrAddUser.Image = null;

            ClearError(txtUserID);
            ClearError(txtEmail);
            ClearError(txtName);
            ClearError(txtPassword);
            ClearErrorComboBox(txtRole);
        }

        // ================= ĐĂNG KÝ ===================
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ValidateUserID();
            ValidateEmail();
            ValidateName();
            ValidatePassword();
            ValidateRole();

            if (txtUserID.FillColor == Color.MistyRose || txtEmail.FillColor == Color.MistyRose ||
                txtName.FillColor == Color.MistyRose || txtPassword.FillColor == Color.MistyRose ||
                txtRole.FillColor == Color.MistyRose)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và hợp lệ các thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = txtUserID.Text;
                string role = txtRole.Text;
                string name = txtName.Text;
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                query = "INSERT INTO users (id, userRole, name, email, username, password) VALUES ('" +
                        id + "', '" + role + "', '" + name + "', '" + email + "', '" + username + "', '" + password + "')";

                fn.setData(query, "Đăng ký thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Tài khoản đã tồn tại hoặc có lỗi xảy ra. Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // ================= CHECK USERNAME QUA TXT ===================
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                picTrAddUser.ImageLocation = ""; // Không hiển thị icon nếu username trống
                return;
            }
            query = "select * from users where username='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                picTrAddUser.ImageLocation = Application.StartupPath + "\\image_pharmacy\\image_pharmacy\\yes.png";
            }
            else
            {
                picTrAddUser.ImageLocation = Application.StartupPath + "\\image_pharmacy\\image_pharmacy\\no.png";
            }
        }


    }
}


