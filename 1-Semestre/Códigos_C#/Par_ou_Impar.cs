using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    class ParImpar
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite o número: ");    
            n = int.Parse(Console.ReadLine());
            if (n%2 == 0)
            {
                Console.WriteLine("O número " + n + " é Par");
            }
            else
            {
                Console.WriteLine("O número " + n + " é Ímpar");
            }
        }
    }        
}           
