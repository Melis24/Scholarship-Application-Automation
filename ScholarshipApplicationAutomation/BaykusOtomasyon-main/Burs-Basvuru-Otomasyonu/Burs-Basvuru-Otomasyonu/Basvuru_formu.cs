using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burs_Basvuru_Otomasyonu
{
    public partial class Basvuru_formu : Form
    {
        public int ogrenci_ID;
        public int ilan_ID;
        public int bursveren_ID;
        public Basvuru_formu()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Ogrenci_formu ogrenci_Formu = new Ogrenci_formu();
            ogrenci_Formu.Ogrenci_ID = ogrenci_ID;
            ogrenci_Formu.Show();
            this.Hide();

        }

        private void buton_basvuru_Click(object sender, EventArgs e)
        {
            try
            {

            
            String Sql = "insert into Basvurular (okudugu_universite_adi,okudugu_universite_bolum,okudugu_universite_sinif,ogrenci_not_ortalamasi,ogrenci_kardes_sayisi,ogrenci_aile_geliri,ogrenci_anne_sagmi,ogrenci_baba_sagmi,ogrenci_id,ilan_id,B_bursveren_id,basvuru_onay) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)";
            SqlConnection conn = new SqlConnection(Veritabanı.getSqlCon());
            
            SqlCommand BasvuruYap = new SqlCommand(Sql, conn);

            BasvuruYap.Parameters.AddWithValue("@p1", txt_uni.Text);
            BasvuruYap.Parameters.AddWithValue("@p2", txt_bolum.Text);
            BasvuruYap.Parameters.AddWithValue("@p3", Convert.ToInt32(txt_sinif.Text));
            BasvuruYap.Parameters.AddWithValue("@p4", txt_not.Text);
            BasvuruYap.Parameters.AddWithValue("@p5", Convert.ToInt32(txt_kardes.Text));
            BasvuruYap.Parameters.AddWithValue("@p6", Convert.ToInt32(txt_gelir.Text));
            BasvuruYap.Parameters.AddWithValue("@p7", (anne_sag.Checked ? true : false));
            BasvuruYap.Parameters.AddWithValue("@p8", (baba_sag.Checked ? true : false));
            BasvuruYap.Parameters.AddWithValue("@p9", ogrenci_ID);
            BasvuruYap.Parameters.AddWithValue("@p10", ilan_ID);
            BasvuruYap.Parameters.AddWithValue("@p11", bursveren_ID);
            BasvuruYap.Parameters.AddWithValue("@p12", "Bekleniyor");

            conn.Open();
            BasvuruYap.ExecuteNonQuery();
            conn.Close();

                MessageBox.Show("Başvurunuz Başarıyla Yapıldı!");
                Ogrenci_formu ogrenci_Formu = new Ogrenci_formu();
                ogrenci_Formu.Ogrenci_ID = ogrenci_ID;
                ogrenci_Formu.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }



        }
    }
}
