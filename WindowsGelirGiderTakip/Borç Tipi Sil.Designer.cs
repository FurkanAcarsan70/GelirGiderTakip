
namespace WindowsGelirGiderTakip
{
    partial class Tip_Kaydı_Sil
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipID = new System.Windows.Forms.TextBox();
            this.btnTipSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtTipID
            // 
            this.txtTipID.Location = new System.Drawing.Point(40, 10);
            this.txtTipID.Name = "txtTipID";
            this.txtTipID.Size = new System.Drawing.Size(222, 23);
            this.txtTipID.TabIndex = 1;
            // 
            // btnTipSil
            // 
            this.btnTipSil.Location = new System.Drawing.Point(186, 40);
            this.btnTipSil.Name = "btnTipSil";
            this.btnTipSil.Size = new System.Drawing.Size(75, 23);
            this.btnTipSil.TabIndex = 2;
            this.btnTipSil.Text = "Sil";
            this.btnTipSil.UseVisualStyleBackColor = true;
            this.btnTipSil.Click += new System.EventHandler(this.btnTipSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(93, 39);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(87, 23);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Tip_Kaydı_Sil
            // 
            this.AcceptButton = this.btnTipSil;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(267, 72);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTipSil);
            this.Controls.Add(this.txtTipID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tip_Kaydı_Sil";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Kaydı Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipID;
        private System.Windows.Forms.Button btnTipSil;
        private System.Windows.Forms.Button btnKapat;
    }
}