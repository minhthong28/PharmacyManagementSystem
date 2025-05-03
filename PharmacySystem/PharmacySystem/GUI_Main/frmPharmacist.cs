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
    public partial class frmPharmacist : Form
    {
        public String user = "";
        public frmPharmacist(string userName)
        {
            InitializeComponent();
            lbUserName.Text = userName;
            user = userName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmSignIn fm = new frmSignIn();
            fm.Show();
            this.Hide();
        }


        // 🔹 Ẩn tất cả UserControl trước khi hiển thị cái mới
        private void HideAllUserControls()
        {
            uS_DashBoard1.Visible = false;
            uS_AddMedicine1.Visible = false;
            uS_ViewMedicine1.Visible = false;
            uS_UpdateMedicine1.Visible = false;
            uS_SellMedicine1.Visible = false;
        }
        private void frmPharmacist_Load(object sender, EventArgs e)
        {
            HideAllUserControls(); // Ẩn tất cả UserControl
            btnDashBord.PerformClick();
        }

        private void btnDashBord_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uS_DashBoard1.Visible = true;
            uS_DashBoard1.BringToFront();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uS_AddMedicine1.Visible = true;
            uS_AddMedicine1.BringToFront();

            string tenDangNhap = lbUserName.Text;

            string idNhanVien = function.LayIDNhanVienTheoTenDangNhap(tenDangNhap);
            uS_AddMedicine1.SetEmployeeID(idNhanVien);
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uS_ViewMedicine1.Visible = true;
            uS_ViewMedicine1.BringToFront();
        }

        private void btnUpdateMedi_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uS_UpdateMedicine1.Visible = true;
            uS_UpdateMedicine1.BringToFront();


            string tenDangNhap = lbUserName.Text;

            string idNhanVien = function.LayIDNhanVienTheoTenDangNhap(tenDangNhap);
            uS_UpdateMedicine1.SetEmployeeID(idNhanVien);
        }


        private void hideSubMenu()
        {
            if (pnSubMenu.Visible == true)
                pnSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnInfMedicine_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenu);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbDate.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy",
              new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uS_SellMedicine1.Visible = true;
            uS_SellMedicine1.BringToFront();

            // Lấy tên đăng nhập đang hiển thị
            string tenDangNhap = lbUserName.Text;

            // Truy vấn lấy ID Nhân viên tương ứng
            string idNhanVien = function.LayIDNhanVienTheoTenDangNhap(tenDangNhap);

            // Truyền sang user control
            uS_SellMedicine1.SetEmployeeID(idNhanVien);

        }
    }
}
