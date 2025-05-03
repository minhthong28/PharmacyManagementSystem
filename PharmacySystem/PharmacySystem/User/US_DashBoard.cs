using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.User
{
    public partial class US_DashBoard : UserControl
    {
        function fn = new function();
        string query;
        DataSet dsDB;
        Int64 count;
        public US_DashBoard()
        {
            InitializeComponent();
        }

        private void US_DashBoard_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        public void loadChart()
        {
            query = "select count(mname) from medicine where edate >= getdate()";
            dsDB = fn.getData(query);
            count = Int64.Parse(dsDB.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Thuốc còn hạn"].Points.AddXY("Biểu đồ thuốc còn hạn sử dụng",count);

            query = "select count(mname) from medicine where edate <= getdate()";
            dsDB = fn.getData(query);
            count = Int64.Parse(dsDB.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Thuốc hết hạn"].Points.AddXY("Biểu đồ thuốc còn hạn sử dụng", count);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            chart1.Series["Thuốc còn hạn"].Points.Clear();
            chart1.Series["Thuốc hết hạn"].Points.Clear();
            loadChart();
        }
    }
}
