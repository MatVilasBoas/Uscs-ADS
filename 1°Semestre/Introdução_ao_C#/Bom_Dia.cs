using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomDia
{
    class BomDia
    {
        public static void Main (string[] args)
        {
            Console.Write("Olá ");
            Console.WriteLine("mundo !");
            Console.Write("Entre com seu nome: ");
            String nome = Console.ReadLine();
            Console.Write("Bom Dia, ");
            Console.Write(nome);
            Console.WriteLine("!");
        }
    }
}        
