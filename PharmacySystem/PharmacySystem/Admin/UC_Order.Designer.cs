namespace PharmacySystem.Admin
{
    partial class UC_Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Order));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colIDMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchMedicine = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnLessExpired = new System.Windows.Forms.RadioButton();
            this.rbnFull = new System.Windows.Forms.RadioButton();
            this.rbnOutOfStock = new System.Windows.Forms.RadioButton();
            this.rbnLessStock = new System.Windows.Forms.RadioButton();
            this.rbnExpired = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSync = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtpOrderDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSearchMedOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOrderSave = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmailSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSave)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(660, 70);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1667, 1102);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 17;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guna2Panel2);
            this.tabPage1.Controls.Add(this.guna2Panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 74);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1659, 1024);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đặt Thuốc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvOrder);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 216);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1653, 805);
            this.guna2Panel2.TabIndex = 19;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvOrder.ColumnHeadersHeight = 45;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDMedicine,
            this.colNameMedicine,
            this.colNumMedicine,
            this.colmDate,
            this.coleDate,
            this.colQuantity,
            this.colSupplierID,
            this.colRequest});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.Location = new System.Drawing.Point(26, 3);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(1624, 777);
            this.dgvOrder.TabIndex = 21;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrder.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvOrder.ThemeStyle.ReadOnly = true;
            this.dgvOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOrder.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colIDMedicine
            // 
            this.colIDMedicine.HeaderText = "ID Thuốc";
            this.colIDMedicine.Name = "colIDMedicine";
            this.colIDMedicine.ReadOnly = true;
            // 
            // colNameMedicine
            // 
            this.colNameMedicine.HeaderText = "Tên Thuốc";
            this.colNameMedicine.Name = "colNameMedicine";
            this.colNameMedicine.ReadOnly = true;
            // 
            // colNumMedicine
            // 
            this.colNumMedicine.HeaderText = "Mã Số Thuốc";
            this.colNumMedicine.Name = "colNumMedicine";
            this.colNumMedicine.ReadOnly = true;
            // 
            // colmDate
            // 
            this.colmDate.HeaderText = "Ngày Sản Xuất";
            this.colmDate.Name = "colmDate";
            this.colmDate.ReadOnly = true;
            // 
            // coleDate
            // 
            this.coleDate.HeaderText = "Ngày Hết Hạn";
            this.coleDate.Name = "coleDate";
            this.coleDate.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Số Lượng";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colSupplierID
            // 
            this.colSupplierID.HeaderText = "Mã NCC";
            this.colSupplierID.Name = "colSupplierID";
            this.colSupplierID.ReadOnly = true;
            // 
            // colRequest
            // 
            this.colRequest.HeaderText = "";
            this.colRequest.Name = "colRequest";
            this.colRequest.ReadOnly = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnExportExcel);
            this.guna2Panel1.Controls.Add(this.txtSearchMedicine);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1653, 213);
            this.guna2Panel1.TabIndex = 19;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExportExcel.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportExcel.BorderRadius = 15;
            this.btnExportExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportExcel.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportExcel.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExportExcel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExportExcel.Location = new System.Drawing.Point(1470, 102);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(180, 64);
            this.btnExportExcel.TabIndex = 22;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // txtSearchMedicine
            // 
            this.txtSearchMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchMedicine.DefaultText = "";
            this.txtSearchMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMedicine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMedicine.ForeColor = System.Drawing.Color.Black;
            this.txtSearchMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMedicine.Location = new System.Drawing.Point(1172, 102);
            this.txtSearchMedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchMedicine.Name = "txtSearchMedicine";
            this.txtSearchMedicine.PlaceholderText = "              ---- Search ----";
            this.txtSearchMedicine.SelectedText = "";
            this.txtSearchMedicine.Size = new System.Drawing.Size(279, 49);
            this.txtSearchMedicine.TabIndex = 21;
            this.txtSearchMedicine.TextChanged += new System.EventHandler(this.txtSearchMedicine_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1070, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thuốc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnLessExpired);
            this.groupBox1.Controls.Add(this.rbnFull);
            this.groupBox1.Controls.Add(this.rbnOutOfStock);
            this.groupBox1.Controls.Add(this.rbnLessStock);
            this.groupBox1.Controls.Add(this.rbnExpired);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 152);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểm Tra Thuốc";
            // 
            // rbnLessExpired
            // 
            this.rbnLessExpired.AutoSize = true;
            this.rbnLessExpired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnLessExpired.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnLessExpired.Location = new System.Drawing.Point(17, 59);
            this.rbnLessExpired.Name = "rbnLessExpired";
            this.rbnLessExpired.Size = new System.Drawing.Size(192, 31);
            this.rbnLessExpired.TabIndex = 16;
            this.rbnLessExpired.TabStop = true;
            this.rbnLessExpired.Text = "Cận Hạn Sử Dụng";
            this.rbnLessExpired.UseVisualStyleBackColor = true;
            // 
            // rbnFull
            // 
            this.rbnFull.AutoSize = true;
            this.rbnFull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnFull.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFull.Location = new System.Drawing.Point(903, 59);
            this.rbnFull.Name = "rbnFull";
            this.rbnFull.Size = new System.Drawing.Size(88, 31);
            this.rbnFull.TabIndex = 15;
            this.rbnFull.TabStop = true;
            this.rbnFull.Text = "Tất Cả";
            this.rbnFull.UseVisualStyleBackColor = true;
            // 
            // rbnOutOfStock
            // 
            this.rbnOutOfStock.AutoSize = true;
            this.rbnOutOfStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnOutOfStock.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnOutOfStock.Location = new System.Drawing.Point(714, 59);
            this.rbnOutOfStock.Name = "rbnOutOfStock";
            this.rbnOutOfStock.Size = new System.Drawing.Size(149, 31);
            this.rbnOutOfStock.TabIndex = 13;
            this.rbnOutOfStock.TabStop = true;
            this.rbnOutOfStock.Text = "Đã Hết Hàng";
            this.rbnOutOfStock.UseVisualStyleBackColor = true;
            // 
            // rbnLessStock
            // 
            this.rbnLessStock.AutoSize = true;
            this.rbnLessStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnLessStock.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnLessStock.Location = new System.Drawing.Point(493, 59);
            this.rbnLessStock.Name = "rbnLessStock";
            this.rbnLessStock.Size = new System.Drawing.Size(158, 31);
            this.rbnLessStock.TabIndex = 13;
            this.rbnLessStock.TabStop = true;
            this.rbnLessStock.Text = "Sắp Hết Hàng";
            this.rbnLessStock.UseVisualStyleBackColor = true;
            // 
            // rbnExpired
            // 
            this.rbnExpired.AutoSize = true;
            this.rbnExpired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbnExpired.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnExpired.Location = new System.Drawing.Point(238, 59);
            this.rbnExpired.Name = "rbnExpired";
            this.rbnExpired.Size = new System.Drawing.Size(192, 31);
            this.rbnExpired.TabIndex = 13;
            this.rbnExpired.TabStop = true;
            this.rbnExpired.Text = "Quá Hạn Sử Sụng";
            this.rbnExpired.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSync);
            this.tabPage2.Controls.Add(this.guna2PictureBox1);
            this.tabPage2.Controls.Add(this.dtpOrderDate);
            this.tabPage2.Controls.Add(this.txtSearchMedOrder);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvOrderSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 74);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1659, 1024);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đơn Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSync.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSync.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSync.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSync.FillColor = System.Drawing.Color.White;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSync.Location = new System.Drawing.Point(59, 23);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(55, 51);
            this.btnSync.TabIndex = 20;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(30, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(106, 95);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Checked = true;
            this.dtpOrderDate.FillColor = System.Drawing.Color.NavajoWhite;
            this.dtpOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpOrderDate.Location = new System.Drawing.Point(686, 22);
            this.dtpOrderDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpOrderDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(261, 52);
            this.dtpOrderDate.TabIndex = 3;
            this.dtpOrderDate.Value = new System.DateTime(2025, 4, 30, 8, 33, 6, 91);
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // txtSearchMedOrder
            // 
            this.txtSearchMedOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchMedOrder.DefaultText = "";
            this.txtSearchMedOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchMedOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchMedOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMedOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMedOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMedOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtSearchMedOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMedOrder.Location = new System.Drawing.Point(278, 26);
            this.txtSearchMedOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchMedOrder.Name = "txtSearchMedOrder";
            this.txtSearchMedOrder.PlaceholderText = "     ----- Search ------";
            this.txtSearchMedOrder.SelectedText = "";
            this.txtSearchMedOrder.Size = new System.Drawing.Size(229, 48);
            this.txtSearchMedOrder.TabIndex = 2;
            this.txtSearchMedOrder.TextChanged += new System.EventHandler(this.txtSearchMedOrder_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thuốc";
            // 
            // dgvOrderSave
            // 
            this.dgvOrderSave.AllowUserToAddRows = false;
            this.dgvOrderSave.AllowUserToDeleteRows = false;
            this.dgvOrderSave.AllowUserToResizeColumns = false;
            this.dgvOrderSave.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dgvOrderSave.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvOrderSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderSave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvOrderSave.ColumnHeadersHeight = 45;
            this.dgvOrderSave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderID,
            this.colEmployeeID,
            this.colMNumber,
            this.colMedicineName,
            this.colQuantityMedicine,
            this.colOrderDate,
            this.colSupplierName,
            this.colEmailSupplier});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderSave.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvOrderSave.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrderSave.Location = new System.Drawing.Point(39, 107);
            this.dgvOrderSave.Name = "dgvOrderSave";
            this.dgvOrderSave.ReadOnly = true;
            this.dgvOrderSave.RowHeadersVisible = false;
            this.dgvOrderSave.RowTemplate.Height = 24;
            this.dgvOrderSave.Size = new System.Drawing.Size(1583, 826);
            this.dgvOrderSave.TabIndex = 0;
            this.dgvOrderSave.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderSave.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrderSave.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrderSave.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrderSave.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrderSave.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderSave.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrderSave.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOrderSave.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrderSave.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderSave.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOrderSave.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderSave.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvOrderSave.ThemeStyle.ReadOnly = true;
            this.dgvOrderSave.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderSave.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrderSave.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderSave.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOrderSave.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOrderSave.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOrderSave.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colOrderID
            // 
            this.colOrderID.FillWeight = 80F;
            this.colOrderID.HeaderText = "Mã ĐH";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FillWeight = 60F;
            this.colEmployeeID.HeaderText = "Người Đặt";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.ReadOnly = true;
            // 
            // colMNumber
            // 
            this.colMNumber.FillWeight = 80F;
            this.colMNumber.HeaderText = "Số Thuốc";
            this.colMNumber.Name = "colMNumber";
            this.colMNumber.ReadOnly = true;
            // 
            // colMedicineName
            // 
            this.colMedicineName.HeaderText = "Thuốc";
            this.colMedicineName.Name = "colMedicineName";
            this.colMedicineName.ReadOnly = true;
            // 
            // colQuantityMedicine
            // 
            this.colQuantityMedicine.FillWeight = 40F;
            this.colQuantityMedicine.HeaderText = "SL";
            this.colQuantityMedicine.Name = "colQuantityMedicine";
            this.colQuantityMedicine.ReadOnly = true;
            // 
            // colOrderDate
            // 
            this.colOrderDate.HeaderText = "Ngày Đặt ";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            // 
            // colSupplierName
            // 
            this.colSupplierName.FillWeight = 140F;
            this.colSupplierName.HeaderText = "Tên NCC";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.ReadOnly = true;
            // 
            // colEmailSupplier
            // 
            this.colEmailSupplier.FillWeight = 140F;
            this.colEmailSupplier.HeaderText = "Email NCC";
            this.colEmailSupplier.Name = "colEmailSupplier";
            this.colEmailSupplier.ReadOnly = true;
            // 
            // UC_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UC_Order";
            this.Size = new System.Drawing.Size(1667, 1102);
            this.Load += new System.EventHandler(this.UC_Order_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnLessExpired;
        private System.Windows.Forms.RadioButton rbnFull;
        private System.Windows.Forms.RadioButton rbnOutOfStock;
        private System.Windows.Forms.RadioButton rbnLessStock;
        private System.Windows.Forms.RadioButton rbnExpired;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn coleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierID;
        private System.Windows.Forms.DataGridViewButtonColumn colRequest;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOrderSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantityMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmailSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMedOrder;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSync;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMedicine;
    }
}
