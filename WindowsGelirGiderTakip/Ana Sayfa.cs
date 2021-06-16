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
            Update();
        }
        private void btn_Tümünü_Göster_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = this.dataGridView1.Rows[e.RowIndex];
                txt_ID.Text = Row.Cells["ID"].Value.ToString();
                comboBox1.SelectedValue = Row.Cells["Tipi"].Value.ToString();
                string Gelir_Gider_Borç = Row.Cells["İşlem Tipi"].Value.ToString();
                switch (Gelir_Gider_Borç)
                {
                    case "Gelir":
                        radGelir.Checked = true;
                        break;
                    case "Gider":
                        radGider.Checked = true;
                        break;
                    case "Borç":
                        radBorç.Checked = true;
                        break;
                    default:
                        radGelir.Checked = false;
                        radGider.Checked = false;
                        radBorç.Checked = false;
                        break;
                }
            }
        }

        #region Güncelleme Metotu
        void Update()
        {
            dataGridView1.DataSource = Bağlantı.ConnectionClass.DataTable("SELECT * FROM dbo.GelirGiderBorç_Table(0)");
        }
        #endregion

        #region Butonlar
        private void btn_Borç_Ekle_Click(object sender, EventArgs e)
        {
            Borç_Ekle Borç = new Borç_Ekle();
            Borç.ShowDialog();
            Update();
        }

        private void btn_Gider_Ekle_Click(object sender, EventArgs e)
        {
            Gider_Ekle Gider = new Gider_Ekle();
            Gider.ShowDialog();
            Update();
        }

        private void btn_Gelir_Ekle_Click(object sender, EventArgs e)
        {
            Gelir_Ekle Gelir = new Gelir_Ekle();
            Gelir.ShowDialog();
            Update();
        }
        #endregion
    }
}
