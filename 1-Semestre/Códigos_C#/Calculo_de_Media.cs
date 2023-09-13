using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Media
    {
        public static void Main (string[] args)
        {
            double nota, somanota = 0;
            int i = 1;

            Console.Write("Digite sua nota: ");
            nota = double.Parse(Console.ReadLine());
            while (nota != -1)
            {
                somanota = somanota + nota;
                Console.Write("Digite sua nota: ");
                nota = double.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine(somanota / i);
        }
    }        
}
