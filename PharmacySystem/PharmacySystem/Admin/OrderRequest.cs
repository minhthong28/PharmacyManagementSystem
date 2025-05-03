using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.Admin
{
    public partial class OrderRequest : Form
    {
        function fn = new function();
        int quantity;
        private string mnumber;
        private string mname;
        private string supplierId;
        private void OrderRequest_Load(object sender, EventArgs e)
        {
            //✳️ Gán mã đơn hàng tự động
            txtIDOrder.Text = fn.GenerateUniqueOrderID();
            txtIDOrder.ReadOnly = true;
        }

        public OrderRequest(string mnumber, string mname, string supId, string employeeID)
        {
            InitializeComponent();

            this.mnumber = mnumber;
            this.mname = mname;
            this.supplierId = supId;

            txtIDEmployee.Text = employeeID;
            txtIDEmployee.ReadOnly = true;
            LoadSupplierInfo();
        }

        private void LoadSupplierInfo()
        {
            DataRow row = fn.GetSupplierByID(supplierId);

            if (row != null)
            {
                txtNumberMedicine.Text = mnumber;
                txtNameMedicine.Text = mname;
                txtSupplierName.Text = row["SupplierName"].ToString();
                txtEmailSupplier.Text = row["Email"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(nbrQuantity.Text, out quantity) || quantity <= 5)
            {
                MessageBox.Show("Số lượng phải lớn hơn 5!", "Sai dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Tạo phiếu đặt hàng PDF
            string pdfPath = PharmacySystem.Helper.OrderRequestPDF.GenerateContract(
                txtIDOrder.Text,
                txtNumberMedicine.Text,
                txtNameMedicine.Text,
                nbrQuantity.Text,
                txtSupplierName.Text,
                txtEmailSupplier.Text,
                txtIDEmployee.Text
            );

            // 2. Mở file PDF bằng ứng dụng mặc định của Windows
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở file PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Xác nhận gửi email
            DialogResult result = MessageBox.Show(
                "Phiếu đặt hàng sẽ được gửi đính kèm qua email nhà cung cấp?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // ✳️ Bắt đầu loading
                guna2ProgressIndicator1.Visible = true;
                guna2ProgressIndicator1.Start();
                btnSendEmail.Enabled = false;

                bool sendSuccess = await Task.Run(() =>
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("luongthong2812@gmail.com");
                        mail.To.Add(txtEmailSupplier.Text);
                        mail.Subject = "Thông tin đặt hàng - PharmaTech Medical Store";
                        mail.Body = "Kính gửi quý đối tác,\n\nCửa hàng cần đặt thêm thuốc. Vui lòng xem file phiếu đặt hàng đính kèm.\n\nTrân trọng, PharmaTech Medical Store.";
                        mail.Attachments.Add(new Attachment(pdfPath));

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.Credentials = new NetworkCredential("luongthong2812@gmail.com", "ypye qlwy pqrr fmeq");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                });

                //Tắt loading
                guna2ProgressIndicator1.Stop();
                guna2ProgressIndicator1.Visible = false;
                btnSendEmail.Enabled = true;

                if (sendSuccess)
                {
                    bool saved = fn.InsertOrder(
                        txtIDOrder.Text.Trim(),
                        txtIDEmployee.Text.Trim(),
                        txtNumberMedicine.Text.Trim(),
                        txtNameMedicine.Text.Trim(),
                        quantity,
                        DateTime.Now.Date,
                        txtSupplierName.Text.Trim(),
                        txtEmailSupplier.Text.Trim()
                    );

                    if (saved)
                    {
                        MessageBox.Show("Email đã được gửi và lưu đơn hàng thành công!", "Thành công",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        nbrQuantity.Value = 0;
                        txtIDOrder.Text = fn.GenerateUniqueOrderID();

                    }
                    else
                    {
                        MessageBox.Show("Email thành công nhưng lưu đơn hàng thất bại!", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Gửi email thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
