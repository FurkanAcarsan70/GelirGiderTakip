
namespace WindowsGelirGiderTakip
{
    partial class Borç_Tipi_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Borç_Tipi_Ekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipID = new System.Windows.Forms.TextBox();
            this.txtTipAd = new System.Windows.Forms.TextBox();
            this.txtTipAçıklama = new System.Windows.Forms.TextBox();
            this.btnTipKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip Açıklaması:";
            // 
            // txtTipID
            // 
            this.txtTipID.Location = new System.Drawing.Point(104, 6);
            this.txtTipID.Name = "txtTipID";
            this.txtTipID.Size = new System.Drawing.Size(83, 23);
            this.txtTipID.TabIndex = 3;
            this.txtTipID.Text = "0";
            // 
            // txtTipAd
            // 
            this.txtTipAd.Location = new System.Drawing.Point(104, 33);
            this.txtTipAd.Name = "txtTipAd";
            this.txtTipAd.Size = new System.Drawing.Size(142, 23);
            this.txtTipAd.TabIndex = 4;
            // 
            // txtTipAçıklama
            // 
            this.txtTipAçıklama.Location = new System.Drawing.Point(104, 63);
            this.txtTipAçıklama.Multiline = true;
            this.txtTipAçıklama.Name = "txtTipAçıklama";
            this.txtTipAçıklama.Size = new System.Drawing.Size(142, 64);
            this.txtTipAçıklama.TabIndex = 5;
            // 
            // btnTipKaydet
            // 
            this.btnTipKaydet.Location = new System.Drawing.Point(170, 134);
            this.btnTipKaydet.Name = "btnTipKaydet";
            this.btnTipKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnTipKaydet.TabIndex = 6;
            this.btnTipKaydet.Text = "Kaydet";
            this.btnTipKaydet.UseVisualStyleBackColor = true;
            this.btnTipKaydet.Click += new System.EventHandler(this.btnTipKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(77, 134);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(87, 23);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Borç_Tipi_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(253, 170);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTipKaydet);
            this.Controls.Add(this.txtTipAçıklama);
            this.Controls.Add(this.txtTipAd);
            this.Controls.Add(this.txtTipID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Borç_Tipi_Ekle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipID;
        private System.Windows.Forms.TextBox txtTipAd;
        private System.Windows.Forms.TextBox txtTipAçıklama;
        private System.Windows.Forms.Button btnTipKaydet;
        private System.Windows.Forms.Button btnKapat;
    }
}