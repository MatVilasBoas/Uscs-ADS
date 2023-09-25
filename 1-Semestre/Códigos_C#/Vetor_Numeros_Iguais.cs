using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /*
    Faça um programa que leia um vetor de 10 posições e verifique se existem valores
    iguais e os escreva na tela.
    */
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int[] v = new int [10];

            Console.WriteLine("Digite 10 numeros: \n");
            for (int i = 0; i < 10; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numeros: ");
            for (int i = 0; i < 10; i++)
            {
                if (v[i] < 0)
                {
                    v[i] = 0;
                }
            Console.WriteLine(v[i]);
            }
        }
    }
}
