using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite um número inteiro:");
            a = int.Parse(Console.ReadLine());

            if (a % 4 == 0)
            {
                Console.WriteLine();
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Número inválido.");
            }
            Console.ReadKey();
        }
    }
}

