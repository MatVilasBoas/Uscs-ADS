using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Exercicio1
    {
        /* 
        Fazer método que recebe um vetor de número inteiros e retorna a soma dos
        números impares.
        */
        static void Main(string[] args)
        {
            int[] v = { 102, 57, 78, 23, 39 };
            int[] impares = new int[5];

            for (int i = 0; i < 5; i++)
            {
                if (v[i] % 2 == 1)
                {
                    impares[i] = v[i];
                }
            }

            int resultado = SomaImpar(impares);
            Console.WriteLine("A soma dos numeros impares é de: " + resultado);
        }

        public static int SomaImpar (int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                soma = soma + vetor[i];
            }
            return soma;
        }
    }
}
