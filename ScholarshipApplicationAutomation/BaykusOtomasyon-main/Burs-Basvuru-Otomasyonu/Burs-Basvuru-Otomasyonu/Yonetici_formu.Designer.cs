
namespace Burs_Basvuru_Otomasyonu
{
    partial class Yonetici_formu
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.ogrenci_id = new System.Windows.Forms.TextBox();
            this.ogrenci_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenci_arama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.bursveren_id = new System.Windows.Forms.TextBox();
            this.bursveren_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bursveren_arama = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.basvuru_id = new System.Windows.Forms.TextBox();
            this.basvuru_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.basvuru_arama = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ilan_id = new System.Windows.Forms.TextBox();
            this.ilan_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ilan_arama = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(776, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(42, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 556);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.tab_bg;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.ogrenci_id);
            this.tabPage1.Controls.Add(this.ogrenci_cb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ogrenci_arama);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci Listesi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Kaydı Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ogrenci_id
            // 
            this.ogrenci_id.Enabled = false;
            this.ogrenci_id.Location = new System.Drawing.Point(23, 463);
            this.ogrenci_id.Name = "ogrenci_id";
            this.ogrenci_id.Size = new System.Drawing.Size(100, 20);
            this.ogrenci_id.TabIndex = 15;
            // 
            // ogrenci_cb
            // 
            this.ogrenci_cb.FormattingEnabled = true;
            this.ogrenci_cb.Items.AddRange(new object[] {
            "ID",
            "Adı",
            "Soyadı",
            "E-Posta",
            "Telefon",
            "T.C Kimlik No"});
            this.ogrenci_cb.Location = new System.Drawing.Point(512, 13);
            this.ogrenci_cb.Name = "ogrenci_cb";
            this.ogrenci_cb.Size = new System.Drawing.Size(100, 21);
            this.ogrenci_cb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(344, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aranacak Kelimeyi Giriniz:";
            // 
            // ogrenci_arama
            // 
            this.ogrenci_arama.Location = new System.Drawing.Point(512, 40);
            this.ogrenci_arama.Name = "ogrenci_arama";
            this.ogrenci_arama.Size = new System.Drawing.Size(146, 20);
            this.ogrenci_arama.TabIndex = 1;
            this.ogrenci_arama.TextChanged += new System.EventHandler(this.ogrenci_arama_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.tab_bg;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.bursveren_id);
            this.tabPage2.Controls.Add(this.bursveren_cb);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.bursveren_arama);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Burs Veren Listesi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Kaydı Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bursveren_id
            // 
            this.bursveren_id.Enabled = false;
            this.bursveren_id.Location = new System.Drawing.Point(26, 473);
            this.bursveren_id.Name = "bursveren_id";
            this.bursveren_id.Size = new System.Drawing.Size(100, 20);
            this.bursveren_id.TabIndex = 17;
            // 
            // bursveren_cb
            // 
            this.bursveren_cb.FormattingEnabled = true;
            this.bursveren_cb.Items.AddRange(new object[] {
            "ID",
            "Vergi No",
            "Ad"});
            this.bursveren_cb.Location = new System.Drawing.Point(529, 15);
            this.bursveren_cb.Name = "bursveren_cb";
            this.bursveren_cb.Size = new System.Drawing.Size(100, 21);
            this.bursveren_cb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(361, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aranacak Kelimeyi Giriniz:";
            // 
            // bursveren_arama
            // 
            this.bursveren_arama.Location = new System.Drawing.Point(529, 42);
            this.bursveren_arama.Name = "bursveren_arama";
            this.bursveren_arama.Size = new System.Drawing.Size(146, 20);
            this.bursveren_arama.TabIndex = 4;
            this.bursveren_arama.TextChanged += new System.EventHandler(this.bursveren_arama_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(632, 382);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.tab_bg;
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.basvuru_id);
            this.tabPage3.Controls.Add(this.basvuru_cb);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.basvuru_arama);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(712, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Başvurular Listesi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Kaydı Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // basvuru_id
            // 
            this.basvuru_id.Enabled = false;
            this.basvuru_id.Location = new System.Drawing.Point(15, 480);
            this.basvuru_id.Name = "basvuru_id";
            this.basvuru_id.Size = new System.Drawing.Size(100, 20);
            this.basvuru_id.TabIndex = 19;
            // 
            // basvuru_cb
            // 
            this.basvuru_cb.FormattingEnabled = true;
            this.basvuru_cb.Items.AddRange(new object[] {
            "ID",
            "Üniversite Adı",
            "Üniversite Bölüm"});
            this.basvuru_cb.Location = new System.Drawing.Point(534, 8);
            this.basvuru_cb.Name = "basvuru_cb";
            this.basvuru_cb.Size = new System.Drawing.Size(100, 21);
            this.basvuru_cb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(366, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aranacak Kelimeyi Giriniz:";
            // 
            // basvuru_arama
            // 
            this.basvuru_arama.Location = new System.Drawing.Point(534, 35);
            this.basvuru_arama.Name = "basvuru_arama";
            this.basvuru_arama.Size = new System.Drawing.Size(146, 20);
            this.basvuru_arama.TabIndex = 7;
            this.basvuru_arama.TextChanged += new System.EventHandler(this.basvuru_arama_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 62);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(617, 401);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.tab_bg;
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.ilan_id);
            this.tabPage4.Controls.Add(this.ilan_cb);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.ilan_arama);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(712, 530);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "İlanlar Listesi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ilan Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ilan_id
            // 
            this.ilan_id.Enabled = false;
            this.ilan_id.Location = new System.Drawing.Point(33, 478);
            this.ilan_id.Name = "ilan_id";
            this.ilan_id.Size = new System.Drawing.Size(100, 20);
            this.ilan_id.TabIndex = 13;
            // 
            // ilan_cb
            // 
            this.ilan_cb.FormattingEnabled = true;
            this.ilan_cb.Items.AddRange(new object[] {
            "İlan ID",
            "İlan Adı",
            "Burs Veren ID"});
            this.ilan_cb.Location = new System.Drawing.Point(505, 40);
            this.ilan_cb.Name = "ilan_cb";
            this.ilan_cb.Size = new System.Drawing.Size(100, 21);
            this.ilan_cb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(337, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aranacak Kelimeyi Giriniz:";
            // 
            // ilan_arama
            // 
            this.ilan_arama.Location = new System.Drawing.Point(505, 67);
            this.ilan_arama.Name = "ilan_arama";
            this.ilan_arama.Size = new System.Drawing.Size(146, 20);
            this.ilan_arama.TabIndex = 10;
            this.ilan_arama.TextChanged += new System.EventHandler(this.ilan_arama_TextChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(33, 107);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(598, 350);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellDoubleClick);
            // 
            // Yonetici_formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.yonetici_bg;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Yonetici_formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yonetici_formu";
            this.Load += new System.EventHandler(this.Yonetici_formu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogrenci_arama;
        private System.Windows.Forms.ComboBox ogrenci_cb;
        private System.Windows.Forms.ComboBox bursveren_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bursveren_arama;
        private System.Windows.Forms.ComboBox basvuru_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox basvuru_arama;
        private System.Windows.Forms.ComboBox ilan_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ilan_arama;
        private System.Windows.Forms.TextBox ilan_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ogrenci_id;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox bursveren_id;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox basvuru_id;
    }
}