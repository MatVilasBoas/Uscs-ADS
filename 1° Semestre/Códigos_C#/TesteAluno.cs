using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    public class TesteAluno
    {
        static void Main(string[] args)
        {
            Aluno X1 = new Aluno();
            X1.nome = "Paulo";
            X1.codmat = 55123;
            X1.cpf = "800912345-12";
            X1.sexo = 'M';
            X1.nota_p1 = 7.0;
            X1.nota_p2 = 6.0;
            X1.nota_p3 = 8.0;

            Aluno X2 = new Aluno();
            X2.nome = "Ana";
            X2.codmat = 991239;
            X2.cpf = "500876123-15";
            X2.sexo = 'F';
            X2.nota_p1 = 2.0;
            X2.nota_p2 = 6.0;
            X2.nota_p3 = 9.0;


            X1.ImprimeAluno();
            X1.MediaAluno();
            X1.Resultado();
            X1.ImprimeSexo();
            Console.WriteLine("");
            X2.ImprimeAluno();
            X2.MediaAluno();
            X2.Resultado();
            X2.ImprimeSexo();
        }
    }
}
