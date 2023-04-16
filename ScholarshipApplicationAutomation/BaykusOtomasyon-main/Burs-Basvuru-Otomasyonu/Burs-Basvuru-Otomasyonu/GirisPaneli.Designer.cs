
namespace Burs_Basvuru_Otomasyonu
{
    partial class GirisPaneli
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisPaneli));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.ipucu = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.buton_giris = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bilgi_uye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kullanıcı Tipi Seçiniz",
            "Öğrenci",
            "Burs Veren",
            "Yönetici"});
            this.comboBox1.Location = new System.Drawing.Point(492, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanici.Location = new System.Drawing.Point(501, 217);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(186, 17);
            this.txt_kullanici.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(501, 291);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(186, 17);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // ipucu
            // 
            this.ipucu.AutoSize = true;
            this.ipucu.BackColor = System.Drawing.Color.Transparent;
            this.ipucu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipucu.Location = new System.Drawing.Point(498, 256);
            this.ipucu.Name = "ipucu";
            this.ipucu.Size = new System.Drawing.Size(35, 13);
            this.ipucu.TabIndex = 3;
            this.ipucu.Text = "label1";
            this.ipucu.Visible = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(701, 37);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 24);
            this.exit.TabIndex = 4;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // buton_giris
            // 
            this.buton_giris.BackColor = System.Drawing.Color.Transparent;
            this.buton_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_giris.Location = new System.Drawing.Point(513, 363);
            this.buton_giris.Name = "buton_giris";
            this.buton_giris.Size = new System.Drawing.Size(152, 45);
            this.buton_giris.TabIndex = 5;
            this.buton_giris.Click += new System.EventHandler(this.buton_giris_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(585, 422);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "tıklayınız.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bilgi_uye
            // 
            this.bilgi_uye.AutoSize = true;
            this.bilgi_uye.BackColor = System.Drawing.Color.Transparent;
            this.bilgi_uye.Location = new System.Drawing.Point(510, 422);
            this.bilgi_uye.Name = "bilgi_uye";
            this.bilgi_uye.Size = new System.Drawing.Size(76, 13);
            this.bilgi_uye.TabIndex = 7;
            this.bilgi_uye.Text = "Üye olmak için";
            // 
            // GirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.giris_ap;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.bilgi_uye);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buton_giris);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ipucu);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form1";
            this.Load += new System.EventHandler(this.GirisPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label ipucu;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel buton_giris;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label bilgi_uye;
    }
}

