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
            if (radGider.Checked != false)
            {
                string Tip = string.Empty;
                if (radGider.Checked == true)
                {
                    Tip = "Gider";
                }
                if (Convert.ToInt32(txtGiderID.Text) == 0)
                {
                    Bağlantı.ConnectionClass.Command("" +
                        "       INSERT INTO [dbo].[Gelir-Gider-Borç_Ekle] " +
                        "                   ([ggb_Ekle_SahipAd] " +
                        "                   ,[ggb_Ekle_SahipSoyad] " +
                        "                   ,[ggb_Ekle_İşlemTipi] " +
                        "                   ,[ggb_Ekle_Tipi] " +
                        "                   ,[ggb_Ekle_Cari] " +
                        "                   ,[ggb_Ekle_Tutar] " +
                        "                   ,[ggb_Ekle_Açıklama]) " +
                        "       VALUES " +
                        "                   ('" + txtGiderSahibiAdı.Text + "' " +
                        "                   ,'" + txtGiderSahipSoyadı.Text + "' " +
                        "                   ,'" + Tip + "' " + 
                        "                   ,'" + cmbGiderTipi.SelectedValue.ToString() + "' " +
                        "                   ,'" + txtGiderCari.Text + "' " +
                        "                   ,'" + Convert.ToDouble(txtGiderTutar.Text).ToString().Replace(",", ".") + "' " +
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
                        "       UPDATE [dbo].[Gelir-Gider-Borç_Ekle] SET " +
                        "               [ggb_Ekle_SahipAd] = '" + txtGiderSahibiAdı.Text + "' " +
                        "              ,[ggb_Ekle_SahipSoyad] = '" + txtGiderSahipSoyadı.Text + "' " +
                        "              ,[ggb_Ekle_İşlemTipi] = '" + Tip + "' " +  
                        "              ,[ggb_Ekle_Tipi] = '" + cmbGiderTipi.SelectedValue.ToString() + "' " +
                        "              ,[ggb_Ekle_Cari] = '" + txtGiderCari.Text + "' " +
                        "              ,[ggb_Ekle_Tutar] = '" + Convert.ToDouble(txtGiderTutar.Text).ToString().Replace(",", ".") + "' " +
                        "              ,[ggb_Ekle_Açıklama] = '" + txtGiderAçıklama.Text + "' " +
                        "       WHERE ggb_Ekle_ID = '" + Convert.ToInt32(txtGiderID.Text) + "' ");
                    if (Bağlantı.ConnectionClass.sqlException == null)
                    {
                        MessageBox.Show("Bu gider kaydı başarıyla güncelleşti.", "Bilgi");
                        Close();
                    }
                } 
            }
            else
            {
                MessageBox.Show("İşlem tipini seçmeden işlem yapamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu gider kaydını silmek istediğinizden emin misiniz?", "Silmek istediğinizden emin misiniz?", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bağlantı.ConnectionClass.Command("" +
                    "       DELETE [dbo].[Gelir-Gider-Borç_Ekle]   WHERE ggb_Ekle_ID = '" + Convert.ToInt32(txtGiderID.Text) + "' ");
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
