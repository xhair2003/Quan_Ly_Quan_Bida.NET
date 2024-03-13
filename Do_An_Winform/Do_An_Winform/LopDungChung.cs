using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Winform
{
    internal class LopDungChung
    {
        string chuoi_kn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Code_Space\Do_An_Winform\Do_An_Winform\DataBase.mdf;Integrated Security=True";
        SqlConnection connect;
        public LopDungChung()
        {
            connect = new SqlConnection(chuoi_kn);
        }
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, connect);
            connect.Open();
            int kq = comm.ExecuteNonQuery();
            connect.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, connect);
            connect.Open();
            object kq = comm.ExecuteScalar();
            connect.Close();
            return kq;
        }

    }
}
