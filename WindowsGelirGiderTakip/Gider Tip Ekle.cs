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
    public partial class Gider_Tip_Ekle : Form
    {
        public Gider_Tip_Ekle()
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
                    "    INSERT INTO [dbo].[Gider_Tipi] " +
                    "           ([Gider_Tpi_Ad]        " +
                    "           ,[Gider_Tipi_Açıklama]) " +
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
                    "    UPDATE [dbo].[Gider_Tipi] SET " +
                    "            [Gider_Tpi_Ad] = '" + txtTipAd.Text + "' " +
                    "           ,[Gider_Tipi_Açıklama] = '" + txtTipAçıklama.Text + "' " +
                    "    WHERE Gider_Tipi_ID = '" + Convert.ToInt32(txtTipID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Tip kaydı güncellemesi başarıyla gerçekleşmiştir.", "Bilgi");
                    Close();
                }
            }
        }
    }
}
