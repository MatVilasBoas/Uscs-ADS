using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /*
    Em uma eleição presidencial, existem dois candidatos. Os votos são informados
    através de código. Os dados utilizados obedecem à seguinte codificação:
    */
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0, branco = 0, nulo = 0;
            for (int i = 0; i > -1; i++)
            {
                Console.WriteLine(" 1  - CANDIDATO A");
                Console.WriteLine(" 2  - CANDIDATO B");
                Console.WriteLine(" 3  - BRANCO \n");
                Console.WriteLine(" 4  - Encerrar Votação");

                Console.Write("Digite a sua Escolha: ");
                bool sucesso = int.TryParse(Console.ReadLine(), out int opc);

                switch(opc)
                {
                    case 1:
                        A++;
                        break;
                    case 2:
                        B++;
                        break;
                    case 3:
                        branco++;
                        break;
                    case 4:
                        Console.WriteLine("\n RESULTADOS: ");
                        Console.WriteLine("Total de Votos para o CANDIDATO A: " + A);
                        Console.WriteLine("Total de Votos para o CANDIDATO B: " + B);
                        Console.WriteLine("Total de Votos brancos: " + branco);
                        Console.WriteLine("Total de Votos nulos: " + nulo);
                        Console.WriteLine("Total de Votos lidos: " + i);
                        if (A > B) Console.WriteLine("CANDIDATO VENCEDOR: CANDIDATO A ");
                        if (B > A) Console.WriteLine("CANDIDATO VENCEDOR: CANDIDATO B ");
                        i = -2;
                        break;
                    default:
                        nulo++;
                        break;
                }
            }

        }
    }
}
