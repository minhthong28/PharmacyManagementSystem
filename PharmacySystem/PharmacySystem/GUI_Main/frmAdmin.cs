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
    public partial class frmAdmin : Form
    {

        String user = "";
        public string ID
        {
            get { return user.ToString(); }
        }

        public frmAdmin(String userName)
        {
            InitializeComponent();
            lbUserName.Text = userName;
            user = userName;
            uC_ViewUser1.ID = ID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmSignIn f1 = new frmSignIn();
            f1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbDate.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy",
              new System.Globalization.CultureInfo("vi-VN"));
        }

        // 🔹 Ẩn tất cả UserControl trước khi hiển thị cái mới
        private void HideAllUserControls()
        {
            uC_DashBoard1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_Order1.Visible = false;
            uC_Supplier1.Visible = false;
            uC_Employee1.Visible = false;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            HideAllUserControls(); // Ẩn tất cả UserControl khác
            uC_DashBoard1.Visible = true;
            uC_DashBoard1.BringToFront();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uC_Order1.Visible = true;
            uC_Order1.BringToFront();

            string tenDangNhap = lbUserName.Text;

            string idNhanVien = function.LayIDNhanVienTheoTenDangNhap(tenDangNhap);
            uC_Order1.SetEmployeeID(idNhanVien);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uC_Supplier1.Visible = true;
            uC_Supplier1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            HideAllUserControls(); // Ẩn tất cả UserControl
            btnDashBoard.PerformClick(); // Mặc định hiển thị Dashboard
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

        private void btnAccountMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenu);
        }

        private void pnSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

      


    }

}


