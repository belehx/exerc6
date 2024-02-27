using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1;
            Console.WriteLine("Digite um número: ");

            a1= int.Parse(Console.ReadLine());

            if (a1 % 4 == 0)
            {
                Console.WriteLine("Número válido");
            }
            else
            {
                Console.WriteLine("Número Inválido");
            }


            Console.ReadKey();
        }
    }
}
