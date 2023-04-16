using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burs_Basvuru_Otomasyonu
{
    public partial class Ogrenci_formu : Form
    {
        public int Ogrenci_ID;

        string[] datagrid1_isimler = { "İlan ID", "İlan Adı", "İstenen Özellikler" };
        string[] datagrid2_isimler = { "İlan Adı","Başvuru ID","Üniversite Adı","Bölüm Adı","Sınıf","Not Ortalaması","Kardeş Sayısı","Aile Geliri","Anne Hayatta mi","Baba Hayatta mi","Öğrenci ID","Başvuru Durumu",};
        public Ogrenci_formu()
        {
            InitializeComponent();
        }

        private int sonuc;

        private void captcha_olustur()
        {
            label4.Visible = true;
            Random sayi = new Random();

            int ilk_sayi = sayi.Next(0, 90);
            int ikinci_sayi = sayi.Next(0, 10);

            sonuc = ilk_sayi + ikinci_sayi;

            label4.Text = ilk_sayi.ToString() + "+" + ikinci_sayi.ToString() + "=";
        }

        private void datagrid1doldur()
        {
            SqlCommand select = new SqlCommand("select * from Ilanlar");
         
            Veritabanı.datagrid_doldur(dataGridView1, select, "Ilanlar");

            for(int i = 0; i < datagrid1_isimler.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = datagrid1_isimler[i];
            }

        
        }

        private void datagrid2doldur()
        {
            SqlCommand select = new SqlCommand("Select ilan_adi,basvuru_id,okudugu_universite_adi,okudugu_universite_bolum,okudugu_universite_sinif,ogrenci_not_ortalamasi,ogrenci_kardes_sayisi,ogrenci_aile_geliri,ogrenci_anne_sagmi,ogrenci_baba_sagmi,ogrenci_id,basvuru_onay from Basvurular INNER JOIN Ilanlar ON Basvurular.ilan_id = Ilanlar.ilan_id where ogrenci_id = @p1");
            select.Parameters.AddWithValue("@p1", Ogrenci_ID);
            Veritabanı.datagrid_doldur(dataGridView2, select, "Basvurular");

            for (int i = 0; i < datagrid2_isimler.Length; i++)
            {
                dataGridView2.Columns[i].HeaderText = datagrid2_isimler[i];
            }

            for(int i = 8; i <= 10; i++)
            {
                dataGridView2.Columns[i].Visible = false;
            }
        }

        private void Ogrenci_formu_Load(object sender, EventArgs e)
        {
            captcha_olustur();
            datagrid1doldur();
            Thread.Sleep(5);
            datagrid2doldur();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_yenitekrar.Text == txt_yeni.Text)
            {
                if (Convert.ToInt32(captcha.Text) == sonuc)
                {
                    bool kontrol = Sifre_islemleri.sifre_yenile(txt_eski.Text, txt_yeni.Text, Ogrenci_ID, "Ogrenciler", "ogrenci");
                    if (kontrol)
                    {
                        MessageBox.Show("Şifreniz başarıyla değiştirildi!");
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz değiştirilemedi!");
                    }
                }
                else
                {
                    MessageBox.Show("Doğrulama işlemi yanlış!");
                    captcha_olustur();
                }

            }
            else
            {
                MessageBox.Show("Girdiğiniz parolalar eşleşmiyor!");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Basvuru_formu basvuru = new Basvuru_formu();
            basvuru.ogrenci_ID = Ogrenci_ID;
            basvuru.ilan_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            basvuru.bursveren_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            basvuru.Show();
            this.Hide();
        }

        private void sil_buton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Başvurunuzu silmek istediğinize emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(Veritabanı.getSqlCon());
                SqlCommand delete = new SqlCommand("Delete from Basvurular where basvuru_id = @p1",conn);
                delete.Parameters.AddWithValue("@p1", Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value));

                conn.Open();
                delete.ExecuteNonQuery();
                conn.Close();

                datagrid2doldur();
            }

        }

        private void ilan_arama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sql;
            if (ilan_arama.Text.Length > 0)
            {
                if (ilan_cb.SelectedIndex == 0)
                {
                    sql = new SqlCommand("Select * from Ilanlar where ilan_id LIKE '%" + Convert.ToInt32(ilan_arama.Text) + "%'");

                    Veritabanı.datagrid_doldur(dataGridView1, sql, "Ilanlar");
                }
                else if (ilan_cb.SelectedIndex == 1)
                {

                    sql = new SqlCommand("Select * from Ilanlar where ilan_adi LIKE '%" + ilan_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView1, sql, "Ilanlar");
                }
                else if (ilan_cb.SelectedIndex == 2)
                {
                    sql = new SqlCommand("Select * from Ilanlar where bursveren_id LIKE '%" + Convert.ToInt32(ilan_arama.Text) + "%'");

                    Veritabanı.datagrid_doldur(dataGridView1, sql, "Ilanlar");
                }
            }
            else
            {
                datagrid1doldur();
            }
        }
    }
}
