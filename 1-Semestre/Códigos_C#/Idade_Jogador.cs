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
            int idade;
            Console.WriteLine("Informe a Idade do jogador: ");
            idade = int.Parse(Console.ReadLine());

            switch (idade)
            {
                case <= 13:
                    Console.WriteLine("Infantil");
                    break;
                case <= 17:
                    Console.WriteLine("Juvenil");
                    break;
                case > 17:
                    Console.WriteLine("Senior");
                    break; 
            }
        }
    }
}
