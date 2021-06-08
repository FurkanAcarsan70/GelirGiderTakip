using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGelirGiderTakip
{
    public partial class Gelir_Gider : Form
    {
        
        public Gelir_Gider()
        {
            InitializeComponent();
        }
        private void Gelir_Gider_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_Tümünü_Göster_Click(object sender, EventArgs e)
        {

        }

        private void btn_Borç_Ekle_Click(object sender, EventArgs e)
        {
            Borç_Ekle Borç = new Borç_Ekle();
            Borç.ShowDialog();
        }

        private void btn_Gider_Ekle_Click(object sender, EventArgs e)
        {
            Gider_Ekle Gider = new Gider_Ekle();
            Gider.ShowDialog();
        }

        private void btn_Gelir_Ekle_Click(object sender, EventArgs e)
        {
            Gelir_Ekle Gelir = new Gelir_Ekle();
            Gelir.ShowDialog();
        }
    }
}
