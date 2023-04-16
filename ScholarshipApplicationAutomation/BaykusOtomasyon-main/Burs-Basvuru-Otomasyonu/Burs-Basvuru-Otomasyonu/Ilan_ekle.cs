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
    public partial class Ilan_ekle : Form
    {
        public int ID;
        public Ilan_ekle()
        {
            InitializeComponent();
        }

        private void buton_ekle_Click(object sender, EventArgs e)
        {
            Burs_islemleri.Burs_ilani_ekle(txt_ilan.Text, txt_ozellik.Text, ID);
            Burs_veren_formu burs_Veren = new Burs_veren_formu();
            burs_Veren.Bursveren_ID = ID;
            burs_Veren.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Burs_veren_formu burs_Veren = new Burs_veren_formu();
            burs_Veren.Bursveren_ID = ID;
            burs_Veren.Show();
            this.Hide();
        }

        private void Ilan_ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
