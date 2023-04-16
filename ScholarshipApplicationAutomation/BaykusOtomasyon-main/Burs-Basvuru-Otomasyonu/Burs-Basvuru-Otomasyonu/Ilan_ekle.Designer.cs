
namespace Burs_Basvuru_Otomasyonu
{
    partial class Ilan_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ilan_ekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ilan = new System.Windows.Forms.TextBox();
            this.txt_ozellik = new System.Windows.Forms.RichTextBox();
            this.buton_ekle = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlan Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlan Özellikleri:";
            // 
            // txt_ilan
            // 
            this.txt_ilan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ilan.Location = new System.Drawing.Point(173, 228);
            this.txt_ilan.Name = "txt_ilan";
            this.txt_ilan.Size = new System.Drawing.Size(143, 22);
            this.txt_ilan.TabIndex = 2;
            // 
            // txt_ozellik
            // 
            this.txt_ozellik.Location = new System.Drawing.Point(173, 288);
            this.txt_ozellik.Name = "txt_ozellik";
            this.txt_ozellik.Size = new System.Drawing.Size(143, 185);
            this.txt_ozellik.TabIndex = 3;
            this.txt_ozellik.Text = "";
            // 
            // buton_ekle
            // 
            this.buton_ekle.BackColor = System.Drawing.Color.Transparent;
            this.buton_ekle.Location = new System.Drawing.Point(125, 521);
            this.buton_ekle.Name = "buton_ekle";
            this.buton_ekle.Size = new System.Drawing.Size(170, 51);
            this.buton_ekle.TabIndex = 4;
            this.buton_ekle.Click += new System.EventHandler(this.buton_ekle_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(327, 58);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 21);
            this.exit.TabIndex = 5;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Ilan_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Burs_Basvuru_Otomasyonu.Properties.Resources.ilan_ekle_ap;
            this.ClientSize = new System.Drawing.Size(400, 650);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.buton_ekle);
            this.Controls.Add(this.txt_ozellik);
            this.Controls.Add(this.txt_ilan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ilan_ekle";
            this.Text = "Ilan_ekle";
            this.Load += new System.EventHandler(this.Ilan_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ilan;
        private System.Windows.Forms.RichTextBox txt_ozellik;
        private System.Windows.Forms.Panel buton_ekle;
        private System.Windows.Forms.Label exit;
    }
}