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

        int maksimımIterasyonSayisi;

        private void btnHazirla_Click(object sender, EventArgs e)
        {
            try
            {
                Knapsack.getInstance(Convert.ToInt32(txtElemanSayisi.Text), Convert.ToInt32(txtCantaKapasitesi.Text), cmbCaprazlamaYontemi.SelectedIndex);
                Knapsack.getInstance().init();

                lstElemanlar.Items.Clear();

                foreach (int i in Knapsack.getInstance().TumElemanlar)
                    lstElemanlar.Items.Add(i);

                txtEnIyiKromozom.Text = Knapsack.getInstance().MevcutCozum.ToString();
                lblFitness.Text = Knapsack.getInstance().MevcutCozum.Fitness.ToString();
                maksimımIterasyonSayisi = Convert.ToInt32(txtIterasyonSayisi.Text);
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
            while (Math.Abs(Knapsack.getInstance().Kapasite - Knapsack.getInstance().MevcutCozum.Fitness) >= Math.Abs(Knapsack.getInstance().Kapasite - ((Knapsack.getInstance().Kapasite * Convert.ToInt32(txtBasariYuzdesi.Text)) / 100)) && sayac <= maksimımIterasyonSayisi)
            {
                Knapsack.getInstance().solve();
                txtEnIyiKromozom.Text = Knapsack.getInstance().MevcutCozum.ToString();
                lblFitness.Text = Knapsack.getInstance().MevcutCozum.Fitness.ToString();
                sayac++;
                Application.DoEvents();
            }
            MessageBox.Show(sayac.ToString());
        }
    }
}
