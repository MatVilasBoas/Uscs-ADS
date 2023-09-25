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
            Escrever um programa na Linguagem C# que permita a leitura das notas de uma
            turma de 10 alunos. Calcular a média da turma e contar quantos alunos obtiveram
            nota acima desta média calculada. Escrever a média da turma e o resultado da
            contagem.
            */
            double[] notas = new double[10];
            double soma = 0;
            int acimaDaMedia = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Digite a nota do aluno.");
                notas[i] = double.Parse(Console.ReadLine());
                if (notas[i] >= 5) { acimaDaMedia++; }
            }
            for (int i = 0; i < notas.Length; i++)
            {
                soma = soma + notas[i];
            }
            double media = Media(soma, notas);
            Console.WriteLine("RESULTADOS: ");
            Console.WriteLine("Media da Sala: " + media);
            Console.WriteLine("Numero de Alunos acima da media: " + acimaDaMedia);

        }
        public static double Media(double soma, double[] notas)
        {
            double media = soma / notas.Length;
            return media;
        }
    }
}
