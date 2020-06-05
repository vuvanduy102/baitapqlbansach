using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_ban_sach
{
    class Functions
    {
        public static SqlConnection con;
        public static void Connection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-6TI18BN\\SQLEXPRESS;Initial Catalog=QuanLyCuaHangSach;Integrated Security=True";
            con.Open();
        }
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            DataTable table = new DataTable();//Khai báo đối tượng table thuộc lớp DataTable
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            return table;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static bool CheckKeys(string sql, string str)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(str, con);
            dap.Fill(table);
            adp.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;

        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        public static void FillCombo1(string sql, ComboBox cbo, string ma)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị

        }


        public static void RunSQL(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
    }
}
