using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorMenor
{
    class MaiorMenor
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Insira o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O maior numero é: " + num1);
            }
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("O maior numero é: " + num2);
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("O maior numero é: " + num3);
            }
            if (num1<num2 && num1<num3)
            {
                Console.WriteLine("O menor numero é: " + num1);
            }
            if (num2<num1 && num2<num3)
            {
                Console.WriteLine("O menor numero é: " + num2);
            }
            if (num3<num1 && num3<num2)
            {
                Console.WriteLine("O menor numero é: " + num3);
            }
        } 
    }       
}                     
