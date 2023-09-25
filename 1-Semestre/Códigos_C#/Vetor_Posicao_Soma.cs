using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /*
    Faça um programa que leia um vetor de 8 posições e, em seguida, leia também dois
    valores X e Y quaisquer correspondentes a duas posições no vetor. Ao final seu
    programa deverá escrever a soma dos valores encontrados nas respectivas posições X
    e Y.
    */
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int[] num = new int[8];

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Digite um valor real: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            int soma = num[3] + num[7];
            Console.WriteLine("A soma dos numeros da quarta e oitava posição é: " + soma);
        }
    }
}
