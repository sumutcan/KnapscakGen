using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace KnapsackGen
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        bool done = false;
        string fitness = "0";
        string enIyi = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        int maksimumIterasyonSayisi;
        private int basariYuzdesi;

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

                basariYuzdesi = Convert.ToInt32(txtBasariYuzdesi.Text);
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
            
            Thread t = new Thread(new ThreadStart(Solve));
            t.Start();
            btnBaslat.Enabled = false;
            btnHazirla.Enabled = false;
            

            while (!done)
            {
                //t.Join(1000);
                lblSuankiIterasyon.Text = sayac.ToString();
                txtEnIyiKromozom.Text = enIyi;
                lblFitness.Text = fitness;
                Application.DoEvents();
            }
            lblSuankiIterasyon.Text = sayac.ToString();
            txtEnIyiKromozom.Text = enIyi;
            lblFitness.Text = fitness;
            Application.DoEvents();
            btnHazirla.Enabled = true;
            done = false;
            sayac = 0;
        }

        private void Solve()
        {
           
            while (Math.Abs(Knapsack.getInstance().Kapasite - Knapsack.getInstance().MevcutCozum.Fitness) > Math.Abs(Knapsack.getInstance().Kapasite - ((Knapsack.getInstance().Kapasite * Convert.ToInt32(basariYuzdesi)) / 100)) && sayac <= maksimumIterasyonSayisi)
            {

                Knapsack.getInstance().solve();
                enIyi = Knapsack.getInstance().MevcutCozum.ToString();
                fitness = Knapsack.getInstance().MevcutCozum.Fitness.ToString();
                sayac++;

            }
            done = true;
            
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
