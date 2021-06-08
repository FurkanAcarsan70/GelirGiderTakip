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
    public partial class Gider_Ekle : Form
    {
        public Gider_Ekle()
        {
            InitializeComponent();
        }
        private void Gider_Ekle_Load(object sender, EventArgs e)
        {
            Combo(); 
        }
        void Combo()
        {
            cmbGiderTipi.DataSource = Bağlantı.ConnectionClass.DataTable("SELECT Gider_Tipi_ID, Gider_Tpi_Ad, Gider_Tipi_Açıklama FROM [dbo].[Gider_Tipi]");
            cmbGiderTipi.DisplayMember = "Gider_Tpi_Açıklama";
            cmbGiderTipi.ValueMember = "Gider_Tpi_Ad";
        }
        private void btnGiderKaydet_Click(object sender, EventArgs e)
        {
            string Tip = string.Empty;
            if (radGider.Checked == true)
            {
                Tip = "Gider";
            }
            if (Convert.ToInt32(txtGiderID.Text) == 0)
            {
                Bağlantı.ConnectionClass.Command("" +
                    "       INSERT INTO [dbo].[Gider_Ekle] " +
                    "                   ([Gider_Ekle_SahipAd] " +
                    "                   ,[Gider_Ekle_SahipSoyad] " +
                    "                   ,[Gider_Ekle_Tipi] " +
                    "                   ,[Gider_Ekle_Cari] " +
                    "                   ,[Gider_Ekle_Tutar] " +
                    "                   ,[Gider_Ekle_Açıklama]) " +
                    "       VALUES " +
                    "                   ('" + txtGiderSahibiAdı.Text + "' " +
                    "                   ,'" + txtGiderSahipSoyadı.Text + "' " +
                    "                   ,'" + cmbGiderTipi.SelectedValue.ToString() + "' " +
                    "                   ,'" + txtGiderCari.Text + "' " +
                    "                   ,'" + Convert.ToInt32(txtGiderTutar.Text) + "' " +
                    "                   ,'" + txtGiderAçıklama.Text + "') ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Bu gider kaydı başarıyla gerçekleşti.", "Bilgi");
                    Close();
                }
            }
            else
            {
                Bağlantı.ConnectionClass.Command("" +
                    "       UPDATE [dbo].[Gider_Ekle] SET " +
                    "               [Gider_Ekle_SahipAd] = '" + txtGiderSahibiAdı.Text + "' " +
                    "              ,[Gider_Ekle_SahipSoyad] = '" + txtGiderSahipSoyadı.Text + "' " +
                    "              ,[Gider_Ekle_Tipi] = '" + cmbGiderTipi.SelectedValue.ToString() + "' " +
                    "              ,[Gider_Ekle_Cari] = '" + txtGiderCari.Text + "' " +
                    "              ,[Gider_Ekle_Tutar] = '" + Convert.ToInt32(txtGiderTutar.Text) + "' " +
                    "              ,[Gider_Ekle_Açıklama] = '" + txtGiderAçıklama.Text + "' " +
                    "       WHERE Gider_Ekle_ID = '" + Convert.ToInt32(txtGiderID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Bu gider kaydı başarıyla güncelleşti.", "Bilgi");
                    Close();
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu gider kaydını silmek istediğinizden emin misiniz?", "Silmek istediğinizden emin misiniz?", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bağlantı.ConnectionClass.Command("" +
                    "       DELETE [dbo].[Gider_Ekle]   WHERE Gider_Ekle_ID = '" + Convert.ToInt32(txtGiderID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Bu gider kaydı başarıyla silindi.", "Bilgi");
                    Close();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGiderTipiEkle_Click(object sender, EventArgs e)
        {
            Gider_Tip_Ekle TipEkle = new Gider_Tip_Ekle();
            TipEkle.ShowDialog();
        }

        private void btnTipSil_Click(object sender, EventArgs e)
        {
            Gider_Tipi_Sil TipSil = new Gider_Tipi_Sil();
            TipSil.ShowDialog();
        }
    }
}
