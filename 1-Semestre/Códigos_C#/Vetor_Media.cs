using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /* 
    Faça um programa para ler a nota da prova de 15 alunos e armazene num vetor,
    calcule e imprima a média geral.        
    */
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int[] notas = new int[15];
            int total = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite uma nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 15; i++)
            {
                total = total + notas[i];
            }
            double media = total / 15;
            Console.WriteLine("A media dos alunos é de: " + media);

        }
    }
}
