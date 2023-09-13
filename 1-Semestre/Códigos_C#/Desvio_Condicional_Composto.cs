using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desvio
{
    class Desvio
    {
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("{0} é maior que {1}", x, y);
            }
            else
            {
                Console.WriteLine("{0} é maior que {1}", y, x);
            }
        }
    }         
}            
