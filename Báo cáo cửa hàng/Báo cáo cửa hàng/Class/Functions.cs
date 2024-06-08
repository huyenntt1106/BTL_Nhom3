using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Báo_cáo_cửa_hàng.Class
{
    internal class Functions
    {
        public static SqlConnection Conn;
        public static string connString;
        public static void Connect()
        {
            connString = "Data Source=LAPTOP-KVC10ACI\\SQLEXPRESS;Initial Catalog=BaiTapLon;Integrated Security=True;Encrypt=False";
            Conn = new SqlConnection();
            Conn.ConnectionString = connString;
            Conn.Open();
            //MessageBox.Show("Kết nối thành công");
        }

        public static void Disconnect()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Functions.Conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        public static double? GetFieldValues(string sql)
        {
            double? ma = null; 
            SqlCommand cmd = new SqlCommand(sql, Functions.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read()) 
            {
                if (!reader.IsDBNull(0)) 
                {
                    ma = reader.GetDouble(0); 
                }
            }

            reader.Close();
            return ma;
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter();
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = Functions.Conn;
            MyData.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand(sql, Functions.Conn);
            try
            {
                cmd.ExecuteNonQuery();
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
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) &&
                (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1950))
                return true;
            else
                return false;
        }
        public static string ConvertDate(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[2], parts[1], parts[0]);
            return dt;
        }

    }
}
