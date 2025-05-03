using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace PharmacySystem
{
    public partial class frmForgetPassword : Form
    {
        function fn = new function();

        public frmForgetPassword()
        {
            InitializeComponent();
        }

        //========== THAO TÁC RESET VÀ THOÁT ==========
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRestoreEmail.Clear();
            txtRestoreUsername.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Nếu form này có Owner (form cha), thì hiển thị lại
            if (this.Owner != null)
            {
                this.Owner.Show(); // Hiện lại form đăng nhập gốc
            }

            this.Close();
        }


        //========== XÁC THỰC MẬT KHẨU QUA EMAIL ==========
        private void sendEmail(string toEmail, string username, string password)
        {
            try
            {
                // ------------ tạo thông tin email ----------
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("luongthong2812@gmail.com"); // Email gửi đi
                mail.To.Add(toEmail);
                mail.Subject = "Khôi phục mật khẩu cho tài khoản PharmacySystem";
                mail.Body = $"Xin chào {username},\n\nBạn vừa yêu cầu khôi phục mật khẩu cho tài khoản {username}.\nMật khẩu hiện tại của bạn là: {password}\n\nVui lòng đăng nhập lại vào hệ thống để sử dụng. Nếu bạn không yêu cầu hành động này, hãy liên hệ với quản trị viên.\n\nTrân trọng,\nPharmacySystem";


                // ---------- thiết lập SMTP Gmail (cổng 587 + SSL), dùng mật khẩu ứng dụng và gửi mail------
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("luongthong2812@gmail.com", "ypye qlwy pqrr fmeq"); 
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Mật khẩu đã được gửi đến email của bạn. Vui lòng kiểm tra email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpFailedRecipientException ex)
            {
                MessageBox.Show("Không thể gửi email vì địa chỉ nhận không tồn tại hoặc không hợp lệ.\n\n" + ex.Message, "Lỗi gửi mail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Lỗi SMTP khi gửi email:\n" + ex.Message, "Lỗi SMTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể gửi email. Lỗi không xác định:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtRestoreUsername.Text.Trim();
                string email = txtRestoreEmail.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = $"SELECT password FROM users WHERE username = '{username}' AND email = '{email}'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    string password = ds.Tables[0].Rows[0]["password"].ToString();
                    sendEmail(email, username, password);
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc email không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xác thực: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
