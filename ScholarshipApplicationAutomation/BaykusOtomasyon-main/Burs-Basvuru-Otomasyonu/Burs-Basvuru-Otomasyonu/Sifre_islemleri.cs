using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burs_Basvuru_Otomasyonu
{
    class Sifre_islemleri
    {
       private static SqlConnection conn = new SqlConnection(Veritabanı.getSqlCon());
        public static bool sifre_yenile(string eski_sifre,string yeni_sifre,int kID,string tableName,string idname)
        {

            //txtden eski şifre al
            //md5 sifrele
            eski_sifre = Sifreleme.md5sifreleme(eski_sifre);
            yeni_sifre = Sifreleme.md5sifreleme(yeni_sifre);

            
            
            
            string sql = "select * from " + tableName + " where " + idname + "_id= @p1 and " +idname+ "_sifre = @p2";
            SqlCommand sqlCommand = new SqlCommand(sql,conn);

            sqlCommand.Parameters.AddWithValue("@p1", kID);
            sqlCommand.Parameters.AddWithValue("@p2", eski_sifre);

            SqlDataReader dr;
            conn.Open();
            dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                sifredegistir(yeni_sifre, kID, tableName, idname);
                return true;
            }


            return false;

        }

        private static void sifredegistir(string yeni_sifre, int kID, string tableName, string idname)
        {
            string Sql = "update " + tableName + " set " + idname + "_sifre = @p1 where " + idname + "_id = @p2";
            SqlCommand sifreyenile = new SqlCommand(Sql, conn);
            sifreyenile.Parameters.AddWithValue("@p1", yeni_sifre);
            sifreyenile.Parameters.AddWithValue("@p2", kID);

            conn.Open();
            sifreyenile.ExecuteNonQuery();
            conn.Close();

        }










    }
}
