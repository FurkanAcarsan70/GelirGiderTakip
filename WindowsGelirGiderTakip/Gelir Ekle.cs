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
    public partial class Gelir_Ekle : Form
    {
        public Gelir_Ekle()
        {
            InitializeComponent();
        }
        private void Gelir_Ekle_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }
        void ComboDoldur()
        {
            cmbGelirTipi.DataSource = Bağlantı.ConnectionClass.DataTable("SELECT Gelir_Tipi_ID, Gelir_Tipi_Ad, Gelir_Tipi_Açıklama FROM [dbo].[Gelir_Tipi]");
            cmbGelirTipi.DisplayMember = "Gelir_Tipi_Açıklama";
            cmbGelirTipi.ValueMember = "Gelir_Tipi_Ad";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGelirKaydet_Click(object sender, EventArgs e)
        {
            string Tip = string.Empty;
            if (radGelir.Checked == true)
            {
                Tip = "Gelir";
            }
            if (Convert.ToInt32(txtGelirID.Text) == 0)
            {
                Bağlantı.ConnectionClass.Command("" +
                    "    INSERT INTO [dbo].[Gelir_Ekle] " +
                    "                ([Gelir_Ekle_SahipAd] " +
                    "                ,[Gelir_Ekle_SahipSoyad] " +
                    "                ,[Gelir_Ekle_Tipi] " +
                    "                ,[Gelir_Ekle_Cari] " +
                    "                ,[Gelir_Ekle_Tutar] " +
                    "                ,[Gelir_Ekle_Açıklama]) " +
                    "    VALUES " +
                    "                ('" + txtGelirSahibiAdı.Text + "' " +
                    "                ,'" + txtGelirSahipSoyadı.Text + "' " +
                    "                ,'" + cmbGelirTipi.SelectedValue.ToString() + "' " +
                    "                ,'" + txtGelirCari.Text + "' " +
                    "                ,'" + Convert.ToInt32(txtGelirTutar.Text) + "' " +
                    "                ,'" + txtGelirAçıklama.Text + "') ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Gelir kaydı başarıyla gerçekleşti.", "Bilgi");
                    Close();
                }
            }
            else
            {
                Bağlantı.ConnectionClass.Command("" +
                    "    UPDATE [dbo].[Gelir_Ekle] SET " +
                    "           [Gelir_Ekle_SahipAd] = '" + txtGelirSahibiAdı.Text + "' " +
                    "          ,[Gelir_Ekle_SahipSoyad] = '" + txtGelirSahipSoyadı.Text + "' " +
                    "          ,[Gelir_Ekle_Tipi] = '" + cmbGelirTipi.SelectedValue.ToString() + "' " +
                    "          ,[Gelir_Ekle_Cari] = '" + txtGelirCari.Text + "' " +
                    "          ,[Gelir_Ekle_Tutar] = '" + Convert.ToInt32(txtGelirTutar.Text) + "' " +
                    "          ,[Gelir_Ekle_Açıklama] = '" + txtGelirAçıklama.Text + "' " +
                    "    WHERE Gelir_Ekle_ID = '" + Convert.ToInt32(txtGelirID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Gelir kaydı başarıyla güncelleşti.", "Bilgi");
                    Close();
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu gelir kaydını silmek istediğinizden emin misiniz?", "Silmek istediğinizden emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bağlantı.ConnectionClass.Command("" +
                    "    DELETE [dbo].[Gelir_Ekle] WHERE Gelir_Ekle_ID = '" + Convert.ToInt32(txtGelirID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Gelir kaydı başarıyla silindi.", "Bilgi");
                    Close();
                }
            }
        }

        private void btnGelirTipiEkle_Click(object sender, EventArgs e)
        {
            Gelir_Tip_Ekle Tip = new Gelir_Tip_Ekle();
            Tip.ShowDialog();
        }

        private void btnTipSil_Click(object sender, EventArgs e)
        {
            Gelir_Tipi_Sil TipSil = new Gelir_Tipi_Sil();
            TipSil.ShowDialog();
        }
    }
}
