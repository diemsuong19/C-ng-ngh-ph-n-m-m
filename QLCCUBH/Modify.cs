using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLCCUBH
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand SqlCommand; ///dung de truy van cac cau lenh insert update
        SqlDataReader dataReader; ///docdu lieu trongbang
        public List<TaiKhoanNguoiDung> TaiKhoan(string query)
        {
            List<TaiKhoanNguoiDung> taiKhoans = new List<TaiKhoanNguoiDung>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = SqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoanNguoiDung(dataReader.GetString(0),dataReader.GetString(1)));
                }

                sqlConnection.Close();
            }
                return taiKhoans;
        }

        public void Command (string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand (query, sqlConnection);
                SqlCommand.ExecuteNonQuery();
                sqlConnection.Close ();
            }
        }

    }
}
