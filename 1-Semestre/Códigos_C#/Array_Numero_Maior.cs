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
            Escrever um programa com a Linguagem C# para ler um array Q de 10 posições
            (aceitar somente números positivos). Em seguida, exibir na console o valor do maior
            elemento de Q e a respectiva posição por ele ocupada no array.
            */
            int[] Q = new int[10];
            int maior = 0;
            int maiorI = 0;

            for (int i = 0; i < Q.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                Q[i] = int.Parse(Console.ReadLine());
                if(Q[i] < 0) { Q[i] = 0;}
                if(Q[i] > maior) {
                    maior = Q[i];
                    maiorI = i + 1;
                }
            }
            Console.WriteLine("O Maior numero no vetor é: {0} e na {1}º posição.", maior, maiorI);

        }
    }
}
