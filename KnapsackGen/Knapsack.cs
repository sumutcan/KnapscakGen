using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackGen
{
    public class Knapsack
    {
        private int elemanSayisi;

        public int ElemanSayisi
        {
            get { return elemanSayisi; }
            set { elemanSayisi = value; }
        }
        private int kapasite;

        public int Kapasite
        {
            get { return kapasite; }
            set { kapasite = value; }
        }
        private int[] tumElemanlar;
        private Kromozom mevcutCozum;

        public Kromozom MevcutCozum
        {
            get { return mevcutCozum; }
            set { mevcutCozum = value; }
        }
        private Jenerasyon simdikiJenerasyon;
        private ICaprazlamaStratejisi caprazlamaStratejisi;
        private static Knapsack instance = null;

        public int[] TumElemanlar
        {
            get { return tumElemanlar; }
            set { tumElemanlar = value; }
        }


        private Knapsack(int elemanSayisi, int kapasite, int strateji)
        { 
            this.elemanSayisi = elemanSayisi;
            this.kapasite = kapasite;
            tumElemanlar = new int[elemanSayisi];
            simdikiJenerasyon = new Jenerasyon();
            caprazlamaStratejisi = Mendel.caprazlamaStratejisiUret(strateji);
            mevcutCozum = new Kromozom();
            mevcutCozum.Fitness = kapasite;
           
        }

        public static Knapsack getInstance(int elemanSayisi, int kapasite, int strateji)
        {
            if (instance == null)
                instance = new Knapsack(elemanSayisi, kapasite, strateji);

            return instance;
        }

        public static Knapsack getInstance()
        {
            return instance;
        }

        public void init()
        {
            Random rnd = new Random();
            simdikiJenerasyon = new Jenerasyon();

            for (int i = 0; i < elemanSayisi; i++ )
                tumElemanlar[i] = rnd.Next((kapasite*3)/4)+1;

            ilkJenerasyonOlustur();
        }
        public void init(bool ready)
        {
            if (ready)
                ilkJenerasyonOlustur();
        }

        public void ilkJenerasyonOlustur()
        {
            bool[] genHaritasi = new bool[elemanSayisi];

            Random rnd = new Random();
            for (int i = 0; i < elemanSayisi; i++)
            {
                for (int j = 0; j < elemanSayisi; j++)
                {

                    if (Math.Round(rnd.NextDouble()) == 1)
                        genHaritasi[j] = true;
                    else
                        genHaritasi[j] = false;

                }
                Kromozom k = new Kromozom(genHaritasi, tumElemanlar, kapasite);
                if (!simdikiJenerasyon.Kromozomlar.Contains(k))
                    simdikiJenerasyon.Kromozomlar.Add(k);
                else
                    i--;
            }

            simdikiJenerasyon.eniyiKromozomBul(kapasite);
            mevcutCozum = simdikiJenerasyon.EnIyiKromozom;
            
                
            
        }

        public void yeniJenerasyonOlustur()
        {
            
            Jenerasyon yeniJenerasyon = new Jenerasyon();
            simdikiJenerasyon.rankOlustur();
            while (simdikiJenerasyon.Kromozomlar.Count > 0)
            {
                
                Kromozom[] ebeveynler = simdikiJenerasyon.caprazlamaKromozomlariSec();
                if (simdikiJenerasyon.caprazlamaMi())
                    yeniJenerasyon.Kromozomlar.AddRange(caprazlamaStratejisi.caprazla(ebeveynler[0], ebeveynler[1], elemanSayisi));
                else
                    yeniJenerasyon.Kromozomlar.AddRange(ebeveynler);

                simdikiJenerasyon.Kromozomlar.Remove(ebeveynler[0]);
                simdikiJenerasyon.Kromozomlar.Remove(ebeveynler[1]);
            }

            yeniJenerasyon.mutasyon();
            simdikiJenerasyon = yeniJenerasyon;
            simdikiJenerasyon.eniyiKromozomBul(kapasite);

           

            if (Math.Abs(kapasite - simdikiJenerasyon.EnIyiKromozom.Fitness) < Math.Abs(kapasite - mevcutCozum.Fitness))
                mevcutCozum = simdikiJenerasyon.EnIyiKromozom;
        }




        public void solve()
        {

            yeniJenerasyonOlustur();
        }

        public static void reset()
        {

            instance = null;
        }
    }
}
