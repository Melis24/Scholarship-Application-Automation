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
    public partial class Yonetici_formu : Form
    {
        public Yonetici_formu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        string[] ogrenci_tablo_isimleri = { "ID", "Ad", "Soyad", " E posta", "Şifre", "Telefon", "TC", "Cinsiyet", "Doğum Tarihi" };
        string[] bursveren_tablo_isimleri = { "ID", "Vergi NO", "Ad", "Şifre" };
        string[] basvurular_tablo_isimleri = { "ID", "Üniversite Ad", "Üniversite Bölüm", "Sınıf", "Başarı Ortalaması", "Kardeş Sayısı", "Aile Geliri", "Anne hayatta mı", "Baba hayatta mı ", "Öğrenci ID", "İlan ID", "Burs Veren ID", "Onay" };
        string[] ilanlar_tablo_isimleri = { "ID", "Ad", "İstenen Özellikler", "Burs Veren ID" };


        public void silme_islemi(string sqlstr)
        {
            SqlConnection conn = new SqlConnection(Veritabanı.getSqlCon());

            SqlCommand sql = new SqlCommand(sqlstr, conn);

            conn.Open();
            sql.ExecuteNonQuery();
            conn.Close();
        }

        public  void datagrid1_doldur()
        {


            SqlCommand select = new SqlCommand("select * from Ogrenciler");
            Veritabanı.datagrid_doldur(dataGridView1, select, "Ogrenciler");

            for(int i=0;i<ogrenci_tablo_isimleri.Length;i++)
            {
                dataGridView1.Columns[i].HeaderText = ogrenci_tablo_isimleri[i];
            }
        }


        public void datagrid2_doldur()
        {


            SqlCommand select = new SqlCommand("select * from Bursverenler");
            Veritabanı.datagrid_doldur(dataGridView2, select, "Bursverenler");
            for (int i = 0; i < bursveren_tablo_isimleri.Length; i++)
            {
                dataGridView2.Columns[i].HeaderText = bursveren_tablo_isimleri[i];
            }
        }

        public void datagrid3_doldur()
        {


            SqlCommand select = new SqlCommand("select * from Basvurular");
            Veritabanı.datagrid_doldur(dataGridView3, select, "Basvurular");
            for (int i = 0; i < basvurular_tablo_isimleri.Length; i++)
            {
                dataGridView3.Columns[i].HeaderText = basvurular_tablo_isimleri[i];
            }

        }
        public void datagrid4_doldur()
        {


            SqlCommand select = new SqlCommand("select * from Ilanlar");
            Veritabanı.datagrid_doldur(dataGridView4, select, "Ilanlar");
            for (int i = 0; i < ilanlar_tablo_isimleri.Length; i++)
            {
                dataGridView4.Columns[i].HeaderText = ilanlar_tablo_isimleri[i];
            }

        }

        private void Yonetici_formu_Load(object sender, EventArgs e)

        {
            datagrid1_doldur();
            datagrid2_doldur();
            datagrid3_doldur();
            datagrid4_doldur();

        }

        private void ogrenci_arama_TextChanged(object sender, EventArgs e)
        {
            if(ogrenci_arama.Text.Length > 0)
            {
                SqlCommand sql = new SqlCommand("Select * from Ogrenciler where ogrenci_adi LIKE '%" + ogrenci_arama.Text + "%'");
                
                if (ogrenci_cb.SelectedIndex == 0)
                {
                    sql = new SqlCommand("Select * from Ogrenciler where ogrenci_id LIKE '%" + Convert.ToInt32(ogrenci_arama.Text) + "%'");

                    Veritabanı.datagrid_doldur(dataGridView1,sql,"Ogrenciler");
                }else if(ogrenci_cb.SelectedIndex == 1)
                {

                    sql = new SqlCommand("Select * from Ogrenciler where ogrenci_adi LIKE '%" + ogrenci_arama.Text + "%'");
                    Veritabanı.datagrid_doldur(dataGridView1, sql, "Ogrenciler");
                }else if(ogrenci_cb.SelectedIndex == 2)
                {
                    sql = new SqlCommand("Select * from Ogrenciler where ogrenci_soyadi LIKE '%" + ogrenci_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView1, sql, "Ogrenciler");
                }else if(ogrenci_cb.SelectedIndex == 3)
                {
                    sql = new SqlCommand("Select * from Ogrenciler where ogrenci_eposta LIKE '%" + ogrenci_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView1, sql, "Ogrenciler");
                }else if(ogrenci_cb.SelectedIndex == 4)
                {
                    sql = new SqlCommand("Select * from Ogrenciler where ogrenci_telefon LIKE '%" + ogrenci_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView1, sql, "Ogrenciler");
                }else if(ogrenci_cb.SelectedIndex == 5)
                {
                    sql = new SqlCommand("Select * from Ogrenciler where ogrenci_tc LIKE '%" + ogrenci_arama.Text + "%'"); ;
                    
                    Veritabanı.datagrid_doldur(dataGridView1, sql, "Ogrenciler");
                }
            }
            else
            {
                datagrid1_doldur();
            }
        }

        private void bursveren_arama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sql;
            if (bursveren_arama.Text.Length > 0)
            {
                if (bursveren_cb.SelectedIndex == 0)
                {
                    sql = new SqlCommand("Select * from Bursverenler where bursveren_id LIKE '%" + Convert.ToInt32(bursveren_arama.Text) + "%'");

                    Veritabanı.datagrid_doldur(dataGridView2, sql, "Bursverenler");
                }
                else if (bursveren_cb.SelectedIndex == 1)
                {


                    sql = new SqlCommand("Select * from Bursverenler where bursveren_vergino LIKE '%" + bursveren_arama.Text + "%'");
                    Veritabanı.datagrid_doldur(dataGridView2, sql, "Bursverenler");
                }
                else if (bursveren_cb.SelectedIndex == 2)
                {
                    sql = new SqlCommand("Select * from Bursverenler where bursveren_ad LIKE '%" + bursveren_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView2, sql, "Bursverenler");
                }
            }
            else
            {
                datagrid2_doldur();
            }
        }

        private void basvuru_arama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sql;
            if (basvuru_arama.Text.Length > 0)
            {
                if (basvuru_cb.SelectedIndex == 0)
                {
                    sql = new SqlCommand("Select * from Basvurular where basvuru_id LIKE '%" + Convert.ToInt32(basvuru_arama.Text) + "%'");

                    Veritabanı.datagrid_doldur(dataGridView3, sql, "Basvurular");
                }
                else if (basvuru_cb.SelectedIndex == 1)
                {

                    sql = new SqlCommand("Select * from Basvurular where okudugu_universite_adi LIKE '%" + basvuru_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView3, sql, "Basvurular");
                }
                else if (basvuru_cb.SelectedIndex == 2)
                {
                    sql = new SqlCommand("Select * from Basvurular where okudugu_universite_bolum LIKE '%" + basvuru_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView3, sql, "Basvurular");
                }
            }
            else
            {
                datagrid3_doldur();
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

                    Veritabanı.datagrid_doldur(dataGridView4, sql, "Ilanlar");
                }
                else if (ilan_cb.SelectedIndex == 1)
                {

                    sql = new SqlCommand("Select * from Ilanlar where ilan_adi LIKE '%" + ilan_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView4, sql, "Ilanlar");
                }
                else if (ilan_cb.SelectedIndex == 2)
                {
                    sql = new SqlCommand("Select * from Ilanlar where bursveren_id LIKE '%" + Convert.ToInt32(ilan_arama.Text) + "%'");

                    Veritabanı.datagrid_doldur(dataGridView4, sql, "Ilanlar");
                }
            }
            else
            {
                datagrid4_doldur();
            }
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ilan_id.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İlanı silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string sql = "delete from Ilanlar where ilan_id = '" + ilan_id.Text + "'";
                silme_islemi(sql);
                datagrid4_doldur();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ogrenci_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = "delete from Ogrenciler where ogrenci_id = '" + ogrenci_id.Text + "'";
                silme_islemi(sql);
                datagrid1_doldur();
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bursveren_id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = "delete from Bursverenler where bursveren_id = '" + bursveren_id.Text + "'";
                silme_islemi(sql);
                datagrid2_doldur();
            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            basvuru_id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = "delete from Basvurular where basvuru_id = '" + basvuru_id.Text + "'";
                silme_islemi(sql);
                datagrid3_doldur();
            }
        }


    }
}
