using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impar
{
    class Impar
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n<=100)
            {
             if (n % 2 == 1)
             Console.WriteLine(n);
             n++; 
            }     
        }
    }      
}            
