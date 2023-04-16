
namespace Burs_Basvuru_Otomasyonu
{
    partial class Burs_veren_formu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Burs_veren_formu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buton_ekle = new System.Windows.Forms.Panel();
            this.buton_sil = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ilan_tab = new System.Windows.Forms.TabPage();
            this.gelen_basvuru_tab = new System.Windows.Forms.TabPage();
            this.buton_reddet = new System.Windows.Forms.Panel();
            this.buton_onayla = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sifre = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.captcha = new System.Windows.Forms.TextBox();
            this.txt_yenitekrar = new System.Windows.Forms.TextBox();
            this.txt_yeni = new System.Windows.Forms.TextBox();
            this.txt_eski = new System.Windows.Forms.TextBox();
            this.basvuru_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.basvuru_arama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ilan_tab.SuspendLayout();
            this.gelen_basvuru_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.sifre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // buton_ekle
            // 
            this.buton_ekle.BackColor = System.Drawing.Color.Transparent;
            this.buton_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_ekle.Location = new System.Drawing.Point(544, 198);
            this.buton_ekle.Name = "buton_ekle";
            this.buton_ekle.Size = new System.Drawing.Size(138, 42);
            this.buton_ekle.TabIndex = 1;
            this.buton_ekle.Click += new System.EventHandler(this.buton_ekle_Click);
            // 
            // buton_sil
            // 
            this.buton_sil.BackColor = System.Drawing.Color.Transparent;
            this.buton_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_sil.Location = new System.Drawing.Point(544, 271);
            this.buton_sil.Name = "buton_sil";
            this.buton_sil.Size = new System.Drawing.Size(138, 42);
            this.buton_sil.TabIndex = 2;
            this.buton_sil.Click += new System.EventHandler(this.buton_sil_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(723, 29);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 25);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ilan_tab);
            this.tabControl1.Controls.Add(this.gelen_basvuru_tab);
            this.tabControl1.Controls.Add(this.sifre);
            this.tabControl1.Location = new System.Drawing.Point(42, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 566);
            this.tabControl1.TabIndex = 4;
            // 
            // ilan_tab
            // 
            this.ilan_tab.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.bv_tabpage1;
            this.ilan_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ilan_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ilan_tab.Controls.Add(this.dataGridView1);
            this.ilan_tab.Controls.Add(this.buton_sil);
            this.ilan_tab.Controls.Add(this.buton_ekle);
            this.ilan_tab.Location = new System.Drawing.Point(4, 22);
            this.ilan_tab.Name = "ilan_tab";
            this.ilan_tab.Padding = new System.Windows.Forms.Padding(3);
            this.ilan_tab.Size = new System.Drawing.Size(710, 540);
            this.ilan_tab.TabIndex = 1;
            this.ilan_tab.Text = "İlanlarım";
            this.ilan_tab.UseVisualStyleBackColor = true;
            // 
            // gelen_basvuru_tab
            // 
            this.gelen_basvuru_tab.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.bv_tabpage2;
            this.gelen_basvuru_tab.Controls.Add(this.basvuru_cb);
            this.gelen_basvuru_tab.Controls.Add(this.label5);
            this.gelen_basvuru_tab.Controls.Add(this.basvuru_arama);
            this.gelen_basvuru_tab.Controls.Add(this.buton_reddet);
            this.gelen_basvuru_tab.Controls.Add(this.buton_onayla);
            this.gelen_basvuru_tab.Controls.Add(this.dataGridView2);
            this.gelen_basvuru_tab.Location = new System.Drawing.Point(4, 22);
            this.gelen_basvuru_tab.Name = "gelen_basvuru_tab";
            this.gelen_basvuru_tab.Padding = new System.Windows.Forms.Padding(3);
            this.gelen_basvuru_tab.Size = new System.Drawing.Size(710, 540);
            this.gelen_basvuru_tab.TabIndex = 0;
            this.gelen_basvuru_tab.Text = "Gelen Başvurular";
            this.gelen_basvuru_tab.UseVisualStyleBackColor = true;
            // 
            // buton_reddet
            // 
            this.buton_reddet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buton_reddet.Location = new System.Drawing.Point(552, 290);
            this.buton_reddet.Name = "buton_reddet";
            this.buton_reddet.Size = new System.Drawing.Size(123, 39);
            this.buton_reddet.TabIndex = 2;
            this.buton_reddet.Click += new System.EventHandler(this.buton_reddet_Click);
            // 
            // buton_onayla
            // 
            this.buton_onayla.Location = new System.Drawing.Point(552, 209);
            this.buton_onayla.Name = "buton_onayla";
            this.buton_onayla.Size = new System.Drawing.Size(123, 39);
            this.buton_onayla.TabIndex = 1;
            this.buton_onayla.Click += new System.EventHandler(this.buton_onayla_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 116);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(494, 317);
            this.dataGridView2.TabIndex = 0;
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.sifre.Controls.Add(this.button1);
            this.sifre.Controls.Add(this.label4);
            this.sifre.Controls.Add(this.label3);
            this.sifre.Controls.Add(this.label2);
            this.sifre.Controls.Add(this.label1);
            this.sifre.Controls.Add(this.captcha);
            this.sifre.Controls.Add(this.txt_yenitekrar);
            this.sifre.Controls.Add(this.txt_yeni);
            this.sifre.Controls.Add(this.txt_eski);
            this.sifre.Location = new System.Drawing.Point(4, 22);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(710, 540);
            this.sifre.TabIndex = 2;
            this.sifre.Text = "Şifre Değiştir";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(315, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Şifre Sıfırla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(226, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "22 + 48";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(167, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre(Tekrar):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(226, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(226, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eski Şifre:";
            // 
            // captcha
            // 
            this.captcha.Location = new System.Drawing.Point(315, 288);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(133, 20);
            this.captcha.TabIndex = 3;
            // 
            // txt_yenitekrar
            // 
            this.txt_yenitekrar.Location = new System.Drawing.Point(315, 244);
            this.txt_yenitekrar.Name = "txt_yenitekrar";
            this.txt_yenitekrar.Size = new System.Drawing.Size(133, 20);
            this.txt_yenitekrar.TabIndex = 2;
            // 
            // txt_yeni
            // 
            this.txt_yeni.Location = new System.Drawing.Point(315, 203);
            this.txt_yeni.Name = "txt_yeni";
            this.txt_yeni.Size = new System.Drawing.Size(133, 20);
            this.txt_yeni.TabIndex = 1;
            // 
            // txt_eski
            // 
            this.txt_eski.Location = new System.Drawing.Point(315, 161);
            this.txt_eski.Name = "txt_eski";
            this.txt_eski.Size = new System.Drawing.Size(133, 20);
            this.txt_eski.TabIndex = 0;
            // 
            // basvuru_cb
            // 
            this.basvuru_cb.FormattingEnabled = true;
            this.basvuru_cb.Items.AddRange(new object[] {
            "ID",
            "Üniversite Adı",
            "Üniversite Bölüm"});
            this.basvuru_cb.Location = new System.Drawing.Point(498, 53);
            this.basvuru_cb.Name = "basvuru_cb";
            this.basvuru_cb.Size = new System.Drawing.Size(100, 21);
            this.basvuru_cb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(330, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aranacak Kelimeyi Giriniz:";
            // 
            // basvuru_arama
            // 
            this.basvuru_arama.Location = new System.Drawing.Point(498, 80);
            this.basvuru_arama.Name = "basvuru_arama";
            this.basvuru_arama.Size = new System.Drawing.Size(146, 20);
            this.basvuru_arama.TabIndex = 10;
            this.basvuru_arama.TextChanged += new System.EventHandler(this.basvuru_arama_TextChanged);
            // 
            // Burs_veren_formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Burs_veren_formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burs_veren_formu";
            this.Load += new System.EventHandler(this.Burs_veren_formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ilan_tab.ResumeLayout(false);
            this.gelen_basvuru_tab.ResumeLayout(false);
            this.gelen_basvuru_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.sifre.ResumeLayout(false);
            this.sifre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel buton_ekle;
        private System.Windows.Forms.Panel buton_sil;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ilan_tab;
        private System.Windows.Forms.TabPage gelen_basvuru_tab;
        private System.Windows.Forms.Panel buton_reddet;
        private System.Windows.Forms.Panel buton_onayla;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage sifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox captcha;
        private System.Windows.Forms.TextBox txt_yenitekrar;
        private System.Windows.Forms.TextBox txt_yeni;
        private System.Windows.Forms.TextBox txt_eski;
        private System.Windows.Forms.ComboBox basvuru_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox basvuru_arama;
    }
}