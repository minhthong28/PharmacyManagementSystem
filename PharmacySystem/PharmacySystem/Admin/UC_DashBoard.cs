using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

// LiveCharts
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Globalization;
using System.Data.SqlClient;


namespace PharmacySystem.Admin
{
    public partial class UC_DashBoard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        public UC_DashBoard()
        {
            InitializeComponent();
            this.Load += UC_DashBoard_Load;
        }

        private void btnSyn_Click(object sender, EventArgs e)
        {
            UC_DashBoard_Load(this, null);
        }


        private void UC_DashBoard_Load(object sender, EventArgs e)
        {
            // 1. Thống kê Admin / User / Supplier / Medicine
            query = "SELECT COUNT(userRole) FROM users WHERE userRole = 'admin'";
            ds = fn.getData(query);
            setLabel(ds, lbAdmin);

            query = "SELECT COUNT(userRole) FROM users WHERE userRole = 'user'";
            ds = fn.getData(query);
            setLabel(ds, lbUser);

            query = "SELECT COUNT(*) FROM Supplier";
            ds = fn.getData(query);
            setLabel(ds, lbSupplier);

            query = "SELECT COUNT(*) FROM Medicine";
            ds = fn.getData(query);
            setLabel(ds, lbMedicine);

            LoadTopSellingMedicinesChart();
            LoadRevenueLineChart(2);

            string selectedOption = guna2ComboBox1.SelectedItem?.ToString() ?? "Thuốc mới nhập";
            LoadMedicineData(selectedOption);

        }


