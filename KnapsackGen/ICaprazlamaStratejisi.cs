using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackGen
{
    public interface ICaprazlamaStratejisi
    {
        Kromozom[] caprazla(Kromozom k1, Kromozom k2, int elemanSayisi);
    }
}
