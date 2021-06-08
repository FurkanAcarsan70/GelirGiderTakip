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
    public partial class Gider_Tipi_Sil : Form
    {
        public Gider_Tipi_Sil()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTipSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu tip kaydını silmek istediğinizden emin misiniz?", "Silmek istediğinizden emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bağlantı.ConnectionClass.Command("" +
                    "    DELETE [dbo].[Gider_Tipi]     WHERE Gider_Tipi_ID = '" + Convert.ToInt32(txtTipID.Text) + "' ");
                if (Bağlantı.ConnectionClass.sqlException == null)
                {
                    MessageBox.Show("Tip kaydı başarıyla silindi.", "Bilgi");
                    Close();
                }
            }
        }
    }
}
