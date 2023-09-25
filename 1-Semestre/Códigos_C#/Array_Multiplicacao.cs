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
            /*
            Escrever um programa com a Linguagem C# para Ler um array A de 10 números.
            Em seguida, ler mais um número e armazená-lo em uma variável X. Armazenar em
            um array M o resultado de cada elemento de A multiplicado pelo valor X. Logo após,
            exibir na console todos os elementos do array M.
            */
            int[] A = new int[10];
            int[] M = new int[10];

            Console.WriteLine("Digite {0} numeros para ser armazenado em A: ", A.Length);
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite um numero para ser o X.");
            int X = int.Parse(Console.ReadLine());
            for (int i = 0; i < A.Length; i++)
            {
                M[i] = A[i] * X;
            }
            Console.WriteLine("Array M abaixo: ");
            for (int i = 0; i < M.Length; i++)
            {
                Console.WriteLine(M[i]);
            }

        }
    }
}
