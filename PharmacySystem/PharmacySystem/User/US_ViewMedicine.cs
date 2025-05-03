using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PharmacySystem.User
{
    public partial class US_ViewMedicine : UserControl
    {
        function fn = new function();
        String query;
        public US_ViewMedicine()
        {
            InitializeComponent();
        }

        private void US_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medicine";
            setDataGridView(query);
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                if (dt.Columns.Contains("mdate") && row["mdate"] != DBNull.Value)
                {
                    DateTime mdate = Convert.ToDateTime(row["mdate"]);
                    row["mdate"] = mdate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

                if (dt.Columns.Contains("edate") && row["edate"] != DBNull.Value)
                {
                    DateTime edate = Convert.ToDateTime(row["edate"]);
                    row["edate"] = edate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                if (dt.Columns.Contains("edate") && row["edate"] != DBNull.Value)
                {
                    DateTime edate = Convert.ToDateTime(row["importDate"]);
                    row["importDate"] = edate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
            }

            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Font = new Font("Segoe UI", 12);
        }

        String medicineId;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn không?", "Xác Nhận Xóa !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medicine where mid = '" + medicineId + "' ";
                fn.setData(query, "Hồ sơ đã bị xóa");
                US_ViewMedicine_Load(this, null);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medicine where mname like '" + txtSearch.Text + "%'";
            setDataGridView(query);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            US_ViewMedicine_Load(this, null);
        }


        private void txtCheck_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                query = "select * from medicine where edate >= getdate()";
                setDataGridView(query);
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select * from medicine where edate <= getdate()";
                setDataGridView(query);
            }
            else if (txtCheck.SelectedIndex == 2)
            {
                US_ViewMedicine_Load(this, null);
            }
        }
    }
}
