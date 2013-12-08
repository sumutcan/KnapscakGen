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

        private void btnHazirla_Click(object sender, EventArgs e)
        {
             Knapsack.getInstance(Convert.ToInt32(txtElemanSayisi.Text),Convert.ToInt32(txtCantaKapasitesi.Text),cmbCaprazlamaYontemi.SelectedIndex);
             Knapsack.getInstance().init();
             
             lstElemanlar.Items.Clear();
            
             foreach (int i in Knapsack.getInstance().TumElemanlar)
                 lstElemanlar.Items.Add(i);

             txtEnIyiKromozom.Text = Knapsack.getInstance().MevcutCozum.ToString();
             lblFitness.Text = Knapsack.getInstance().MevcutCozum.Fitness.ToString();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            while ((Knapsack.getInstance().Kapasite - Knapsack.getInstance().MevcutCozum.Fitness) <= Knapsack.getInstance().Kapasite)
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
