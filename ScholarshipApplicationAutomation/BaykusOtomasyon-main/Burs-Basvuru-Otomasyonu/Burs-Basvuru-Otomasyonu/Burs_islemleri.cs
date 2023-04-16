using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burs_Basvuru_Otomasyonu
{
    class Burs_islemleri
    {
        public static void Burs_ilani_ekle(string ad, string ozellik,int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Veritabanı.getSqlCon());
                SqlCommand burs = new SqlCommand("insert into Ilanlar (ilan_adi,ilan_ozellikleri,bursveren_id) values(@p1,@p2,@p3)", conn);
                burs.Parameters.AddWithValue("@p1", ad);
                burs.Parameters.AddWithValue("@p2", ozellik);
                burs.Parameters.AddWithValue("@p3", id);

                conn.Open();
                burs.ExecuteNonQuery();
                conn.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void Burs_ilani_sil(int ilan_id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Veritabanı.getSqlCon());
                SqlCommand ilan_sil = new SqlCommand("delete from Ilanlar where ilan_id = @p1", conn);
                ilan_sil.Parameters.AddWithValue("@p1", ilan_id);

                conn.Open();

                ilan_sil.ExecuteNonQuery();
                conn.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }

        public static void Basvuru_durumunu_guncelle(SqlCommand sql)
        {
            SqlConnection conn = new SqlConnection(Veritabanı.getSqlCon());
            sql.Connection = conn;
            
            conn.Open();
            sql.ExecuteNonQuery();
            conn.Close();
           

        }
    }
}
