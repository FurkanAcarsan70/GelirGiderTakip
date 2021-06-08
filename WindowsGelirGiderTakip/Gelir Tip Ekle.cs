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
    public partial class Gelir_Tip_Ekle : Form
    {
        public Gelir_Tip_Ekle()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTipKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtTipID.Text) == 0)
            {
                Bağlantı.ConnectionClass.Command("" +
                    "    INSERT INTO [dbo].[Gelir_Tipi] " +
                    "           ([Gelir_Tipi_Ad]        " +
                    "           ,[Gelir_Tipi_Açıklama]) " +
                    "    VALUES                         " +
                    "           ('" + txtTipAd.Text + "' " +
                    "           ,'" + txtTipAçıklama.Text + "') ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Tip kaydı başarıyla gerçekleşmiştir.", "Bilgi");
                    Close();
                }
            }
            else
            {
                Bağlantı.ConnectionClass.Command("" +
                    "    UPDATE [dbo].[Gelir_Tipi] SET " +
                    "           [Gelir_Tipi_Ad] = '" + txtTipAd.Text + "' " +
                    "          ,[Gelir_Tipi_Açıklama] = '" + txtTipAçıklama.Text + "' " +
                    "   WHERE Gelir_Tipi_ID = '" + Convert.ToInt32(txtTipID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Tip kaydı güncellemesi başarıyla gerçekleşmiştir.", "Bilgi");
                    Close();
                }
            }
        }
    }
}
