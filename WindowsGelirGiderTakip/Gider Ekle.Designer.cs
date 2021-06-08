
namespace WindowsGelirGiderTakip
{
    partial class Gider_Ekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gider_Ekle));
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGiderKaydet = new System.Windows.Forms.Button();
            this.btnGiderTipiEkle = new System.Windows.Forms.Button();
            this.txtGiderAçıklama = new System.Windows.Forms.TextBox();
            this.txtGiderTutar = new System.Windows.Forms.TextBox();
            this.txtGiderCari = new System.Windows.Forms.TextBox();
            this.cmbGiderTipi = new System.Windows.Forms.ComboBox();
            this.txtGiderSahipSoyadı = new System.Windows.Forms.TextBox();
            this.txtGiderSahibiAdı = new System.Windows.Forms.TextBox();
            this.txtGiderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTipSil = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.radBorç = new System.Windows.Forms.RadioButton();
            this.radGider = new System.Windows.Forms.RadioButton();
            this.radGelir = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(104, 295);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(89, 23);
            this.btnKapat.TabIndex = 33;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGiderKaydet
            // 
            this.btnGiderKaydet.Location = new System.Drawing.Point(199, 295);
            this.btnGiderKaydet.Name = "btnGiderKaydet";
            this.btnGiderKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnGiderKaydet.TabIndex = 32;
            this.btnGiderKaydet.Text = "Kaydet";
            this.btnGiderKaydet.UseVisualStyleBackColor = true;
            this.btnGiderKaydet.Click += new System.EventHandler(this.btnGiderKaydet_Click);
            // 
            // btnGiderTipiEkle
            // 
            this.btnGiderTipiEkle.Location = new System.Drawing.Point(281, 89);
            this.btnGiderTipiEkle.Name = "btnGiderTipiEkle";
            this.btnGiderTipiEkle.Size = new System.Drawing.Size(23, 23);
            this.btnGiderTipiEkle.TabIndex = 31;
            this.btnGiderTipiEkle.Text = "+";
            this.btnGiderTipiEkle.UseVisualStyleBackColor = true;
            this.btnGiderTipiEkle.Click += new System.EventHandler(this.btnGiderTipiEkle_Click);
            // 
            // txtGiderAçıklama
            // 
            this.txtGiderAçıklama.Location = new System.Drawing.Point(121, 198);
            this.txtGiderAçıklama.Multiline = true;
            this.txtGiderAçıklama.Name = "txtGiderAçıklama";
            this.txtGiderAçıklama.Size = new System.Drawing.Size(154, 90);
            this.txtGiderAçıklama.TabIndex = 30;
            // 
            // txtGiderTutar
            // 
            this.txtGiderTutar.Location = new System.Drawing.Point(121, 169);
            this.txtGiderTutar.Name = "txtGiderTutar";
            this.txtGiderTutar.Size = new System.Drawing.Size(100, 23);
            this.txtGiderTutar.TabIndex = 29;
            // 
            // txtGiderCari
            // 
            this.txtGiderCari.Location = new System.Drawing.Point(121, 140);
            this.txtGiderCari.Name = "txtGiderCari";
            this.txtGiderCari.Size = new System.Drawing.Size(154, 23);
            this.txtGiderCari.TabIndex = 28;
            // 
            // cmbGiderTipi
            // 
            this.cmbGiderTipi.FormattingEnabled = true;
            this.cmbGiderTipi.Location = new System.Drawing.Point(121, 89);
            this.cmbGiderTipi.Name = "cmbGiderTipi";
            this.cmbGiderTipi.Size = new System.Drawing.Size(154, 23);
            this.cmbGiderTipi.TabIndex = 27;
            // 
            // txtGiderSahipSoyadı
            // 
            this.txtGiderSahipSoyadı.Location = new System.Drawing.Point(121, 60);
            this.txtGiderSahipSoyadı.Name = "txtGiderSahipSoyadı";
            this.txtGiderSahipSoyadı.Size = new System.Drawing.Size(154, 23);
            this.txtGiderSahipSoyadı.TabIndex = 26;
            // 
            // txtGiderSahibiAdı
            // 
            this.txtGiderSahibiAdı.Location = new System.Drawing.Point(121, 31);
            this.txtGiderSahibiAdı.Name = "txtGiderSahibiAdı";
            this.txtGiderSahibiAdı.Size = new System.Drawing.Size(154, 23);
            this.txtGiderSahibiAdı.TabIndex = 25;
            // 
            // txtGiderID
            // 
            this.txtGiderID.Location = new System.Drawing.Point(121, 2);
            this.txtGiderID.Name = "txtGiderID";
            this.txtGiderID.Size = new System.Drawing.Size(100, 23);
            this.txtGiderID.TabIndex = 24;
            this.txtGiderID.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Gider Sahibinin Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Gider Sahibinin Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cari:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // btnTipSil
            // 
            this.btnTipSil.Location = new System.Drawing.Point(310, 89);
            this.btnTipSil.Name = "btnTipSil";
            this.btnTipSil.Size = new System.Drawing.Size(26, 23);
            this.btnTipSil.TabIndex = 52;
            this.btnTipSil.Text = "-";
            this.btnTipSil.UseVisualStyleBackColor = true;
            this.btnTipSil.Click += new System.EventHandler(this.btnTipSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(281, 295);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(44, 23);
            this.btnSil.TabIndex = 56;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // radBorç
            // 
            this.radBorç.AutoSize = true;
            this.radBorç.Location = new System.Drawing.Point(226, 118);
            this.radBorç.Name = "radBorç";
            this.radBorç.Size = new System.Drawing.Size(49, 19);
            this.radBorç.TabIndex = 55;
            this.radBorç.Text = "Borç";
            this.radBorç.UseVisualStyleBackColor = true;
            // 
            // radGider
            // 
            this.radGider.AutoSize = true;
            this.radGider.Checked = true;
            this.radGider.Location = new System.Drawing.Point(168, 118);
            this.radGider.Name = "radGider";
            this.radGider.Size = new System.Drawing.Size(53, 19);
            this.radGider.TabIndex = 54;
            this.radGider.TabStop = true;
            this.radGider.Text = "Gider";
            this.radGider.UseVisualStyleBackColor = true;
            // 
            // radGelir
            // 
            this.radGelir.AutoSize = true;
            this.radGelir.Location = new System.Drawing.Point(121, 118);
            this.radGelir.Name = "radGelir";
            this.radGelir.Size = new System.Drawing.Size(49, 19);
            this.radGelir.TabIndex = 53;
            this.radGelir.Text = "Gelir";
            this.radGelir.UseVisualStyleBackColor = true;
            // 
            // Gider_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(341, 323);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.radBorç);
            this.Controls.Add(this.radGider);
            this.Controls.Add(this.radGelir);
            this.Controls.Add(this.btnTipSil);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGiderKaydet);
            this.Controls.Add(this.btnGiderTipiEkle);
            this.Controls.Add(this.txtGiderAçıklama);
            this.Controls.Add(this.txtGiderTutar);
            this.Controls.Add(this.txtGiderCari);
            this.Controls.Add(this.cmbGiderTipi);
            this.Controls.Add(this.txtGiderSahipSoyadı);
            this.Controls.Add(this.txtGiderSahibiAdı);
            this.Controls.Add(this.txtGiderID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gider_Ekle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Ekle";
            this.Load += new System.EventHandler(this.Gider_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGiderKaydet;
        private System.Windows.Forms.Button btnGiderTipiEkle;
        private System.Windows.Forms.TextBox txtGiderAçıklama;
        private System.Windows.Forms.TextBox txtGiderTutar;
        private System.Windows.Forms.TextBox txtGiderCari;
        private System.Windows.Forms.ComboBox cmbGiderTipi;
        private System.Windows.Forms.TextBox txtGiderSahipSoyadı;
        private System.Windows.Forms.TextBox txtGiderSahibiAdı;
        private System.Windows.Forms.TextBox txtGiderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTipSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.RadioButton radBorç;
        private System.Windows.Forms.RadioButton radGider;
        private System.Windows.Forms.RadioButton radGelir;
    }
}