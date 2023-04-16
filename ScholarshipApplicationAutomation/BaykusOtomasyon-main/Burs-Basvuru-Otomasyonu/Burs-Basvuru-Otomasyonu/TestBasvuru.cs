using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burs_Basvuru_Otomasyonu
{
    class TestBasvuru
    {
        DataSet dataSet = new DataSet();

        public TestBasvuru()
        {
            SqlCommand select = new SqlCommand("Select * from Basvurular");
            SqlConnection con = new SqlConnection(Veritabanı.getSqlCon());
            select.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(select);
            DataSet ds = new DataSet();

            con.Open();

            da.Fill(ds,"Basvurular");
          

            con.Close();
        }

    }
}
