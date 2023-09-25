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
            string nome;
            double sfixo, vendas;
            Console.WriteLine("Digite o Nome do Vendedor: ");
            nome = (Console.ReadLine());
            Console.WriteLine("Digite o Salario Fixo: ");
            sfixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Total de vendas no mês: ");
            vendas = double.Parse(Console.ReadLine());
            double comissao = vendas * 0.20;
            double stotal = sfixo + comissao;
            Console.WriteLine("Nome do Vendedor: " + nome);
            Console.WriteLine("Salario Fixo: " + sfixo);
            Console.WriteLine("Salario total: " + stotal);
        }
    }
}
