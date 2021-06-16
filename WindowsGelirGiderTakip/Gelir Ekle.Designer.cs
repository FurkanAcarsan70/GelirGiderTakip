
namespace WindowsGelirGiderTakip
{
    partial class Gelir_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gelir_Ekle));
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGelirKaydet = new System.Windows.Forms.Button();
            this.btnGelirTipiEkle = new System.Windows.Forms.Button();
            this.txtGelirAçıklama = new System.Windows.Forms.TextBox();
            this.txtGelirCari = new System.Windows.Forms.TextBox();
            this.cmbGelirTipi = new System.Windows.Forms.ComboBox();
            this.txtGelirSahipSoyadı = new System.Windows.Forms.TextBox();
            this.txtGelirSahibiAdı = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTipSil = new System.Windows.Forms.Button();
            this.radBorç = new System.Windows.Forms.RadioButton();
            this.radGider = new System.Windows.Forms.RadioButton();
            this.radGelir = new System.Windows.Forms.RadioButton();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtGelirID = new WindowsGelirGiderTakip.TextBoxNumbersOnly();
            this.txtGelirTutar = new WindowsGelirGiderTakip.TextBoxNumbersOnly();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(107, 303);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(89, 23);
            this.btnKapat.TabIndex = 50;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGelirKaydet
            // 
            this.btnGelirKaydet.Location = new System.Drawing.Point(202, 303);
            this.btnGelirKaydet.Name = "btnGelirKaydet";
            this.btnGelirKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnGelirKaydet.TabIndex = 49;
            this.btnGelirKaydet.Text = "Kaydet";
            this.btnGelirKaydet.UseVisualStyleBackColor = true;
            this.btnGelirKaydet.Click += new System.EventHandler(this.btnGelirKaydet_Click);
            // 
            // btnGelirTipiEkle
            // 
            this.btnGelirTipiEkle.Location = new System.Drawing.Point(284, 95);
            this.btnGelirTipiEkle.Name = "btnGelirTipiEkle";
            this.btnGelirTipiEkle.Size = new System.Drawing.Size(23, 23);
            this.btnGelirTipiEkle.TabIndex = 48;
            this.btnGelirTipiEkle.Text = "+";
            this.btnGelirTipiEkle.UseVisualStyleBackColor = true;
            this.btnGelirTipiEkle.Click += new System.EventHandler(this.btnGelirTipiEkle_Click);
            // 
            // txtGelirAçıklama
            // 
            this.txtGelirAçıklama.Location = new System.Drawing.Point(124, 206);
            this.txtGelirAçıklama.Multiline = true;
            this.txtGelirAçıklama.Name = "txtGelirAçıklama";
            this.txtGelirAçıklama.Size = new System.Drawing.Size(154, 90);
            this.txtGelirAçıklama.TabIndex = 47;
            // 
            // txtGelirCari
            // 
            this.txtGelirCari.Location = new System.Drawing.Point(124, 148);
            this.txtGelirCari.Name = "txtGelirCari";
            this.txtGelirCari.Size = new System.Drawing.Size(154, 23);
            this.txtGelirCari.TabIndex = 45;
            // 
            // cmbGelirTipi
            // 
            this.cmbGelirTipi.FormattingEnabled = true;
            this.cmbGelirTipi.Location = new System.Drawing.Point(124, 95);
            this.cmbGelirTipi.Name = "cmbGelirTipi";
            this.cmbGelirTipi.Size = new System.Drawing.Size(154, 23);
            this.cmbGelirTipi.TabIndex = 44;
            // 
            // txtGelirSahipSoyadı
            // 
            this.txtGelirSahipSoyadı.Location = new System.Drawing.Point(124, 66);
            this.txtGelirSahipSoyadı.Name = "txtGelirSahipSoyadı";
            this.txtGelirSahipSoyadı.Size = new System.Drawing.Size(154, 23);
            this.txtGelirSahipSoyadı.TabIndex = 43;
            // 
            // txtGelirSahibiAdı
            // 
            this.txtGelirSahibiAdı.Location = new System.Drawing.Point(124, 37);
            this.txtGelirSahibiAdı.Name = "txtGelirSahibiAdı";
            this.txtGelirSahibiAdı.Size = new System.Drawing.Size(154, 23);
            this.txtGelirSahibiAdı.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Gelir Sahibinin Soyadı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Gelir Sahibinin Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cari:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID:";
            // 
            // btnTipSil
            // 
            this.btnTipSil.Location = new System.Drawing.Point(313, 95);
            this.btnTipSil.Name = "btnTipSil";
            this.btnTipSil.Size = new System.Drawing.Size(26, 23);
            this.btnTipSil.TabIndex = 51;
            this.btnTipSil.Text = "-";
            this.btnTipSil.UseVisualStyleBackColor = true;
            this.btnTipSil.Click += new System.EventHandler(this.btnTipSil_Click);
            // 
            // radBorç
            // 
            this.radBorç.AutoSize = true;
            this.radBorç.Location = new System.Drawing.Point(229, 123);
            this.radBorç.Name = "radBorç";
            this.radBorç.Size = new System.Drawing.Size(49, 19);
            this.radBorç.TabIndex = 54;
            this.radBorç.Text = "Borç";
            this.radBorç.UseVisualStyleBackColor = true;
            // 
            // radGider
            // 
            this.radGider.AutoSize = true;
            this.radGider.Location = new System.Drawing.Point(171, 123);
            this.radGider.Name = "radGider";
            this.radGider.Size = new System.Drawing.Size(53, 19);
            this.radGider.TabIndex = 53;
            this.radGider.Text = "Gider";
            this.radGider.UseVisualStyleBackColor = true;
            // 
            // radGelir
            // 
            this.radGelir.AutoSize = true;
            this.radGelir.Checked = true;
            this.radGelir.Location = new System.Drawing.Point(124, 123);
            this.radGelir.Name = "radGelir";
            this.radGelir.Size = new System.Drawing.Size(49, 19);
            this.radGelir.TabIndex = 52;
            this.radGelir.TabStop = true;
            this.radGelir.Text = "Gelir";
            this.radGelir.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(283, 303);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(44, 23);
            this.btnSil.TabIndex = 55;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtGelirID
            // 
            this.txtGelirID.Location = new System.Drawing.Point(124, 8);
            this.txtGelirID.Name = "txtGelirID";
            this.txtGelirID.NumbersOnly = true;
            this.txtGelirID.Size = new System.Drawing.Size(100, 23);
            this.txtGelirID.TabIndex = 56;
            // 
            // txtGelirTutar
            // 
            this.txtGelirTutar.Location = new System.Drawing.Point(124, 177);
            this.txtGelirTutar.Name = "txtGelirTutar";
            this.txtGelirTutar.NumbersOnly = true;
            this.txtGelirTutar.Size = new System.Drawing.Size(100, 23);
            this.txtGelirTutar.TabIndex = 57;
            // 
            // Gelir_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(341, 328);
            this.Controls.Add(this.txtGelirTutar);
            this.Controls.Add(this.txtGelirID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.radBorç);
            this.Controls.Add(this.radGider);
            this.Controls.Add(this.radGelir);
            this.Controls.Add(this.btnTipSil);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGelirKaydet);
            this.Controls.Add(this.btnGelirTipiEkle);
            this.Controls.Add(this.txtGelirAçıklama);
            this.Controls.Add(this.txtGelirCari);
            this.Controls.Add(this.cmbGelirTipi);
            this.Controls.Add(this.txtGelirSahipSoyadı);
            this.Controls.Add(this.txtGelirSahibiAdı);
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
            this.Name = "Gelir_Ekle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Ekle";
            this.Load += new System.EventHandler(this.Gelir_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGelirKaydet;
        private System.Windows.Forms.Button btnGelirTipiEkle;
        private System.Windows.Forms.TextBox txtGelirAçıklama;
        private System.Windows.Forms.TextBox txtGelirCari;
        private System.Windows.Forms.ComboBox cmbGelirTipi;
        private System.Windows.Forms.TextBox txtGelirSahipSoyadı;
        private System.Windows.Forms.TextBox txtGelirSahibiAdı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTipSil;
        private System.Windows.Forms.RadioButton radBorç;
        private System.Windows.Forms.RadioButton radGider;
        private System.Windows.Forms.RadioButton radGelir;
        private System.Windows.Forms.Button btnSil;
        private TextBoxNumbersOnly txtGelirID;
        private TextBoxNumbersOnly txtGelirTutar;
    }
}