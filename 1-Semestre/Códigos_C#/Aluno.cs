using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class Aluno
    {
        public string nome;
        public int codmat;
        public string cpf;
        public char sexo;
        public double nota_p1;
        public double nota_p2;
        public double nota_p3;
        private double media;


        public void ImprimeAluno()
        {
            Console.WriteLine(nome);
            Console.WriteLine(codmat);
            Console.WriteLine(cpf);
        }
        public void ImprimeSexo()
        {
            Console.WriteLine(nome + " é");
            if (sexo == 'M')
            {
                Console.WriteLine("Masculino");
            }
            if (sexo == 'F')
            {
                Console.WriteLine("Feminino");
            }
        }
        public void MediaAluno ()
        {
           if (nota_p1 > nota_p2 && nota_p3 > nota_p2)
            {
                media = (nota_p1 + nota_p3) / 2;
            }
            else if (nota_p1 > nota_p3 && nota_p2 > nota_p3)
            {
                media = (nota_p1 + nota_p2) / 2;
            }
            else
            {
                media= (nota_p2 + nota_p3) / 2;
            }
            Console.WriteLine(media);
        }
        public void Resultado()
        {
            if (media >= 6.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
