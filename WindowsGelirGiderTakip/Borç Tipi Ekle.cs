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
    public partial class Borç_Tipi_Ekle : Form
    {
        public Borç_Tipi_Ekle()
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
                    "    INSERT INTO [dbo].[Borç_Tipi]      " +
                    "                ([Borç_Tipi_Ad]        " +
                    "                ,[Borç_Tipi_Açıklama]) " +
                    "    VALUES                             " +
                    "                ('" + txtTipAd.Text + "' " +
                    "                 ,'" + txtTipAçıklama.Text + "') ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Tip kaydı başarıyla gerçekleşmiştir.", "Bilgi");
                    Close();
                }
            }
            else
            {
                Bağlantı.ConnectionClass.Command("" +
                    "    UPDATE [dbo].[Borç_Tipi] SET " +
                    "            [Borç_Tipi_Ad] = '" + txtTipAd.Text + "' " +
                    "           ,[Borç_Tipi_Açıklama] = '" + txtTipAçıklama.Text + "' " +
                    "    WHERE Borç_Tipi_ID = '" + Convert.ToInt32(txtTipID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Tip kaydı başarıyla güncellenmiştir.", "Bilgi");
                    Close();
                }
            }
        }
    }
}
