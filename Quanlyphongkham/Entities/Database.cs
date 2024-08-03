using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quanlyphongkham.Entities
{
    internal class Database
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand sqlcmd;

        public Database()
        {
            string strCnn = "Data Source=DESKTOP-85CF1R9;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True";

            sqlConn = new SqlConnection(strCnn);
        }

        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string sqlStr)
        {
            sqlcmd = new SqlCommand(sqlStr, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
