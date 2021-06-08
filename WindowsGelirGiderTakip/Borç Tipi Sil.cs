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
    public partial class Tip_Kaydı_Sil : Form
    {
        public Tip_Kaydı_Sil()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTipSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu tip kaydını silmek istediğinizden emin misiniz?", "Silmek İstediğinizden emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bağlantı.ConnectionClass.Command("" +
                    "    DELETE FROM [dbo].[Borç_Tipi]      WHERE Borç_Tipi_ID = '" + Convert.ToInt32(txtTipID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Tip kaydı başarıyla silindi.", "Bilgi");
                    Close();
                }
            }
        }
    }
}
