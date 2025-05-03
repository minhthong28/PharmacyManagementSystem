using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PharmacySystem
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=.;Initial Catalog=PharmacyManagement;Integrated Security=True";
            return cn;
        }

        public DataSet getData(String query)
        {
            SqlConnection cn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String msg)
        {
            SqlConnection cn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cn.Close();
            if (msg != null)
            {
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.DoEvents(); 
            }
        }


        // ========== NHÀ CUNG CẤP ==========
        public DataTable GetAllSuppliers()
        {
            SqlConnection cn = getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataRow GetSupplierByID(string supplierID)
        {
            SqlConnection cn = getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier WHERE SupplierID = @SupplierID", cn);
            cmd.Parameters.AddWithValue("@SupplierID", supplierID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        // Stored Procedure
        public bool AddSupplier(string supplierID, string supplierName, string email, string contact, string drugsAvailable)
        {
            using (SqlConnection cn = getConnection())
            {
                using (SqlCommand cmd = new SqlCommand("AddSupplier", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@DrugsAvailable", drugsAvailable);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public void DeleteSupplier(string supplierID)
        {
            using (SqlConnection cn = getConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteSupplier", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public bool UpdateSupplier(string supplierID, string name, string email, string contact, string drugs)
        {
            using (SqlConnection cn = getConnection())
            using (SqlCommand cmd = new SqlCommand("sp_UpdateSupplier", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                cmd.Parameters.AddWithValue("@SupplierName", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@DrugsAvailable", drugs);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi cập nhật",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        // ========== NHÂN VIÊN ==========
        public DataTable GetAllEmployees()
        {
            SqlConnection cn = getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //public DataRow GetEmployeeByID(string employeeID)
        //{
        //    using (SqlConnection cn = getConnection())
        //    using (SqlCommand cmd = new SqlCommand(
        //         "SELECT name FROM Employee WHERE employeeID = @employeeID", cn))
        //    {
        //        cmd.Parameters.AddWithValue("@employeeID", employeeID);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        //    }
        //}

        public static string LayIDNhanVienTheoTenDangNhap(string tenDangNhap)
        {
            string idNhanVien = "";
            // Tạo instance function để gọi getConnection()
            function fn = new function();

            using (SqlConnection conn = fn.getConnection())
            {
                // JOIN đúng tên bảng Employee và users
                string query = @"
            SELECT e.employeeID 
            FROM Employee e
            JOIN users u 
              ON e.userID = u.id
            WHERE u.username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", tenDangNhap);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        idNhanVien = result.ToString();
                }
            }

            return idNhanVien;
        }

        // Stored Procedure
        public bool AddEmployee(string employeeID, string name, DateTime birthDate, string phone, string gender, DateTime hireDate, string userID)
        {
            using (SqlConnection cn = getConnection())
            using (SqlCommand cmd = new SqlCommand("sp_AddEmployee", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@HireDate", hireDate);
                cmd.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public void DeleteEmployee(string employeeID)
        {
            using (SqlConnection cn = getConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteEmployee", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public bool UpdateEmployee(string employeeID, string name, DateTime birth, string phone, string gender, DateTime hire, string userID)
        {
            using (SqlConnection cn = getConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@BirthDate", birth);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@HireDate", hire);
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        // ========== ĐẶT HÀNG ==========

        public DataTable GetAllMedicinesForOrder()
        {
            SqlConnection conn = getConnection();
            string query = @"SELECT mid, mname, mnumber, mDate, eDate, quantity, SupplierId FROM Medicine";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool InsertOrder(string orderID, string employeeID,
                        string mNumber, string medicineName, int quantity,
                        DateTime orderDate, string supplierName, string supplierEmail)
        {
            string query = @" INSERT INTO Orders (OrderID, EmployeeID, MNumber, MedicineName, Quantity, OrderDate, SupplierName, SupplierEmail)
                              VALUES (@orderID, @employeeID, @mNumber, @medicineName, @quantity, @orderDate, @supplierName, @supplierEmail)";
            try
            {
                using (SqlConnection cn = getConnection())
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    cmd.Parameters.AddWithValue("@mNumber", mNumber);
                    cmd.Parameters.AddWithValue("@medicineName", medicineName);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@orderDate", orderDate);
                    cmd.Parameters.AddWithValue("@supplierName", supplierName);
                    cmd.Parameters.AddWithValue("@supplierEmail", supplierEmail);

                    cn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception)
            {
                // Có thể log chi tiết ex.Message nếu cần
                return false;
            }
        }
        public string GenerateUniqueOrderID()
        {
            string prefix = "ORD";
            int counter = 1;
            string newID;
            int exists;  

            using (SqlConnection cn = getConnection())
            using (SqlCommand cmd = new SqlCommand("", cn))
            {
                cn.Open();
                do
                {
                    newID = $"{prefix}{counter:0000}";
                    cmd.CommandText = "SELECT COUNT(*) FROM Orders WHERE OrderID = @id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", newID);

                    exists = (int)cmd.ExecuteScalar();  // gán biến exists
                    counter++;
                }
                while (exists > 0);  // bây giờ exists hợp lệ ở đây
            }

            return newID;
        }

        public DataTable GetAllForOrder()
        {
            SqlConnection conn = getConnection();
            string query = @"SELECT OrderID, EmployeeID, MNumber, MedicineName, Quantity, OrderDate, SupplierName, SupplierEmail FROM Orders";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }

}


