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
    public partial class Borç_Ekle : Form
    {
        public Borç_Ekle()
        {
            InitializeComponent();
        }
        private void Borç_Ekle_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }
        void ComboDoldur()
        {
            cmbBorçTipi.DataSource = Bağlantı.ConnectionClass.DataTable("SELECT Borç_Tipi_ID, Borç_Tipi_Ad, Borç_Tipi_Açıklama FROM [dbo].[Borç_Tipi]");
            cmbBorçTipi.DisplayMember = "Borç_Tipi_Açıklama";
            cmbBorçTipi.ValueMember = "Borç_Tipi_Ad";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnBorçKaydet_Click(object sender, EventArgs e)
        {
            if (radBorç.Checked != false)
            {
                string Tip = string.Empty;
                if (radBorç.Checked == true)
                {
                    Tip = "Borç";
                }
                if (Convert.ToInt32(txtBorçID.Text) == 0)
                {
                    Bağlantı.ConnectionClass.Command("" +
                        "    INSERT INTO [dbo].[Gelir-Gider-Borç_Ekle]          " +
                        "                ([ggb_Ekle_SahipAd]       " +
                        "                ,[ggb_Ekle_SahipSoyad]    " +
                        "                ,[ggb_Ekle_İşlemTipi]     " +
                        "                ,[ggb_Ekle_Tipi]          " +
                        "                ,[ggb_Ekle_Cari]          " +
                        "                ,[ggb_Ekle_Tutar]         " +
                        "                ,[ggb_Ekle_Açıklama])     " +
                        "    VALUES                                 " +
                        "                ('" + txtBorçSahibiAdı.Text + "' " +
                        "                ,'" + txtBorçSahipSoyadı.Text + "' " +
                        "                ,'" + Tip + "' " + 
                        "                ,'" + cmbBorçTipi.SelectedValue.ToString() + "' " +
                        "                ,'" + txtBorçCari.Text + "' " +
                        "                ,'" + Convert.ToDouble(txtBorçTutar.Text).ToString().Replace(",", ".") + "' " +
                        "                ,'" + txtBorçAçıklama.Text + "') ");
                    if (Bağlantı.ConnectionClass.sqlException == null)
                    {
                        MessageBox.Show("Borç kaydı başarıyla gerçekleşti.", "Bilgi");
                        Close();
                    }
                }
                else
                {
                    Bağlantı.ConnectionClass.Command("" +
                        "    UPDATE [dbo].[Gelir-Gider-Borç_Ekle] SET                                               " +
                        "           [ggb_Ekle_SahipAd] = '" + txtBorçSahibiAdı.Text + "'               " +
                        "          ,[ggb_Ekle_SahipSoyad] = '" + txtBorçSahipSoyadı.Text + "'          " +
                        "          ,[ggb_Ekle_İşlemTipi] = '" + Tip + "'                                  " + 
                        "          ,[ggb_Ekle_Tipi] = '" + cmbBorçTipi.SelectedValue.ToString() + "'   " +
                        "          ,[ggb_Ekle_Cari] = '" + txtBorçCari.Text + "'                       " +
                        "          ,[ggb_Ekle_Tutar] = '" + Convert.ToDouble(txtBorçTutar.Text).ToString().Replace(",", ".") + "'    " +
                        "          ,[ggb_Ekle_Açıklama] = '" + txtBorçAçıklama.Text + "'               " +
                        "    WHERE ggb_Ekle_ID = '" + Convert.ToInt32(txtBorçID.Text) + "'             ");
                    if (Bağlantı.ConnectionClass.sqlException == null)
                    {
                        MessageBox.Show("Borç kaydı başarıyla güncelleşti.", "Bilgi");
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
            if (MessageBox.Show("Bu borç kaydını silmek istediğinizden emin misiniz?", "Silmek istediğinizden emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bağlantı.ConnectionClass.Command("" +
                    "    DELETE [dbo].[Gelir-Gider-Borç_Ekle] WHERE ggb_Ekle_ID = '" + Convert.ToInt32(txtBorçID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Borç kaydı başarıyla silindi.", "Bilgi");
                    Close();
                }
            }
        }

        private void btnBorçTipiEkle_Click(object sender, EventArgs e)
        {
            Borç_Tipi_Ekle TipEkle = new Borç_Tipi_Ekle();
            TipEkle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tip_Kaydı_Sil TipSil = new Tip_Kaydı_Sil();
            TipSil.ShowDialog();
        }
    }
}
