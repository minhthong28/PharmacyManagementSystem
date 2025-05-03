using PharmacySystem.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem
{
    public partial class frmSignIn : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public string username;
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa nhập tên đăng nhập hoặc mật khẩu
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Truy vấn lấy thông tin tài khoản
            query = "SELECT userRole FROM users WHERE username = '" + txtUserName.Text + "' AND password = '" + txtPassword.Text + "'";
            ds = fn.getData(query);

            // Kiểm tra nếu không tìm thấy tài khoản
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu sai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu tìm thấy tài khoản, lấy vai trò của người dùng
            string role = ds.Tables[0].Rows[0]["userRole"].ToString();

            // Chuyển hướng đến giao diện tương ứng
            if (role == "admin")
            {
                frmAdmin admin = new frmAdmin(txtUserName.Text);
                admin.Show();
                this.Hide();
            }
            else if (role == "user")
            {
                frmPharmacist pharma = new frmPharmacist(txtUserName.Text);
                pharma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không xác định được quyền truy cập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                picShow.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                picHide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void frmSignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSign.PerformClick(); 
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnReload.PerformClick(); 
            }
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword frmForgetPass = new frmForgetPassword();

            // Gán frmSignIn là chủ sở hữu của frmForgetPass
            frmForgetPass.Owner = this;

            frmForgetPass.Show();
            this.Hide(); // Ẩn form đăng nhập

            // Khi đóng form đổi mật khẩu, hiện lại form đăng nhập
            frmForgetPass.FormClosed += (s, args) => this.Show();
        }
    }
    }
