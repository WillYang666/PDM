using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace PDM
{
    class SQLClass
    {
        public static string Constr ="Data Source =(local); Initial Catalog = Practice; user id = sa; password=sa";
        public static void SQLCommand(string sql)
        {
            SqlConnection conn = new SqlConnection(Constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable SQLQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(Constr);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }
    }
}
