using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackGen
{
    public class BirlesikCaprazlama : ICaprazlamaStratejisi
    {
        public Kromozom[] caprazla(Kromozom k1, Kromozom k2, int elemanSayisi)
        {
            Random r = new Random(0);
            int kapasite = k1.Genler.Count();

            int[] k11 = new int[kapasite];
            int[] k12 = new int[kapasite];

            for (int i = 0; i < kapasite; i++)
            {
                bool goWithFirstOne = (Math.Abs((r.Next() * DateTime.Now.Millisecond) % 2)) == 0 ? true:false;

                if (goWithFirstOne)
                {
                    k11[i] = k1.Genler[i];
                    k12[i] = k2.Genler[i];
                }
                else
                {
                    k11[i] = k2.Genler[i];
                    k12[i] = k1.Genler[i];
                }

            }

            Kromozom[] yeniKromozomlar = new Kromozom[2];
            yeniKromozomlar[0] = new Kromozom(k11);
            yeniKromozomlar[1] = new Kromozom(k12);

            return yeniKromozomlar;
        }
    }
}
