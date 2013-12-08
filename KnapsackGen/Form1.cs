using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KnapsackGen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int maksimumIterasyonSayisi;

        private void btnHazirla_Click(object sender, EventArgs e)
        {
            try
            {
                Knapsack.reset();
                Knapsack.getInstance(Convert.ToInt32(txtElemanSayisi.Text), Convert.ToInt32(txtCantaKapasitesi.Text), cmbCaprazlamaYontemi.SelectedIndex);

                for (int i = 0; i < lstElemanlar.Items.Count; i++ )
                    Knapsack.getInstance().TumElemanlar[i] = Convert.ToInt32(lstElemanlar.Items[i]);

                if (lstElemanlar.Items.Count < Knapsack.getInstance().ElemanSayisi)
                {
                    Knapsack.getInstance().init();

                    lstElemanlar.Items.Clear();

                    foreach (int i in Knapsack.getInstance().TumElemanlar)
                        lstElemanlar.Items.Add(i);
                }
                else
                    Knapsack.getInstance().init(true);


                txtEnIyiKromozom.Text = Knapsack.getInstance().MevcutCozum.ToString();
                lblFitness.Text = Knapsack.getInstance().MevcutCozum.Fitness.ToString();
                maksimumIterasyonSayisi = Convert.ToInt32(txtIterasyonSayisi.Text);
                btnBaslat.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            while (Math.Abs(Knapsack.getInstance().Kapasite - Knapsack.getInstance().MevcutCozum.Fitness) >= Math.Abs(Knapsack.getInstance().Kapasite - ((Knapsack.getInstance().Kapasite * Convert.ToInt32(txtBasariYuzdesi.Text)) / 100)) && sayac <= maksimumIterasyonSayisi)
            {
                Knapsack.getInstance().solve();
                txtEnIyiKromozom.Text = Knapsack.getInstance().MevcutCozum.ToString();
                lblFitness.Text = Knapsack.getInstance().MevcutCozum.Fitness.ToString();
                sayac++;
                lblSuankiIterasyon.Text = sayac.ToString();
                Application.DoEvents();
            }
            MessageBox.Show(sayac.ToString());
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                lstElemanlar.Items.Add(txtEleman.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstElemanlar.Items.Clear();
 
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstElemanlar.Items.RemoveAt(lstElemanlar.SelectedIndex);
        }
    }
}
