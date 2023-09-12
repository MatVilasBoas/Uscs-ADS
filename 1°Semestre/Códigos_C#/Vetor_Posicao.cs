using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorPosicao
{
    public class VetorPosicao
    {
        static void Main()
        {
            int [] v = { 102, 57, 78, 23, 39, 41, 7, 14, 23, 84 };
            int i;
            for (i=0; i<10; i++)
            {
                if (v[i] > 50)
                {
                    Console.Write ("Posiçao: " + i);
                    Console.WriteLine ("Valor: {0} ", v[i]);
                }
            }
        }
    }
}  
    }
  }
