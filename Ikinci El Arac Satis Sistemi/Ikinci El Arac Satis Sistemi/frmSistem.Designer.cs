namespace Ikinci_El_Arac_Satis_Sistemi
{
    partial class frmSistem
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
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtBxMarka = new System.Windows.Forms.TextBox();
            this.btnAracKayit = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblSatisFyt = new System.Windows.Forms.Label();
            this.lblYakit = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBxModel = new System.Windows.Forms.TextBox();
            this.txtBxKm = new System.Windows.Forms.TextBox();
            this.txtBxSatisFyt = new System.Windows.Forms.TextBox();
            this.txtBxYakit = new System.Windows.Forms.TextBox();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.lstBxAracLst = new System.Windows.Forms.ListBox();
            this.lblUretimYil = new System.Windows.Forms.Label();
            this.txtBxUretimYil = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(46, 28);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(121, 20);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "Araba Marka: ";
            // 
            // txtBxMarka
            // 
            this.txtBxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxMarka.Location = new System.Drawing.Point(202, 28);
            this.txtBxMarka.Name = "txtBxMarka";
            this.txtBxMarka.Size = new System.Drawing.Size(100, 26);
            this.txtBxMarka.TabIndex = 2;
            // 
            // btnAracKayit
            // 
            this.btnAracKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracKayit.Location = new System.Drawing.Point(62, 583);
            this.btnAracKayit.Name = "btnAracKayit";
            this.btnAracKayit.Size = new System.Drawing.Size(143, 59);
            this.btnAracKayit.TabIndex = 3;
            this.btnAracKayit.Text = "Satışa Çıkar";
            this.btnAracKayit.UseVisualStyleBackColor = true;
            this.btnAracKayit.Click += new System.EventHandler(this.btnAracKayit_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(46, 81);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(115, 20);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Araba Model:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKm.Location = new System.Drawing.Point(46, 139);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(92, 20);
            this.lblKm.TabIndex = 6;
            this.lblKm.Text = "Araba Km:";
            // 
            // lblSatisFyt
            // 
            this.lblSatisFyt.AutoSize = true;
            this.lblSatisFyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFyt.Location = new System.Drawing.Point(46, 195);
            this.lblSatisFyt.Name = "lblSatisFyt";
            this.lblSatisFyt.Size = new System.Drawing.Size(103, 20);
            this.lblSatisFyt.TabIndex = 7;
            this.lblSatisFyt.Text = "Satış Fiyatı:";
            // 
            // lblYakit
            // 
            this.lblYakit.AutoSize = true;
            this.lblYakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYakit.Location = new System.Drawing.Point(46, 237);
            this.lblYakit.Name = "lblYakit";
            this.lblYakit.Size = new System.Drawing.Size(96, 20);
            this.lblYakit.TabIndex = 8;
            this.lblYakit.Text = "Yakıt Türü:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(46, 343);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 20);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "Araba ID :";
            // 
            // txtBxModel
            // 
            this.txtBxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxModel.Location = new System.Drawing.Point(202, 78);
            this.txtBxModel.Name = "txtBxModel";
            this.txtBxModel.Size = new System.Drawing.Size(100, 26);
            this.txtBxModel.TabIndex = 10;
            // 
            // txtBxKm
            // 
            this.txtBxKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxKm.Location = new System.Drawing.Point(202, 136);
            this.txtBxKm.Name = "txtBxKm";
            this.txtBxKm.Size = new System.Drawing.Size(100, 26);
            this.txtBxKm.TabIndex = 11;
            // 
            // txtBxSatisFyt
            // 
            this.txtBxSatisFyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxSatisFyt.Location = new System.Drawing.Point(202, 189);
            this.txtBxSatisFyt.Name = "txtBxSatisFyt";
            this.txtBxSatisFyt.Size = new System.Drawing.Size(100, 26);
            this.txtBxSatisFyt.TabIndex = 12;
            // 
            // txtBxYakit
            // 
            this.txtBxYakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxYakit.Location = new System.Drawing.Point(202, 237);
            this.txtBxYakit.Name = "txtBxYakit";
            this.txtBxYakit.Size = new System.Drawing.Size(100, 26);
            this.txtBxYakit.TabIndex = 13;
            // 
            // txtBxID
            // 
            this.txtBxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxID.Location = new System.Drawing.Point(202, 337);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(100, 26);
            this.txtBxID.TabIndex = 14;
            // 
            // lstBxAracLst
            // 
            this.lstBxAracLst.FormattingEnabled = true;
            this.lstBxAracLst.Items.AddRange(new object[] {
            "ID --- MARKA ------ ----MODEL --------- KM ---- -SATIŞ FİYATI ---- --YAKIT TÜRÜ"});
            this.lstBxAracLst.Location = new System.Drawing.Point(345, 28);
            this.lstBxAracLst.Name = "lstBxAracLst";
            this.lstBxAracLst.Size = new System.Drawing.Size(375, 95);
            this.lstBxAracLst.TabIndex = 15;
            // 
            // lblUretimYil
            // 
            this.lblUretimYil.AutoSize = true;
            this.lblUretimYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUretimYil.Location = new System.Drawing.Point(46, 295);
            this.lblUretimYil.Name = "lblUretimYil";
            this.lblUretimYil.Size = new System.Drawing.Size(159, 20);
            this.lblUretimYil.TabIndex = 16;
            this.lblUretimYil.Text = "Araba Üretim Yılı : ";
            // 
            // txtBxUretimYil
            // 
            this.txtBxUretimYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxUretimYil.Location = new System.Drawing.Point(202, 292);
            this.txtBxUretimYil.Name = "txtBxUretimYil";
            this.txtBxUretimYil.Size = new System.Drawing.Size(100, 26);
            this.txtBxUretimYil.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(458, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 59);
            this.button1.TabIndex = 18;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(12, 447);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 26);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Sis Farı";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(142, 447);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(172, 26);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Katlanılabilir Ayna";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.Location = new System.Drawing.Point(142, 479);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(138, 26);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "Park Sensörü";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox4.Location = new System.Drawing.Point(12, 479);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(124, 26);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = "Merkezi Kilit";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox5.Location = new System.Drawing.Point(83, 533);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(122, 26);
            this.checkBox5.TabIndex = 23;
            this.checkBox5.Text = "Cam Tavan";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // frmSistem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 654);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxUretimYil);
            this.Controls.Add(this.lblUretimYil);
            this.Controls.Add(this.lstBxAracLst);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.txtBxYakit);
            this.Controls.Add(this.txtBxSatisFyt);
            this.Controls.Add(this.txtBxKm);
            this.Controls.Add(this.txtBxModel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblYakit);
            this.Controls.Add(this.lblSatisFyt);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.btnAracKayit);
            this.Controls.Add(this.txtBxMarka);
            this.Controls.Add(this.lblMarka);
            this.Name = "frmSistem";
            this.Text = "frmAracIslem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtBxMarka;
        private System.Windows.Forms.Button btnAracKayit;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblSatisFyt;
        private System.Windows.Forms.Label lblYakit;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtBxModel;
        private System.Windows.Forms.TextBox txtBxKm;
        private System.Windows.Forms.TextBox txtBxSatisFyt;
        private System.Windows.Forms.TextBox txtBxYakit;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.ListBox lstBxAracLst;
        private System.Windows.Forms.Label lblUretimYil;
        private System.Windows.Forms.TextBox txtBxUretimYil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}