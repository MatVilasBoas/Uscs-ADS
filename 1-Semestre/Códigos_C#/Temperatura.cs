using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            double tempF = double.Parse(Console.ReadLine());

            double tempC = ((tempF - 32) * 5) / 9;

            Console.WriteLine("A temperatura é de: {0}ºC", tempC);
        }
    }
}
