using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Burs_Basvuru_Otomasyonu
{
    class Giris_paneli
    {

       static SqlConnection con;
       static SqlCommand cmd;
       static SqlDataReader dr;
       public static int kullaniciID = -1;
        public static bool giris(string sql, string txt_kullanici, string txt_sifre,string idtext)
        {
            txt_sifre = Sifreleme.md5sifreleme(txt_sifre);
            
            con = new SqlConnection(Veritabanı.getSqlCon());
            con.Open();

            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@p1", txt_kullanici);
            cmd.Parameters.AddWithValue("@p2", txt_sifre);

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                kullaniciID = Convert.ToInt32(dr[idtext]);
                con.Close();
                
                return true;
            }
            con.Close();
            return false;
            


        }


        public static bool kayit_ol(SqlCommand sqlCommand)
        {
            try
            {
                con = new SqlConnection(Veritabanı.getSqlCon());

                sqlCommand.Connection = con;

                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                return true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }




    }
}
