namespace PharmacySystem
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewUser = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Order1 = new PharmacySystem.Admin.UC_Order();
            this.uC_Employee1 = new PharmacySystem.Admin.UC_Employee();
            this.uC_Supplier1 = new PharmacySystem.Admin.UC_Supplier();
            this.uC_ViewUser1 = new PharmacySystem.Admin.UC_ViewUser();
            this.uC_AddUser1 = new PharmacySystem.Admin.UC_AddUser();
            this.uC_DashBoard1 = new PharmacySystem.Admin.UC_DashBoard();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccountMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.pnSubMenu = new System.Windows.Forms.Panel();
            this.btnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            this.pnSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.FillColor = System.Drawing.Color.Thistle;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddUser.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(298, 55);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewUser.FillColor = System.Drawing.Color.Thistle;
            this.btnViewUser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnViewUser.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnViewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewUser.Image")));
            this.btnViewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewUser.Location = new System.Drawing.Point(0, 55);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(298, 55);
            this.btnViewUser.TabIndex = 4;
            this.btnViewUser.Text = "Tìm Kiếm";
            this.btnViewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Order1);
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_Supplier1);
            this.panel2.Controls.Add(this.uC_ViewUser1);
            this.panel2.Controls.Add(this.uC_AddUser1);
            this.panel2.Controls.Add(this.uC_DashBoard1);
            this.panel2.Location = new System.Drawing.Point(299, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2170, 1567);
            this.panel2.TabIndex = 1;
            // 
            // uC_Order1
            // 
            this.uC_Order1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Order1.Location = new System.Drawing.Point(0, 0);
            this.uC_Order1.Name = "uC_Order1";
            this.uC_Order1.Size = new System.Drawing.Size(2170, 1567);
            this.uC_Order1.TabIndex = 6;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.LightBlue;
            this.uC_Employee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Employee1.Location = new System.Drawing.Point(0, 0);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(2170, 1567);
            this.uC_Employee1.TabIndex = 5;
            // 
            // uC_Supplier1
            // 
            this.uC_Supplier1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_Supplier1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Supplier1.Location = new System.Drawing.Point(0, 0);
            this.uC_Supplier1.Name = "uC_Supplier1";
            this.uC_Supplier1.Size = new System.Drawing.Size(2170, 1567);
            this.uC_Supplier1.TabIndex = 4;
            // 
            // uC_ViewUser1
            // 
            this.uC_ViewUser1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_ViewUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_ViewUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewUser1.Name = "uC_ViewUser1";
            this.uC_ViewUser1.Size = new System.Drawing.Size(2170, 1567);
            this.uC_ViewUser1.TabIndex = 2;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.LightBlue;
            this.uC_AddUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(2170, 1567);
            this.uC_AddUser1.TabIndex = 1;
            // 
            // uC_DashBoard1
            // 
            this.uC_DashBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_DashBoard1.Location = new System.Drawing.Point(0, 0);
            this.uC_DashBoard1.Name = "uC_DashBoard1";
            this.uC_DashBoard1.Size = new System.Drawing.Size(2170, 1567);
            this.uC_DashBoard1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.CustomBorderColor = System.Drawing.Color.Gray;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.SlateBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogOut.Location = new System.Drawing.Point(3, 452);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(299, 60);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAccountMenu
            // 
            this.btnAccountMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccountMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccountMenu.FillColor = System.Drawing.Color.SlateBlue;
            this.btnAccountMenu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountMenu.ForeColor = System.Drawing.Color.White;
            this.btnAccountMenu.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAccountMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountMenu.Image")));
            this.btnAccountMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccountMenu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAccountMenu.Location = new System.Drawing.Point(3, 135);
            this.btnAccountMenu.Name = "btnAccountMenu";
            this.btnAccountMenu.Size = new System.Drawing.Size(299, 60);
            this.btnAccountMenu.TabIndex = 5;
            this.btnAccountMenu.Text = "Tài Khoản";
            this.btnAccountMenu.Click += new System.EventHandler(this.btnAccountMenu_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.SlateBlue;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnOrder.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.ImageSize = new System.Drawing.Size(50, 45);
            this.btnOrder.Location = new System.Drawing.Point(3, 386);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(299, 60);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Đặt Hàng";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnSubMenu
            // 
            this.pnSubMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.pnSubMenu.Controls.Add(this.btnViewUser);
            this.pnSubMenu.Controls.Add(this.btnAddUser);
            this.pnSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenu.Location = new System.Drawing.Point(3, 201);
            this.pnSubMenu.Name = "pnSubMenu";
            this.pnSubMenu.Size = new System.Drawing.Size(298, 113);
            this.pnSubMenu.TabIndex = 11;
            this.pnSubMenu.Visible = false;
            this.pnSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSubMenu_Paint);
            // 
            // btnSupplier
            // 
            this.btnSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupplier.FillColor = System.Drawing.Color.SlateBlue;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.ImageSize = new System.Drawing.Size(30, 40);
            this.btnSupplier.Location = new System.Drawing.Point(3, 320);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(299, 60);
            this.btnSupplier.TabIndex = 12;
            this.btnSupplier.Text = "Nhà Cung Cấp";
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashBoard.FillColor = System.Drawing.Color.SlateBlue;
            this.btnDashBoard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDashBoard.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashBoard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashBoard.Location = new System.Drawing.Point(3, 3);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(299, 60);
            this.btnDashBoard.TabIndex = 2;
            this.btnDashBoard.Text = "DashBoard ";
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.guna2Panel1);
            this.panel3.Controls.Add(this.lbDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 870);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 180);
            this.panel3.TabIndex = 8;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.lbTime);
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 21);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(279, 84);
            this.guna2Panel1.TabIndex = 4;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Black;
            this.lbTime.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Lime;
            this.lbTime.Location = new System.Drawing.Point(12, 19);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(104, 45);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Time";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Location = new System.Drawing.Point(10, 129);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(64, 28);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.lbUserName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 100);
            this.panel4.TabIndex = 10;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Yellow;
            this.lbUserName.Location = new System.Drawing.Point(25, 39);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(250, 34);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "label2";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Xin chào,";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnAccountMenu);
            this.panel1.Controls.Add(this.pnSubMenu);
            this.panel1.Controls.Add(this.btnSupplier);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 563);
            this.panel1.TabIndex = 2;
            // 
            // btnEmployee
            // 
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.SlateBlue;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageSize = new System.Drawing.Size(40, 50);
            this.btnEmployee.Location = new System.Drawing.Point(3, 69);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(299, 60);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Nhân Viên";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateBlue;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 307);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 1050);
            this.panel6.TabIndex = 2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.pnSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnViewUser;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Admin.UC_DashBoard uC_DashBoard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Admin.UC_AddUser uC_AddUser1;
        private Admin.UC_ViewUser uC_ViewUser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Button btnAccountMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnSubMenu;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbTime;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSupplier;
        private Admin.UC_Supplier uC_Supplier1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Admin.UC_Employee uC_Employee1;
        private Admin.UC_Order uC_Order1;
    }
}