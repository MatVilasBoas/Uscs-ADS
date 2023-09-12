using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IguaisDiferentes
{
    class IguaisDiferentes
    {
        static void Main(string[] args)
        {
            Double num1, num2, igual;
            Console.WriteLine("Insira o primeiro numero: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            num2 = Double.Parse(Console.ReadLine());
            
            if (num1==num2)
            {
                Console.WriteLine("Os numeros sao iguais");
            }
            else
            {
                Console.WriteLine("Os numeros sao diferentes");
            }
        }
    }       
}            
