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
        Knapsack knapsack;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHazirla_Click(object sender, EventArgs e)
        {
             knapsack = new Knapsack(Convert.ToInt32(txtElemanSayisi.Text),Convert.ToInt32(txtCantaKapasitesi.Text),cmbCaprazlamaYontemi.SelectedIndex);
             knapsack.init();
             
             lstElemanlar.Items.Clear();
            
             foreach (int i in knapsack.TumElemanlar)
                 lstElemanlar.Items.Add(i);

             txtEnIyiKromozom.Text = knapsack.MevcutCozum.ToString();
             lblFitness.Text = knapsack.MevcutCozum.Fitness.ToString();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            while (knapsack.MevcutCozum.Fitness <= (knapsack.Kapasite*99)/100)
            {
                knapsack.solve();
                txtEnIyiKromozom.Text = knapsack.MevcutCozum.ToString();
                lblFitness.Text = knapsack.MevcutCozum.Fitness.ToString();
                sayac++;
                Application.DoEvents();
            }
            MessageBox.Show(sayac.ToString());
        }
    }
}
