using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackGen
{
    public class Kromozom
    {
        private int[] genler;

        public int[] Genler
        {
            get { return genler; }
            
        } 
        private int fitness;
        

        public int Fitness
        {
            get { return fitness; }
            set { fitness = value; }
        }

        public Kromozom(bool[] genHaritasi, int[] tumElemanlar, int kapasite)
        {
            genler = new int[genHaritasi.Length];
            Program.tumElemanlar = tumElemanlar;
            for (int i = 0; i < genHaritasi.Length; i++)
            {
                if (genHaritasi[i])
                    genler[i] = tumElemanlar[i];
                else
                    genler[i] = 0;
            }

            Random rnd = new Random();
            do
            {
                fitnessHesapla();

                if (fitness > kapasite)
                {
                    int a = rnd.Next(genler.Length);
                    if (genler[a] > 0)
                        genler[a] = 0;
                }

            } while (fitness > kapasite);


        }

        public Kromozom()
        {
            
        }

        public Kromozom(int[] genler)
        {
            // TODO: Complete member initialization
            this.genler = genler;

            Random rnd = new Random();
            do
            {
                fitnessHesapla();

                if (fitness > Program.kapasite)
                {
                    int a = rnd.Next(genler.Length);
                    if (genler[a] > 0)
                        genler[a] = 0;
                }

            } while (fitness > Program.kapasite);

        }

        private void fitnessHesapla()
        {
            fitness = genler.Sum();
        }
        public override string ToString()
        {
            string str = "";

            foreach (int i in genler)
                str += i + " ";
            
            return str;
        }
    }
}
