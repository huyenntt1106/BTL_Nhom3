using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormNhanVien.Class
{
    internal class Functions
    {
        public static SqlConnection Conn;
        public static string connstring;
        public static void ketnoi()
        {
            connstring = "Data Source=DESKTOP-FRLG1EC;Initial Catalog=BaiTapLon;Integrated Security=True;Encrypt=False";
            Conn = new SqlConnection();
            Conn.ConnectionString = connstring;
            Conn.Open();
            //MessageBox.Show("Done");
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter();	// Khai báo
            // Tạo đối tượng Command thực hiện câu lệnh SELECT        
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = Class.Functions.Conn; 	// Kết nối CSDL
            Mydata.SelectCommand.CommandText = sql;	// Gán câu lệnh SELECT
            DataTable table = new DataTable();    // Khai báo DataTable nhận dữ liệu trả về
            Mydata.Fill(table); 	//Thực hiện câu lệnh SELECT và đổ dữ liệu vào bảng table
            return table;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd; // Khai báo đối tượng SqlCommand
            cmd = new SqlCommand(); // Khởi tạo đối tượng
            cmd.Connection = Class.Functions.Conn; // kết nối
            cmd.CommandText = sql; // Gán câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); // Thực hiện câu lệnh SQL
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Class.Functions.Conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;

            cbo.ValueMember = ma;    // Truong gia tri
           // cbo.DisplayMember = ten;    // Truong hien thi
        }
    }
}
