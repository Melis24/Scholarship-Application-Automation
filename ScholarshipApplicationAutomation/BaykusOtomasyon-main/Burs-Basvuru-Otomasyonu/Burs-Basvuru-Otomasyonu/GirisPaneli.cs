using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burs_Basvuru_Otomasyonu
{
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
            
        }

        private void OgrenciGiris()
        {

            string sqlsorgu = "select * from Ogrenciler where ogrenci_eposta=@p1 and ogrenci_sifre=@p2";
            if (Giris_paneli.giris(sqlsorgu, txt_kullanici.Text, txt_sifre.Text,"ogrenci_id"))
            {

                MessageBox.Show("Öğrenci girişi başarılı");
                Ogrenci_formu ogrenci = new Ogrenci_formu();
                ogrenci.Ogrenci_ID = Giris_paneli.kullaniciID;
                ogrenci.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("E posta veya şifre hatalı..!!");
                txt_kullanici.Clear();
                txt_sifre.Clear();
            }

        }


        private void BursVerenGiris()
        {
            string sqlsorgu = "select * from Bursverenler where bursveren_vergino=@p1 and bursveren_sifre=@p2";
            if (Giris_paneli.giris(sqlsorgu, txt_kullanici.Text, txt_sifre.Text,"bursveren_id"))
            {

                MessageBox.Show("Burs veren girişi başarılı.");
                Burs_veren_formu bursveren = new Burs_veren_formu();
                bursveren.Bursveren_ID = Giris_paneli.kullaniciID;
                bursveren.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı..!!");
                txt_kullanici.Clear();
                txt_sifre.Clear();

            }


        }

        private void YoneticiGiris()
        {
            string sqlsorgu = "select * from Yonetici where yonetici_kadi=@p1 and yonetici_sifre=@p2";
            if (Giris_paneli.giris(sqlsorgu, txt_kullanici.Text, txt_sifre.Text,"yonetici_id"))
            {

                MessageBox.Show("Yönetici girişi başarılı.");
                Yonetici_formu yonetici = new Yonetici_formu();
                yonetici.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı..!!");
                txt_kullanici.Clear();
                txt_sifre.Clear();

            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                ipucu.Enabled = true;
                ipucu.Visible = true;
                ipucu.Text = "Lütfen edu.tr uzantılı mail adresinizi girin.";
            }
            else
            {
                ipucu.Enabled = false;
                ipucu.Visible = false;
            }
        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            ipucu.Enabled = false;
            ipucu.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buton_giris_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                OgrenciGiris();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                BursVerenGiris();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                YoneticiGiris();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Kayıt olmak istediğiniz üye tipini seçiniz!.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                MessageBox.Show("Yönetici kaydı yapamazsınız.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(comboBox1.SelectedIndex == 1) 
            {
                KayitFormu kayitFormu = new KayitFormu();
                kayitFormu.ogrenci_mi = true;
                kayitFormu.Show();
                this.Hide();
            }else if(comboBox1.SelectedIndex == 2)
            {
                KayitFormu kayitFormu = new KayitFormu();
                kayitFormu.bursveren_mi = true;
                kayitFormu.Show();
                this.Hide();
            }

        }

    }
}