        // ========== Gán số lượng lên ô ==========
        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds != null
                && ds.Tables.Count > 0
                && ds.Tables[0].Rows.Count > 0)
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            else
                lbl.Text = "0";
        }

        // ========== Biểu đồ thuốc bán chạy ========
        private void LoadTopSellingMedicinesChart()
        {
            //  Tạo điều kiện lọc theo thời gian
            string dateFilter = "";

            if (cbFilterDate.SelectedItem != null)
            {
                string selected = cbFilterDate.SelectedItem.ToString();

                if (selected.Contains("Hôm Nay"))
                    dateFilter = "WHERE CAST(InvoiceDate AS DATE) >= CAST(GETDATE() - 0 AS DATE)";
                else if (selected.Contains("3 Ngày Gần Nhất"))
                    dateFilter = "WHERE CAST(InvoiceDate AS DATE) >= CAST(GETDATE() - 3 AS DATE)";
            }

            // Truy vấn Top 5 thuốc bán chạy 
            string chartQuery = $@"
        SELECT TOP 5 MedicineName, SUM(Quantity) AS TotalSold
        FROM InvoiceDetail
        INNER JOIN Invoice ON InvoiceDetail.InvoiceID = Invoice.InvoiceID
        {dateFilter}
        GROUP BY MedicineName
        ORDER BY TotalSold DESC";

            DataSet dsChart = fn.getData(chartQuery);

            // Đổ dữ liệu lên biểu đồ
            List<string> medicineNames = new List<string>();
            List<int> totals = new List<int>();

            if (dsChart != null && dsChart.Tables.Count > 0)
            {
                foreach (DataRow row in dsChart.Tables[0].Rows)
                {
                    medicineNames.Add(row["MedicineName"].ToString());
                    totals.Add(Convert.ToInt32(row["TotalSold"]));
                }
            }

            // Thiết kế
            var colorList = new[]
            {
        System.Windows.Media.Color.FromRgb(255, 99, 132),
        System.Windows.Media.Color.FromRgb(54, 162, 235),
        System.Windows.Media.Color.FromRgb(255, 206, 86),
        System.Windows.Media.Color.FromRgb(75, 192, 192),
        System.Windows.Media.Color.FromRgb(153, 102, 255)
    };

            var seriesCollection = new SeriesCollection();
            for (int i = 0; i < medicineNames.Count; i++)
            {
                var rowSeries = new RowSeries
                {
                    Title = medicineNames[i],
                    Values = new ChartValues<int> { totals[i] },
                    DataLabels = true,
                    Fill = new System.Windows.Media.SolidColorBrush(colorList[i % colorList.Length]),
                    StrokeThickness = 0
                };
                seriesCollection.Add(rowSeries);
            }

            cartesianChart1.Series = seriesCollection;

            // Cấu hình Legend 
            cartesianChart1.LegendLocation = LegendLocation.Right;
            cartesianChart1.DataTooltip = new DefaultTooltip
            {
                ShowTitle = false 
            };

            // Cấu hình trục Y
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Thuốc",
                ShowLabels = false,
                Separator = new Separator
                {
                    IsEnabled = true,
                    Step = 1,
                    Stroke = System.Windows.Media.Brushes.LightGray,
                    StrokeThickness = 1
                }
            });

            // Trục X
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Số lượng",
                LabelFormatter = value => value.ToString("N0"),
                Separator = new Separator
                {
                    IsEnabled = true,
                    Stroke = System.Windows.Media.Brushes.LightGray,
                    StrokeThickness = 1,
                    Step = 1
                }
            });
        }

        private void cbFilterDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTopSellingMedicinesChart();
        }

        // ========== Biểu đồ doanh thu ==========
        private void LoadRevenueLineChart(int days)
        {
           
            string query = $@"
        SELECT 
            CAST(InvoiceDate AS DATE) AS Ngay,
            SUM(TotalAmount) AS DoanhThu
        FROM Invoice
        {(days > 0 ? "WHERE InvoiceDate >= CAST(GETDATE() - " + days + " AS DATE)" : "")}
        GROUP BY CAST(InvoiceDate AS DATE)
        ORDER BY Ngay";

            DataSet ds = fn.getData(query); 

            List<string> labels = new List<string>();
            ChartValues<decimal> revenues = new ChartValues<decimal>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                labels.Add(Convert.ToDateTime(row["Ngay"]).ToString("dd/MM"));
                revenues.Add(Convert.ToDecimal(row["DoanhThu"]));
            }

            // Tạo LineSeries
            var lineSeries = new LineSeries
            {
                Title = "Doanh thu",
                Values = revenues,
                LineSmoothness = 0.5,
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 10,
                Stroke = System.Windows.Media.Brushes.Blue,
                Fill = System.Windows.Media.Brushes.LightBlue,
                StrokeThickness = 2
            };

            cartesianChartRevenue.Series = new SeriesCollection { lineSeries };

            // trục X
            cartesianChartRevenue.AxisX.Clear();
            cartesianChartRevenue.AxisX.Add(new Axis
            {
                Title = "Ngày",
                Labels = labels,
                Separator = new Separator { Step = 1, IsEnabled = false }
            });

            // Trục Y
            cartesianChartRevenue.AxisY.Clear();
            cartesianChartRevenue.AxisY.Add(new Axis
            {
                Title = "Doanh thu (VND)",
                LabelFormatter = value => value.ToString("N0")
            });

            cartesianChartRevenue.DataTooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };

            cartesianChartRevenue.LegendLocation = LegendLocation.None;
        }

        private void comboBoxTimeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTimeFilter.SelectedItem.ToString())
            {
                case "3 Ngày Gần Nhất":
                    LoadRevenueLineChart(2);
                    break;
                case "5 Ngày Gần Nhất":
                    LoadRevenueLineChart(4);
                    break;
            }
        }

        // ========== Bảng thông tin thuốc ==========
        private void LoadMedicineData(string filterOption)
        {
            string query = "";

            if (filterOption.Contains("Thuốc Mới Nhập"))
            {
                query = @"
        SELECT 
            m.mid, m.mname, m.mnumber, 
            m.mDate, m.eDate, m.quantity, 
            m.perUnit, m.SupplierId, m.employeeID, m.importDate
        FROM Medicine m
        WHERE CAST(m.importDate AS DATE) >= CAST(GETDATE() - 3 AS DATE)";
            }
            else
            {
                query = @"
        SELECT 
            m.mid, m.mname, m.mnumber, 
            m.mDate, m.eDate, m.quantity, 
            m.perUnit, m.SupplierId, m.employeeID, m.importDate
        FROM Medicine m";
            }

            DataSet ds = fn.getData(query);
            guna2DataGridView1.Rows.Clear(); 
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(
                    row["mid"].ToString(),
                    row["mname"].ToString(),
                    row["mnumber"].ToString(),
                    Convert.ToDateTime(row["mDate"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Convert.ToDateTime(row["eDate"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    row["quantity"].ToString(),
                    row["perUnit"].ToString(),
                    row["SupplierId"].ToString(),
                    row["employeeID"].ToString(),
                    Convert.ToDateTime(row["importDate"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                );
            }
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = guna2ComboBox1.SelectedItem.ToString();
            LoadMedicineData(selectedOption);
        }

        private void txtSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchMedicine.Text.Trim().ToLower();

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells["colNameDrug"].Value != null)
                {
                    string medicineName = row.Cells["colNameDrug"].Value.ToString().ToLower();
                    row.Visible = medicineName.Contains(searchText);
                }
            }
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchEmployee.Text.Trim().ToLower();

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (row.Cells["colemployeeId"].Value != null)
                {
                    string employeeId = row.Cells["colemployeeId"].Value.ToString().ToLower();
                    row.Visible = employeeId.Contains(searchText);
                }
            }
        }

       
    }
}
