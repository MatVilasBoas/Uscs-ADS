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
            int copias;
            Console.WriteLine("Digite o numero de copias: ");
            copias = int.Parse(Console.ReadLine());

            if (copias <= 200)
            {
                double resultado = copias * 0.50;
                Console.WriteLine("{0} Cópias são R$: {1}.", copias, resultado);

            }
            else
            {
                copias = copias - 200;
                double resultado = (copias * 0.30) + 100;
                Console.WriteLine("{0} Cópias são R$: {1}.", copias, resultado);
            }
        }
    }
}
