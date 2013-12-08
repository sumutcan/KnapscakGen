using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackGen
{
    public class TekNoktaCaprazlama : ICaprazlamaStratejisi
    {
        public Kromozom[] caprazla(Kromozom k1, Kromozom k2, int elemanSayisi)
        {
            int[] k11 = new int[elemanSayisi];
            int[] k12 = new int[elemanSayisi];

            Random rnd = new Random();

            int point = (rnd.Next(k1.Genler.Count() - 3) * DateTime.Now.Millisecond) % (k1.Genler.Count() - 3) + 1;
           
            Kromozom[] yeniKromozomlar = new Kromozom[2];


                for (int i = 0; i < point; i++)
                {
                    k11[i] = k1.Genler[i];
                
                }
                for (int i = point; i < elemanSayisi; i++)
                {
                     k11[i] = k2.Genler[i];
               
                }

                yeniKromozomlar[0] = new Kromozom(k11);


                for (int i = 0; i < point; i++)
                {
                    k12[i] = k2.Genler[i];

                }
                for (int i = point; i < elemanSayisi; i++)
                {
                    k12[i] = k1.Genler[i];

                }

                yeniKromozomlar[1] = new Kromozom(k12);


            return yeniKromozomlar;

            
        }
    }
}
