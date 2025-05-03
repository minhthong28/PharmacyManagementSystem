namespace PharmacySystem.Admin
{
    partial class OrderRequest
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSendEmail = new Guna.UI2.WinForms.Guna2Button();
            this.nbrQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSupplierName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumberMedicine = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDEmployee = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNameMedicine = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(550, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 67);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSendEmail.ForeColor = System.Drawing.Color.White;
            this.btnSendEmail.Location = new System.Drawing.Point(238, 548);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(180, 67);
            this.btnSendEmail.TabIndex = 26;
            this.btnSendEmail.Text = "Gửi Email";
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // nbrQuantity
            // 
            this.nbrQuantity.BackColor = System.Drawing.Color.Transparent;
            this.nbrQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbrQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nbrQuantity.Location = new System.Drawing.Point(238, 348);
            this.nbrQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nbrQuantity.Name = "nbrQuantity";
            this.nbrQuantity.Size = new System.Drawing.Size(114, 48);
            this.nbrQuantity.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Số Lượng Thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email Nhà Cung Cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên Nhà Cung Cấp";
            // 
            // txtEmailSupplier
            // 
            this.txtEmailSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailSupplier.DefaultText = "";
            this.txtEmailSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailSupplier.FillColor = System.Drawing.Color.PaleGoldenrod;
            this.txtEmailSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailSupplier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSupplier.ForeColor = System.Drawing.Color.Black;
            this.txtEmailSupplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailSupplier.Location = new System.Drawing.Point(511, 457);
            this.txtEmailSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailSupplier.Name = "txtEmailSupplier";
            this.txtEmailSupplier.PlaceholderText = "";
            this.txtEmailSupplier.ReadOnly = true;
            this.txtEmailSupplier.SelectedText = "";
            this.txtEmailSupplier.Size = new System.Drawing.Size(406, 48);
            this.txtEmailSupplier.TabIndex = 20;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierName.DefaultText = "";
            this.txtSupplierName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupplierName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupplierName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplierName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplierName.FillColor = System.Drawing.Color.PaleGoldenrod;
            this.txtSupplierName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupplierName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupplierName.Location = new System.Drawing.Point(61, 457);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PlaceholderText = "";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.Size = new System.Drawing.Size(406, 48);
            this.txtSupplierName.TabIndex = 21;
            // 
            // txtNumberMedicine
            // 
            this.txtNumberMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumberMedicine.DefaultText = "";
            this.txtNumberMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumberMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumberMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumberMedicine.FillColor = System.Drawing.Color.PaleGoldenrod;
            this.txtNumberMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberMedicine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberMedicine.ForeColor = System.Drawing.Color.Black;
            this.txtNumberMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumberMedicine.Location = new System.Drawing.Point(511, 275);
            this.txtNumberMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberMedicine.Name = "txtNumberMedicine";
            this.txtNumberMedicine.PlaceholderText = "";
            this.txtNumberMedicine.ReadOnly = true;
            this.txtNumberMedicine.SelectedText = "";
            this.txtNumberMedicine.Size = new System.Drawing.Size(406, 48);
            this.txtNumberMedicine.TabIndex = 19;
            // 
            // txtIDEmployee
            // 
            this.txtIDEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDEmployee.DefaultText = "";
            this.txtIDEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDEmployee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtIDEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDEmployee.Location = new System.Drawing.Point(511, 145);
            this.txtIDEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDEmployee.Name = "txtIDEmployee";
            this.txtIDEmployee.PlaceholderText = "";
            this.txtIDEmployee.SelectedText = "";
            this.txtIDEmployee.Size = new System.Drawing.Size(406, 48);
            this.txtIDEmployee.TabIndex = 18;
            // 
            // txtIDOrder
            // 
            this.txtIDOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDOrder.DefaultText = "";
            this.txtIDOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDOrder.FillColor = System.Drawing.Color.Silver;
            this.txtIDOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrder.ForeColor = System.Drawing.Color.Black;
            this.txtIDOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDOrder.Location = new System.Drawing.Point(61, 145);
            this.txtIDOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDOrder.Name = "txtIDOrder";
            this.txtIDOrder.PlaceholderText = "";
            this.txtIDOrder.SelectedText = "";
            this.txtIDOrder.Size = new System.Drawing.Size(406, 48);
            this.txtIDOrder.TabIndex = 17;
            // 
            // txtNameMedicine
            // 
            this.txtNameMedicine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameMedicine.DefaultText = "";
            this.txtNameMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameMedicine.FillColor = System.Drawing.Color.PaleGoldenrod;
            this.txtNameMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameMedicine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameMedicine.ForeColor = System.Drawing.Color.Black;
            this.txtNameMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameMedicine.Location = new System.Drawing.Point(61, 275);
            this.txtNameMedicine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameMedicine.Name = "txtNameMedicine";
            this.txtNameMedicine.PlaceholderText = "";
            this.txtNameMedicine.ReadOnly = true;
            this.txtNameMedicine.SelectedText = "";
            this.txtNameMedicine.Size = new System.Drawing.Size(406, 48);
            this.txtNameMedicine.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã Số Thuốc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(507, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "ID Người Lập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã Đơn Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đặt Hàng";
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(443, 330);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(90, 90);
            this.guna2ProgressIndicator1.TabIndex = 30;
            this.guna2ProgressIndicator1.Visible = false;
            // 
            // OrderRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(979, 638);
            this.Controls.Add(this.guna2ProgressIndicator1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.nbrQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailSupplier);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtNumberMedicine);
            this.Controls.Add(this.txtIDEmployee);
            this.Controls.Add(this.txtIDOrder);
            this.Controls.Add(this.txtNameMedicine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderRequest";
            this.Load += new System.EventHandler(this.OrderRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSendEmail;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbrQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplierName;
        private Guna.UI2.WinForms.Guna2TextBox txtNumberMedicine;
        private Guna.UI2.WinForms.Guna2TextBox txtIDEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txtIDOrder;
        private Guna.UI2.WinForms.Guna2TextBox txtNameMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
    }
}