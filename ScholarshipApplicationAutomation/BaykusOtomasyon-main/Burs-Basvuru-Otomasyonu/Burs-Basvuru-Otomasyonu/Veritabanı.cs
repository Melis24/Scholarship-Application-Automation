using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Burs_Basvuru_Otomasyonu
{
    class Veritabanı
    {
        private static string sqlcon = "Server = localhost\\SQLEXPRESS;Database=202503014;Trusted_Connection=True";

        public static string getSqlCon()
        {
            return sqlcon;
        }

        public static void SqlKomutGonder(SqlCommand sqlCommand)
        {
            SqlConnection conn = new SqlConnection(sqlcon);
            sqlCommand.Connection = conn;
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static void datagrid_doldur(DataGridView dataGrid,SqlCommand select,string TableName)
        {
            SqlConnection con = new SqlConnection(sqlcon);
            select.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(select);
            DataSet ds = new DataSet();

            con.Open();

            da.Fill(ds, TableName);
            dataGrid.DataSource = ds.Tables[TableName];

            con.Close();


        }


    }
}
