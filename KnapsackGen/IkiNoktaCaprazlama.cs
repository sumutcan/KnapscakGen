using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackGen
{
    public class IkiNoktaCaprazlama : ICaprazlamaStratejisi
    {
        public Kromozom[] caprazla(Kromozom k1, Kromozom k2, int elemanSayisi)
        {
            Random r = new Random(0);
            int kapasite = k1.Genler.Count();

            int[] k11 = new int[kapasite];
            int[] k12 = new int[kapasite];

            int pointOne = Math.Abs((r.Next() * DateTime.Now.Millisecond) % kapasite);

            int pointTwo = pointOne;

            while (pointTwo == pointOne)
            {
                pointTwo = Math.Abs((r.Next() * DateTime.Now.Millisecond) % kapasite);
            }

            if (isBuyukSayi(pointOne, pointTwo))
            {
                int temp = pointOne;
                pointOne = pointTwo;
                pointTwo = temp;
            }


            Kromozom[] yeniKromozomlar = new Kromozom[2];


            for (int i = pointOne; i < pointTwo; i++)
            {
                k11[i] = k1.Genler[i];

            }
            for (int i = 0; i < pointOne; i++)
            {
                k11[i] = k2.Genler[i];

            }
            for (int i = pointTwo; i < kapasite; i++)
            {
                k11[i] = k2.Genler[i];

            }

            yeniKromozomlar[0] = new Kromozom(k11);

            for (int i = pointOne; i < pointTwo; i++)
            {
                k12[i] = k2.Genler[i];

            }
            for (int i = 0; i < pointOne; i++)
            {
                k12[i] = k1.Genler[i];

            }
            for (int i = pointTwo; i < kapasite; i++)
            {
                k12[i] = k1.Genler[i];

            }

            yeniKromozomlar[1] = new Kromozom(k12);

            return yeniKromozomlar;
        }

        public bool isBuyukSayi(int val1, int val2)
        {
            if (val1 > val2)
                return true;
            return false;
        }
    }
}
