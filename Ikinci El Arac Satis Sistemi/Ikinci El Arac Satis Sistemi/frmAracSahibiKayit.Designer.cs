namespace Ikinci_El_Arac_Satis_Sistemi
{
    partial class frmAracSahibiKayit
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtBxAd = new System.Windows.Forms.TextBox();
            this.txtBxSoyad = new System.Windows.Forms.TextBox();
            this.txtBxSifre = new System.Windows.Forms.TextBox();
            this.txtBxEposta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(400, 129);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(118, 59);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "Kayit Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(107, 29);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(36, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(107, 88);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(64, 20);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.Location = new System.Drawing.Point(107, 149);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(71, 20);
            this.lblEposta.TabIndex = 3;
            this.lblEposta.Text = "Eposta:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(107, 208);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(52, 20);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre:";
            this.lblSifre.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBxAd
            // 
            this.txtBxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxAd.Location = new System.Drawing.Point(200, 29);
            this.txtBxAd.Name = "txtBxAd";
            this.txtBxAd.Size = new System.Drawing.Size(100, 26);
            this.txtBxAd.TabIndex = 5;
            // 
            // txtBxSoyad
            // 
            this.txtBxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxSoyad.Location = new System.Drawing.Point(200, 85);
            this.txtBxSoyad.Name = "txtBxSoyad";
            this.txtBxSoyad.Size = new System.Drawing.Size(100, 26);
            this.txtBxSoyad.TabIndex = 6;
            this.txtBxSoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBxSifre
            // 
            this.txtBxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxSifre.Location = new System.Drawing.Point(200, 205);
            this.txtBxSifre.Name = "txtBxSifre";
            this.txtBxSifre.Size = new System.Drawing.Size(100, 26);
            this.txtBxSifre.TabIndex = 7;
            this.txtBxSifre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBxEposta
            // 
            this.txtBxEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxEposta.Location = new System.Drawing.Point(200, 146);
            this.txtBxEposta.Name = "txtBxEposta";
            this.txtBxEposta.Size = new System.Drawing.Size(100, 26);
            this.txtBxEposta.TabIndex = 8;
            // 
            // frmAracSahibiKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxEposta);
            this.Controls.Add(this.txtBxSifre);
            this.Controls.Add(this.txtBxSoyad);
            this.Controls.Add(this.txtBxAd);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnKayit);
            this.Name = "frmAracSahibiKayit";
            this.Text = "frmAracSahibiKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtBxAd;
        private System.Windows.Forms.TextBox txtBxSoyad;
        private System.Windows.Forms.TextBox txtBxSifre;
        private System.Windows.Forms.TextBox txtBxEposta;
    }
}