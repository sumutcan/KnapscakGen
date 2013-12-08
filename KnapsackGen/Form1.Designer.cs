namespace KnapsackGen
{
    partial class Form1
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
            this.txtEnIyiKromozom = new System.Windows.Forms.TextBox();
            this.lblFitness = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantaKapasitesi = new System.Windows.Forms.TextBox();
            this.txtElemanSayisi = new System.Windows.Forms.TextBox();
            this.cmbCaprazlamaYontemi = new System.Windows.Forms.ComboBox();
            this.lstElemanlar = new System.Windows.Forms.ListBox();
            this.btnHazirla = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.txtIterasyonSayisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBasariYuzdesi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEleman = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSuankiIterasyon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnIyiKromozom
            // 
            this.txtEnIyiKromozom.Location = new System.Drawing.Point(12, 25);
            this.txtEnIyiKromozom.Multiline = true;
            this.txtEnIyiKromozom.Name = "txtEnIyiKromozom";
            this.txtEnIyiKromozom.Size = new System.Drawing.Size(823, 39);
            this.txtEnIyiKromozom.TabIndex = 8;
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Location = new System.Drawing.Point(12, 78);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(13, 13);
            this.lblFitness.TabIndex = 1;
            this.lblFitness.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çanta kapasitesi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eleman Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çaprazlama Yöntemi:";
            // 
            // txtCantaKapasitesi
            // 
            this.txtCantaKapasitesi.Location = new System.Drawing.Point(121, 136);
            this.txtCantaKapasitesi.Name = "txtCantaKapasitesi";
            this.txtCantaKapasitesi.Size = new System.Drawing.Size(123, 20);
            this.txtCantaKapasitesi.TabIndex = 2;
            this.txtCantaKapasitesi.Text = "100";
            // 
            // txtElemanSayisi
            // 
            this.txtElemanSayisi.Location = new System.Drawing.Point(121, 166);
            this.txtElemanSayisi.Name = "txtElemanSayisi";
            this.txtElemanSayisi.Size = new System.Drawing.Size(123, 20);
            this.txtElemanSayisi.TabIndex = 3;
            this.txtElemanSayisi.Text = "6";
            // 
            // cmbCaprazlamaYontemi
            // 
            this.cmbCaprazlamaYontemi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaprazlamaYontemi.FormattingEnabled = true;
            this.cmbCaprazlamaYontemi.Items.AddRange(new object[] {
            "Tek noktalı çaprazlama",
            "İki noktalı çaprazlama",
            "Birleşik çaprazlama"});
            this.cmbCaprazlamaYontemi.Location = new System.Drawing.Point(121, 226);
            this.cmbCaprazlamaYontemi.Name = "cmbCaprazlamaYontemi";
            this.cmbCaprazlamaYontemi.Size = new System.Drawing.Size(123, 21);
            this.cmbCaprazlamaYontemi.TabIndex = 5;
            // 
            // lstElemanlar
            // 
            this.lstElemanlar.FormattingEnabled = true;
            this.lstElemanlar.Location = new System.Drawing.Point(262, 144);
            this.lstElemanlar.MultiColumn = true;
            this.lstElemanlar.Name = "lstElemanlar";
            this.lstElemanlar.Size = new System.Drawing.Size(573, 134);
            this.lstElemanlar.TabIndex = 9;
            // 
            // btnHazirla
            // 
            this.btnHazirla.Location = new System.Drawing.Point(9, 253);
            this.btnHazirla.Name = "btnHazirla";
            this.btnHazirla.Size = new System.Drawing.Size(75, 23);
            this.btnHazirla.TabIndex = 6;
            this.btnHazirla.Text = "Hazırla";
            this.btnHazirla.UseVisualStyleBackColor = true;
            this.btnHazirla.Click += new System.EventHandler(this.btnHazirla_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Enabled = false;
            this.btnBaslat.Location = new System.Drawing.Point(175, 253);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(69, 23);
            this.btnBaslat.TabIndex = 7;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // txtIterasyonSayisi
            // 
            this.txtIterasyonSayisi.Location = new System.Drawing.Point(121, 107);
            this.txtIterasyonSayisi.Name = "txtIterasyonSayisi";
            this.txtIterasyonSayisi.Size = new System.Drawing.Size(123, 20);
            this.txtIterasyonSayisi.TabIndex = 1;
            this.txtIterasyonSayisi.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Maks. İterasyon Say:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Başarı Yüzdesi:";
            // 
            // txtBasariYuzdesi
            // 
            this.txtBasariYuzdesi.Location = new System.Drawing.Point(121, 193);
            this.txtBasariYuzdesi.Name = "txtBasariYuzdesi";
            this.txtBasariYuzdesi.Size = new System.Drawing.Size(123, 20);
            this.txtBasariYuzdesi.TabIndex = 4;
            this.txtBasariYuzdesi.Text = "99";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Eleman:";
            // 
            // txtEleman
            // 
            this.txtEleman.Location = new System.Drawing.Point(643, 121);
            this.txtEleman.Name = "txtEleman";
            this.txtEleman.Size = new System.Drawing.Size(47, 20);
            this.txtEleman.TabIndex = 16;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(696, 119);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(41, 23);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(742, 119);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(34, 23);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(782, 119);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(53, 23);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Şu anki Nesil:";
            // 
            // lblSuankiIterasyon
            // 
            this.lblSuankiIterasyon.AutoSize = true;
            this.lblSuankiIterasyon.Location = new System.Drawing.Point(209, 78);
            this.lblSuankiIterasyon.Name = "lblSuankiIterasyon";
            this.lblSuankiIterasyon.Size = new System.Drawing.Size(13, 13);
            this.lblSuankiIterasyon.TabIndex = 21;
            this.lblSuankiIterasyon.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 286);
            this.Controls.Add(this.lblSuankiIterasyon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEleman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBasariYuzdesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIterasyonSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnHazirla);
            this.Controls.Add(this.lstElemanlar);
            this.Controls.Add(this.cmbCaprazlamaYontemi);
            this.Controls.Add(this.txtElemanSayisi);
            this.Controls.Add(this.txtCantaKapasitesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFitness);
            this.Controls.Add(this.txtEnIyiKromozom);
            this.Name = "Form1";
            this.Text = "Knapsack Genetik Algoritma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnIyiKromozom;
        private System.Windows.Forms.Label lblFitness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantaKapasitesi;
        private System.Windows.Forms.TextBox txtElemanSayisi;
        private System.Windows.Forms.ComboBox cmbCaprazlamaYontemi;
        private System.Windows.Forms.ListBox lstElemanlar;
        private System.Windows.Forms.Button btnHazirla;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.TextBox txtIterasyonSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBasariYuzdesi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEleman;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSuankiIterasyon;
    }
}

