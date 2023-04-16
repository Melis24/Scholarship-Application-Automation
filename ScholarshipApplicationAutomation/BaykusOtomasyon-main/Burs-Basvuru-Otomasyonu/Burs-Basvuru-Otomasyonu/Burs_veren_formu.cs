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
    
    public partial class Burs_veren_formu : Form
    {
        public int Bursveren_ID;
        string[] datagrid1_isimler = { "İlan ID", "İlan Adı", "İstenen Özellikler" };
        public Burs_veren_formu()
        {
            InitializeComponent();
        }
        int sonuc;
        private void captcha_olustur()
        {
            label4.Visible = true;
            Random sayi = new Random();

            int ilk_sayi = sayi.Next(0, 90);
            int ikinci_sayi = sayi.Next(0, 10);

            sonuc = ilk_sayi + ikinci_sayi;

            label4.Text = ilk_sayi.ToString() + "+" + ikinci_sayi.ToString() + "=";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Burs_veren_formu_Load(object sender, EventArgs e)
        {
            datagrid1doldur();
            datagrid2doldur();
            datagrid_isimdegistir();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[2].Width = 255;
            captcha_olustur();
           

        }

        private void datagrid1doldur()
        {
            SqlCommand select = new SqlCommand("select * from Ilanlar where bursveren_id = @p1");
            select.Parameters.AddWithValue("@p1", Bursveren_ID);
            Veritabanı.datagrid_doldur(dataGridView1, select, "Ilanlar");
        }

        private void datagrid2doldur()
        {
            SqlCommand select = new SqlCommand("select * from Basvurular where B_bursveren_id = @p1");
            select.Parameters.AddWithValue("@p1", Bursveren_ID);
            Veritabanı.datagrid_doldur(dataGridView2, select, "Basvurular");
        }

        private void datagrid_isimdegistir()
        {

            for (int i = 0;i < datagrid1_isimler.Length;i++)
            {

                dataGridView1.Columns[i].HeaderText = datagrid1_isimler[i];
            }


        }

        private void buton_ekle_Click(object sender, EventArgs e)
        {
            Ilan_ekle ilan = new Ilan_ekle();
            ilan.ID = Bursveren_ID;
            ilan.Show();
            this.Hide();
            datagrid1doldur();
            
        }

        private void buton_sil_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("İlanı silmek istediğinize emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                int ilan_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Burs_islemleri.Burs_ilani_sil(ilan_id);
                datagrid1doldur();

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_yenitekrar.Text == txt_yeni.Text)
            {
                if(Convert.ToInt32(captcha.Text) == sonuc)
                {
                    bool kontrol = Sifre_islemleri.sifre_yenile(txt_eski.Text,txt_yeni.Text, Bursveren_ID, "Bursverenler", "bursveren");
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

        private void buton_onayla_Click(object sender, EventArgs e)
        {
            SqlCommand onay = new SqlCommand("update Basvurular set basvuru_onay = @p1 where basvuru_id = @p2");
            onay.Parameters.AddWithValue("p1", "Onaylandı");
            onay.Parameters.AddWithValue("p2", Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));

            Burs_islemleri.Basvuru_durumunu_guncelle(onay);

            datagrid2doldur();

        }

        private void buton_reddet_Click(object sender, EventArgs e)
        {
            SqlCommand onay = new SqlCommand("update Basvurular set basvuru_onay = @p1 where basvuru_id = @p2");
            onay.Parameters.AddWithValue("p1", "Reddedildi");
            onay.Parameters.AddWithValue("p2", Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));

            Burs_islemleri.Basvuru_durumunu_guncelle(onay);

            datagrid2doldur();
        }

        private void basvuru_arama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sql;
            if (basvuru_arama.Text.Length > 0)
            {
                if (basvuru_cb.SelectedIndex == 0)
                {
                    sql = new SqlCommand("Select * from Basvurular where basvuru_id LIKE '%" + Convert.ToInt32(basvuru_arama.Text) + "%'");

                    Veritabanı.datagrid_doldur(dataGridView2, sql, "Basvurular");
                }
                else if (basvuru_cb.SelectedIndex == 1)
                {

                    sql = new SqlCommand("Select * from Basvurular where okudugu_universite_adi LIKE '%" + basvuru_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView2, sql, "Basvurular");
                }
                else if (basvuru_cb.SelectedIndex == 2)
                {
                    sql = new SqlCommand("Select * from Basvurular where okudugu_universite_bolum LIKE '%" + basvuru_arama.Text + "%'");

                    Veritabanı.datagrid_doldur(dataGridView2, sql, "Basvurular");
                }
            }
            else
            {
                datagrid2doldur();
            }
        }
    }
}
