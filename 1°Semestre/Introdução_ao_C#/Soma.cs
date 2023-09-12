using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    class Soma
    {
        public static void Main (string[] args)
        {
            Double num1, num2, soma;
            Console.WriteLine("Digite o primeiro número: ");    
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");    
            num2 = Double.Parse(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("A soma dos números é igual a: " + soma);
        }
    }        
}                         
