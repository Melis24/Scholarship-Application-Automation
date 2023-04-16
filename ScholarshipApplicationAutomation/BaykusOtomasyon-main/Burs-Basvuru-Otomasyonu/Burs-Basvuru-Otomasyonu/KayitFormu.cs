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
    public partial class KayitFormu : Form
    {
        private const int kayitpaneli_X = 63;
        private const int kayitpaneli_Y = 197;

        public bool ogrenci_mi = false;
        public bool bursveren_mi = false;

        public KayitFormu()
        {
            InitializeComponent();
        }



        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KayitFormu_Load(object sender, EventArgs e)
        {
            ogrenci.Visible = false;
            ogrenci.Location = new Point(kayitpaneli_X, kayitpaneli_Y);
            ogrenci.Enabled = false;
            bursveren.Visible = false;
            bursveren.Location = new Point(kayitpaneli_X, kayitpaneli_Y);
            bursveren.Enabled = false;
            if (ogrenci_mi)
            {
                ogrenci.Visible = true;
                ogrenci.Enabled = true;
            }
            else if(bursveren_mi)
            {
                bursveren.Visible = true;
                bursveren.Enabled = true;
            }
        }

        private void buton_kayit_Click(object sender, EventArgs e)
        {
            bool kayitkontrol = false;

            if (ogrenci_mi)
            {

                if (ogrenci_sifre1.Text==ogrenci_sifre2.Text)
                {
                    if (ogrenci_eposta.Text.Contains("edu.tr"))
                    {
                        SqlCommand sql = new SqlCommand("insert into Ogrenciler(ogrenci_adi,ogrenci_soyadi,ogrenci_eposta,ogrenci_sifre,ogrenci_telefon,ogrenci_tc,ogrenci_cinsiyet,ogrenci_dogum_tarihi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)");
                        sql.Parameters.AddWithValue("@p1", ogrenci_ad.Text);
                        sql.Parameters.AddWithValue("@p2", ogrenci_soyad.Text);
                        sql.Parameters.AddWithValue("@p3", ogrenci_eposta.Text);
                        sql.Parameters.AddWithValue("@p4", Sifreleme.md5sifreleme(ogrenci_sifre1.Text));
                        sql.Parameters.AddWithValue("@p5", ogrenci_tel.Text);
                        sql.Parameters.AddWithValue("@p6", ogrenci_TC.Text);
                        sql.Parameters.AddWithValue("@p7", (rdb_erkek.Checked ? "Erkek" : "Kadın"));
                        sql.Parameters.AddWithValue("@p8", ogrenci_tarih.Value);
                        kayitkontrol = Giris_paneli.kayit_ol(sql);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen edu.tr uzantılı mail ile kayıt olunuz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler eşleşmiyor.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }else if (bursveren_mi)
            {
                if (bursveren_sifre1.Text == bursveren_sifre2.Text)
                {
                    SqlCommand sql = new SqlCommand("insert into Bursverenler(bursveren_vergino,bursveren_ad,bursveren_sifre) values(@p1,@p2,@p3)");
                    sql.Parameters.AddWithValue("@p1", bursveren_vergi.Text);
                    sql.Parameters.AddWithValue("@p2", bursveren_ad.Text);
                    sql.Parameters.AddWithValue("@p3",  Sifreleme.md5sifreleme(bursveren_sifre1.Text));

                    kayitkontrol = Giris_paneli.kayit_ol(sql);
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler eşleşmiyor.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (kayitkontrol)
            {
                MessageBox.Show("Kayıt Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GirisPaneli girisPaneli = new GirisPaneli();
                girisPaneli.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
