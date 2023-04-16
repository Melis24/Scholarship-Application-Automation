
namespace Burs_Basvuru_Otomasyonu
{
    partial class KayitFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitFormu));
            this.ogrenci = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.ogrenci_tarih = new System.Windows.Forms.DateTimePicker();
            this.ogrenci_tel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_erkek = new System.Windows.Forms.RadioButton();
            this.rdb_kadin = new System.Windows.Forms.RadioButton();
            this.ogrenci_sifre2 = new System.Windows.Forms.TextBox();
            this.ogrenci_sifre1 = new System.Windows.Forms.TextBox();
            this.ogrenci_eposta = new System.Windows.Forms.TextBox();
            this.ogrenci_soyad = new System.Windows.Forms.TextBox();
            this.ogrenci_ad = new System.Windows.Forms.TextBox();
            this.ogrenci_TC = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buton_kayit = new System.Windows.Forms.Panel();
            this.bursveren = new System.Windows.Forms.Panel();
            this.bursveren_sifre2 = new System.Windows.Forms.TextBox();
            this.bursveren_sifre1 = new System.Windows.Forms.TextBox();
            this.bursveren_ad = new System.Windows.Forms.TextBox();
            this.bursveren_vergi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.ogrenci.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.bursveren.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrenci
            // 
            this.ogrenci.BackColor = System.Drawing.Color.Transparent;
            this.ogrenci.Controls.Add(this.label10);
            this.ogrenci.Controls.Add(this.ogrenci_tarih);
            this.ogrenci.Controls.Add(this.ogrenci_tel);
            this.ogrenci.Controls.Add(this.groupBox1);
            this.ogrenci.Controls.Add(this.ogrenci_sifre2);
            this.ogrenci.Controls.Add(this.ogrenci_sifre1);
            this.ogrenci.Controls.Add(this.ogrenci_eposta);
            this.ogrenci.Controls.Add(this.ogrenci_soyad);
            this.ogrenci.Controls.Add(this.ogrenci_ad);
            this.ogrenci.Controls.Add(this.ogrenci_TC);
            this.ogrenci.Controls.Add(this.label9);
            this.ogrenci.Controls.Add(this.label8);
            this.ogrenci.Controls.Add(this.label7);
            this.ogrenci.Controls.Add(this.label6);
            this.ogrenci.Controls.Add(this.label5);
            this.ogrenci.Controls.Add(this.label4);
            this.ogrenci.Controls.Add(this.label3);
            this.ogrenci.Controls.Add(this.label2);
            this.ogrenci.Controls.Add(this.label1);
            this.ogrenci.Location = new System.Drawing.Point(784, 72);
            this.ogrenci.Name = "ogrenci";
            this.ogrenci.Size = new System.Drawing.Size(675, 391);
            this.ogrenci.TabIndex = 0;
            this.ogrenci.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(244, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Öğrenci Kayıt Formu";
            // 
            // ogrenci_tarih
            // 
            this.ogrenci_tarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ogrenci_tarih.Location = new System.Drawing.Point(452, 253);
            this.ogrenci_tarih.Name = "ogrenci_tarih";
            this.ogrenci_tarih.Size = new System.Drawing.Size(131, 22);
            this.ogrenci_tarih.TabIndex = 17;
            // 
            // ogrenci_tel
            // 
            this.ogrenci_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_tel.Location = new System.Drawing.Point(452, 213);
            this.ogrenci_tel.Mask = "(999) 000-0000";
            this.ogrenci_tel.Name = "ogrenci_tel";
            this.ogrenci_tel.Size = new System.Drawing.Size(127, 26);
            this.ogrenci_tel.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_erkek);
            this.groupBox1.Controls.Add(this.rdb_kadin);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(454, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 41);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rdb_erkek
            // 
            this.rdb_erkek.AutoSize = true;
            this.rdb_erkek.Location = new System.Drawing.Point(6, 18);
            this.rdb_erkek.Name = "rdb_erkek";
            this.rdb_erkek.Size = new System.Drawing.Size(53, 17);
            this.rdb_erkek.TabIndex = 13;
            this.rdb_erkek.TabStop = true;
            this.rdb_erkek.Text = "Erkek";
            this.rdb_erkek.UseVisualStyleBackColor = true;
            // 
            // rdb_kadin
            // 
            this.rdb_kadin.AutoSize = true;
            this.rdb_kadin.Location = new System.Drawing.Point(79, 18);
            this.rdb_kadin.Name = "rdb_kadin";
            this.rdb_kadin.Size = new System.Drawing.Size(52, 17);
            this.rdb_kadin.TabIndex = 14;
            this.rdb_kadin.TabStop = true;
            this.rdb_kadin.Text = "Kadın";
            this.rdb_kadin.UseVisualStyleBackColor = true;
            // 
            // ogrenci_sifre2
            // 
            this.ogrenci_sifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_sifre2.Location = new System.Drawing.Point(456, 126);
            this.ogrenci_sifre2.MaxLength = 30;
            this.ogrenci_sifre2.Name = "ogrenci_sifre2";
            this.ogrenci_sifre2.Size = new System.Drawing.Size(127, 24);
            this.ogrenci_sifre2.TabIndex = 12;
            this.ogrenci_sifre2.UseSystemPasswordChar = true;
            // 
            // ogrenci_sifre1
            // 
            this.ogrenci_sifre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_sifre1.Location = new System.Drawing.Point(456, 78);
            this.ogrenci_sifre1.MaxLength = 30;
            this.ogrenci_sifre1.Name = "ogrenci_sifre1";
            this.ogrenci_sifre1.Size = new System.Drawing.Size(127, 24);
            this.ogrenci_sifre1.TabIndex = 11;
            this.ogrenci_sifre1.UseSystemPasswordChar = true;
            // 
            // ogrenci_eposta
            // 
            this.ogrenci_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_eposta.Location = new System.Drawing.Point(160, 233);
            this.ogrenci_eposta.MaxLength = 100;
            this.ogrenci_eposta.Name = "ogrenci_eposta";
            this.ogrenci_eposta.Size = new System.Drawing.Size(127, 24);
            this.ogrenci_eposta.TabIndex = 10;
            // 
            // ogrenci_soyad
            // 
            this.ogrenci_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_soyad.Location = new System.Drawing.Point(160, 180);
            this.ogrenci_soyad.MaxLength = 50;
            this.ogrenci_soyad.Name = "ogrenci_soyad";
            this.ogrenci_soyad.Size = new System.Drawing.Size(127, 24);
            this.ogrenci_soyad.TabIndex = 9;
            // 
            // ogrenci_ad
            // 
            this.ogrenci_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_ad.Location = new System.Drawing.Point(160, 125);
            this.ogrenci_ad.MaxLength = 50;
            this.ogrenci_ad.Name = "ogrenci_ad";
            this.ogrenci_ad.Size = new System.Drawing.Size(127, 24);
            this.ogrenci_ad.TabIndex = 2;
            // 
            // ogrenci_TC
            // 
            this.ogrenci_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_TC.Location = new System.Drawing.Point(160, 81);
            this.ogrenci_TC.Mask = "00000000000";
            this.ogrenci_TC.Name = "ogrenci_TC";
            this.ogrenci_TC.Size = new System.Drawing.Size(127, 26);
            this.ogrenci_TC.TabIndex = 0;
            this.ogrenci_TC.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(328, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Doğum Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(375, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cinsiyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(109, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(375, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(338, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre (Tekrar):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(401, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-posta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // buton_kayit
            // 
            this.buton_kayit.BackColor = System.Drawing.Color.Transparent;
            this.buton_kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_kayit.Location = new System.Drawing.Point(323, 595);
            this.buton_kayit.Name = "buton_kayit";
            this.buton_kayit.Size = new System.Drawing.Size(154, 52);
            this.buton_kayit.TabIndex = 1;
            this.buton_kayit.Click += new System.EventHandler(this.buton_kayit_Click);
            // 
            // bursveren
            // 
            this.bursveren.BackColor = System.Drawing.Color.Transparent;
            this.bursveren.Controls.Add(this.bursveren_sifre2);
            this.bursveren.Controls.Add(this.bursveren_sifre1);
            this.bursveren.Controls.Add(this.bursveren_ad);
            this.bursveren.Controls.Add(this.bursveren_vergi);
            this.bursveren.Controls.Add(this.label14);
            this.bursveren.Controls.Add(this.label13);
            this.bursveren.Controls.Add(this.label12);
            this.bursveren.Controls.Add(this.label19);
            this.bursveren.Controls.Add(this.label11);
            this.bursveren.Location = new System.Drawing.Point(784, 482);
            this.bursveren.Name = "bursveren";
            this.bursveren.Size = new System.Drawing.Size(675, 391);
            this.bursveren.TabIndex = 19;
            this.bursveren.Visible = false;
            // 
            // bursveren_sifre2
            // 
            this.bursveren_sifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bursveren_sifre2.Location = new System.Drawing.Point(271, 300);
            this.bursveren_sifre2.Name = "bursveren_sifre2";
            this.bursveren_sifre2.Size = new System.Drawing.Size(143, 26);
            this.bursveren_sifre2.TabIndex = 8;
            this.bursveren_sifre2.UseSystemPasswordChar = true;
            // 
            // bursveren_sifre1
            // 
            this.bursveren_sifre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bursveren_sifre1.Location = new System.Drawing.Point(271, 244);
            this.bursveren_sifre1.Name = "bursveren_sifre1";
            this.bursveren_sifre1.Size = new System.Drawing.Size(143, 26);
            this.bursveren_sifre1.TabIndex = 7;
            this.bursveren_sifre1.UseSystemPasswordChar = true;
            // 
            // bursveren_ad
            // 
            this.bursveren_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bursveren_ad.Location = new System.Drawing.Point(271, 180);
            this.bursveren_ad.Name = "bursveren_ad";
            this.bursveren_ad.Size = new System.Drawing.Size(143, 26);
            this.bursveren_ad.TabIndex = 6;
            // 
            // bursveren_vergi
            // 
            this.bursveren_vergi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bursveren_vergi.Location = new System.Drawing.Point(271, 114);
            this.bursveren_vergi.Name = "bursveren_vergi";
            this.bursveren_vergi.Size = new System.Drawing.Size(143, 26);
            this.bursveren_vergi.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(153, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 21);
            this.label14.TabIndex = 4;
            this.label14.Text = "Şifre (Tekrar):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(216, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "Şifre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(230, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ad:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(184, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 21);
            this.label19.TabIndex = 1;
            this.label19.Text = "Vergi No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(216, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Burs Veren Kayıt Formu";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(719, 126);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 25);
            this.exit.TabIndex = 20;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // KayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.kayit_ap;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bursveren);
            this.Controls.Add(this.buton_kayit);
            this.Controls.Add(this.ogrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayitFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitFormu";
            this.Load += new System.EventHandler(this.KayitFormu_Load);
            this.ogrenci.ResumeLayout(false);
            this.ogrenci.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bursveren.ResumeLayout(false);
            this.bursveren.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ogrenci;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ogrenci_tarih;
        private System.Windows.Forms.MaskedTextBox ogrenci_tel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_erkek;
        private System.Windows.Forms.RadioButton rdb_kadin;
        private System.Windows.Forms.TextBox ogrenci_sifre2;
        private System.Windows.Forms.TextBox ogrenci_sifre1;
        private System.Windows.Forms.TextBox ogrenci_eposta;
        private System.Windows.Forms.TextBox ogrenci_soyad;
        private System.Windows.Forms.TextBox ogrenci_ad;
        private System.Windows.Forms.MaskedTextBox ogrenci_TC;
        private System.Windows.Forms.Panel buton_kayit;
        private System.Windows.Forms.Panel bursveren;
        private System.Windows.Forms.TextBox bursveren_sifre2;
        private System.Windows.Forms.TextBox bursveren_sifre1;
        private System.Windows.Forms.TextBox bursveren_ad;
        private System.Windows.Forms.TextBox bursveren_vergi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label exit;
    }
}