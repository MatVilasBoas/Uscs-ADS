using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoQuadrado
{
    class CalculoQuadrado
    {
        public static void Main (string[] args)
        {
            double num1, area;
            Console.WriteLine("Digite o valor do lado do quadrado: ");
            num1=Double.Parse(Console.ReadLine());
            area = num1 * num1;
            Console.WriteLine("A área do quadrado é: " + area);
        }
    }        
}             
