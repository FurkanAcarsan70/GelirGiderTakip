
namespace WindowsGelirGiderTakip
{
    partial class Gelir_Gider
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gelir_Gider));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radBorç = new System.Windows.Forms.RadioButton();
            this.radGider = new System.Windows.Forms.RadioButton();
            this.radGelir = new System.Windows.Forms.RadioButton();
            this.btn_Tümünü_Göster = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.cmbTipi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Borç_Ekle = new System.Windows.Forms.Button();
            this.btn_Gider_Ekle = new System.Windows.Forms.Button();
            this.btn_Gelir_Ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ev Ekonomisi Yönetim Professional Uygulamasına Hoş Geldiniz.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radBorç);
            this.panel1.Controls.Add(this.radGider);
            this.panel1.Controls.Add(this.radGelir);
            this.panel1.Controls.Add(this.btn_Tümünü_Göster);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.cmbTipi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Borç_Ekle);
            this.panel1.Controls.Add(this.btn_Gider_Ekle);
            this.panel1.Controls.Add(this.btn_Gelir_Ekle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 497);
            this.panel1.TabIndex = 2;
            // 
            // radBorç
            // 
            this.radBorç.AutoSize = true;
            this.radBorç.Location = new System.Drawing.Point(154, 134);
            this.radBorç.Name = "radBorç";
            this.radBorç.Size = new System.Drawing.Size(49, 19);
            this.radBorç.TabIndex = 10;
            this.radBorç.TabStop = true;
            this.radBorç.Text = "Borç";
            this.radBorç.UseVisualStyleBackColor = true;
            // 
            // radGider
            // 
            this.radGider.AutoSize = true;
            this.radGider.Location = new System.Drawing.Point(95, 134);
            this.radGider.Name = "radGider";
            this.radGider.Size = new System.Drawing.Size(53, 19);
            this.radGider.TabIndex = 9;
            this.radGider.TabStop = true;
            this.radGider.Text = "Gider";
            this.radGider.UseVisualStyleBackColor = true;
            // 
            // radGelir
            // 
            this.radGelir.AutoSize = true;
            this.radGelir.Location = new System.Drawing.Point(40, 134);
            this.radGelir.Name = "radGelir";
            this.radGelir.Size = new System.Drawing.Size(49, 19);
            this.radGelir.TabIndex = 8;
            this.radGelir.TabStop = true;
            this.radGelir.Text = "Gelir";
            this.radGelir.UseVisualStyleBackColor = true;
            // 
            // btn_Tümünü_Göster
            // 
            this.btn_Tümünü_Göster.Location = new System.Drawing.Point(12, 159);
            this.btn_Tümünü_Göster.Name = "btn_Tümünü_Göster";
            this.btn_Tümünü_Göster.Size = new System.Drawing.Size(104, 29);
            this.btn_Tümünü_Göster.TabIndex = 7;
            this.btn_Tümünü_Göster.Text = "Tümünü Göster";
            this.btn_Tümünü_Göster.UseVisualStyleBackColor = true;
            this.btn_Tümünü_Göster.Click += new System.EventHandler(this.btn_Tümünü_Göster_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(40, 79);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(119, 23);
            this.txt_ID.TabIndex = 5;
            // 
            // cmbTipi
            // 
            this.cmbTipi.AutoSize = true;
            this.cmbTipi.Location = new System.Drawing.Point(5, 112);
            this.cmbTipi.Name = "cmbTipi";
            this.cmbTipi.Size = new System.Drawing.Size(29, 15);
            this.cmbTipi.TabIndex = 4;
            this.cmbTipi.Text = "Tipi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // btn_Borç_Ekle
            // 
            this.btn_Borç_Ekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Borç_Ekle.Location = new System.Drawing.Point(0, 370);
            this.btn_Borç_Ekle.Name = "btn_Borç_Ekle";
            this.btn_Borç_Ekle.Size = new System.Drawing.Size(350, 42);
            this.btn_Borç_Ekle.TabIndex = 2;
            this.btn_Borç_Ekle.Text = "Borç Ekle";
            this.btn_Borç_Ekle.UseVisualStyleBackColor = true;
            this.btn_Borç_Ekle.Click += new System.EventHandler(this.btn_Borç_Ekle_Click);
            // 
            // btn_Gider_Ekle
            // 
            this.btn_Gider_Ekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Gider_Ekle.Location = new System.Drawing.Point(0, 412);
            this.btn_Gider_Ekle.Name = "btn_Gider_Ekle";
            this.btn_Gider_Ekle.Size = new System.Drawing.Size(350, 45);
            this.btn_Gider_Ekle.TabIndex = 1;
            this.btn_Gider_Ekle.Text = "Gider Ekle";
            this.btn_Gider_Ekle.UseVisualStyleBackColor = true;
            this.btn_Gider_Ekle.Click += new System.EventHandler(this.btn_Gider_Ekle_Click);
            // 
            // btn_Gelir_Ekle
            // 
            this.btn_Gelir_Ekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Gelir_Ekle.Location = new System.Drawing.Point(0, 457);
            this.btn_Gelir_Ekle.Name = "btn_Gelir_Ekle";
            this.btn_Gelir_Ekle.Size = new System.Drawing.Size(350, 40);
            this.btn_Gelir_Ekle.TabIndex = 0;
            this.btn_Gelir_Ekle.Text = "Gelir Ekle";
            this.btn_Gelir_Ekle.UseVisualStyleBackColor = true;
            this.btn_Gelir_Ekle.Click += new System.EventHandler(this.btn_Gelir_Ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(350, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(559, 497);
            this.dataGridView1.TabIndex = 3;
            // 
            // Gelir_Gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gelir_Gider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ev Ekonomisi Yönetim Professional ";
            this.Load += new System.EventHandler(this.Gelir_Gider_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label cmbTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Borç_Ekle;
        private System.Windows.Forms.Button btn_Gider_Ekle;
        private System.Windows.Forms.Button btn_Gelir_Ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Tümünü_Göster;
        private System.Windows.Forms.RadioButton radGelir;
        private System.Windows.Forms.RadioButton radBorç;
        private System.Windows.Forms.RadioButton radGider;
    }
}

