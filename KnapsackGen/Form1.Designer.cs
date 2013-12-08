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
            this.SuspendLayout();
            // 
            // txtEnIyiKromozom
            // 
            this.txtEnIyiKromozom.Location = new System.Drawing.Point(12, 25);
            this.txtEnIyiKromozom.Multiline = true;
            this.txtEnIyiKromozom.Name = "txtEnIyiKromozom";
            this.txtEnIyiKromozom.Size = new System.Drawing.Size(823, 39);
            this.txtEnIyiKromozom.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çanta kapasitesi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eleman Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çaprazlama Yöntemi:";
            // 
            // txtCantaKapasitesi
            // 
            this.txtCantaKapasitesi.Location = new System.Drawing.Point(121, 118);
            this.txtCantaKapasitesi.Name = "txtCantaKapasitesi";
            this.txtCantaKapasitesi.Size = new System.Drawing.Size(123, 20);
            this.txtCantaKapasitesi.TabIndex = 5;
            // 
            // txtElemanSayisi
            // 
            this.txtElemanSayisi.Location = new System.Drawing.Point(121, 148);
            this.txtElemanSayisi.Name = "txtElemanSayisi";
            this.txtElemanSayisi.Size = new System.Drawing.Size(123, 20);
            this.txtElemanSayisi.TabIndex = 6;
            // 
            // cmbCaprazlamaYontemi
            // 
            this.cmbCaprazlamaYontemi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaprazlamaYontemi.FormattingEnabled = true;
            this.cmbCaprazlamaYontemi.Items.AddRange(new object[] {
            "Tek noktalı çaprazlama",
            "İki noktalı çaprazlama",
            "Birleşik çaprazlama"});
            this.cmbCaprazlamaYontemi.Location = new System.Drawing.Point(121, 183);
            this.cmbCaprazlamaYontemi.Name = "cmbCaprazlamaYontemi";
            this.cmbCaprazlamaYontemi.Size = new System.Drawing.Size(123, 21);
            this.cmbCaprazlamaYontemi.TabIndex = 7;
            // 
            // lstElemanlar
            // 
            this.lstElemanlar.FormattingEnabled = true;
            this.lstElemanlar.Location = new System.Drawing.Point(270, 118);
            this.lstElemanlar.MultiColumn = true;
            this.lstElemanlar.Name = "lstElemanlar";
            this.lstElemanlar.Size = new System.Drawing.Size(565, 160);
            this.lstElemanlar.TabIndex = 8;
            // 
            // btnHazirla
            // 
            this.btnHazirla.Location = new System.Drawing.Point(9, 228);
            this.btnHazirla.Name = "btnHazirla";
            this.btnHazirla.Size = new System.Drawing.Size(75, 23);
            this.btnHazirla.TabIndex = 9;
            this.btnHazirla.Text = "Hazırla";
            this.btnHazirla.UseVisualStyleBackColor = true;
            this.btnHazirla.Click += new System.EventHandler(this.btnHazirla_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(175, 228);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(69, 23);
            this.btnBaslat.TabIndex = 10;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 286);
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
            this.Text = "Form1";
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
    }
}

