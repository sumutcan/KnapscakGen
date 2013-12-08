using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackGen
{
    public class Jenerasyon
    {
        private List<Kromozom> kromozomlar;

        private List<Kromozom> ranks;

        public List<Kromozom> Kromozomlar
        {
            get { return kromozomlar; }

        }
        private Kromozom enIyiKromozom;

        public Kromozom EnIyiKromozom
        {
            get { return enIyiKromozom; }
            set { enIyiKromozom = value; }
        }

        public Jenerasyon()
        {
            kromozomlar = new List<Kromozom>();
        }

        public void eniyiKromozomBul(int kapasite)
        {
            int temp;
            int eniyi = kapasite;

            foreach (Kromozom k in kromozomlar)
            {
                temp = Math.Abs(kapasite - k.Fitness);
                if (temp < eniyi)
                {
                    eniyi = temp;
                    enIyiKromozom = k;
                }
            }

            if (enIyiKromozom == null)
                enIyiKromozom = kromozomlar.ElementAt(new Random().Next(kromozomlar.Count));


        }

        public void rankOlustur()
        {
            List<Kromozom> sirali = kromozomlar.OrderByDescending(x => x.Fitness).ToList();
            ranks = new List<Kromozom>();
            int toplamFitness = sirali.Sum(x => x.Fitness);
            foreach (Kromozom k in sirali)
            {
                int limit = 100-Math.Abs((int)(((double)(Knapsack.getInstance().Kapasite-k.Fitness) / toplamFitness) * 100));
                for (int i = 0; i < limit; i++)
                    ranks.Add(k);
            }

            if (ranks.Count() == 0)
                Console.WriteLine("asdasd");
        }

        public bool caprazlamaMi()
        {
            Random rnd = new Random();

            Double p = rnd.NextDouble();

            if (p < 0.9)
                return true;
            else
                return false;

        }

        public Kromozom[] caprazlamaKromozomlariSec()
        {
            Kromozom[] ebeveynler = new Kromozom[2];

            for (int i = 0; i < 2; i++)
            {

                Random rnd = new Random();
                int index = rnd.Next(ranks.Count);
                
                ebeveynler[i] = this.ranks[index];

                int dc = ranks.Distinct().Count();
                
              
                ranks.RemoveAll(x => x.Genler.Equals(this.ranks[index].Genler));

            }

                
            return ebeveynler;
            

        }

        public void mutasyon()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            if (rnd2.NextDouble() < 0.1)
            {
                int index = rnd.Next(Kromozomlar.Count);
                Random r = new Random();
                int genIndex = r.Next(Knapsack.getInstance().TumElemanlar.Count());
                
                if (Kromozomlar[index].Genler[genIndex] == 0)
                    Kromozomlar[index].Genler[genIndex] = Knapsack.getInstance().TumElemanlar[genIndex];
                
                    
                
            }
        }
    }
}
