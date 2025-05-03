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
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }
        public int s = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s < 100) 
            {
                s += 1;
                pgBar.Value = s; // Cập nhật ProgressBar
                lbPercent.Text = s + "%";
                if (s >= 90)
                {
                    pgBar.ProgressColor = Color.OrangeRed; 
                    pgBar.ProgressColor2 = Color.Yellow;
                }

                if (s == 100) 
                {
                    timer1.Stop();
                    lbLoad.Text = "Completed"; 
                    lbLoad.ForeColor = System.Drawing.Color.LimeGreen; 

                    // Tạo độ trễ để hiển thị "Completed" trước khi mở Form mới
                    this.Refresh(); 
                    System.Threading.Thread.Sleep(1000); 

                    frmSignIn SignIn = new frmSignIn();
                    SignIn.Show();
                    this.Hide();
                }
            }
        }
    }
}
