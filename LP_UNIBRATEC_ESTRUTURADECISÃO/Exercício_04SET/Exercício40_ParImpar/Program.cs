using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício40_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,numPar;

            Console.Write("Digite um número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            numPar = num1 % 2;

            if (numPar == 0)
            {
                Console.WriteLine("O número {0:D} é par", num1);
            }

            else
            {
                Console.WriteLine("O número {0:D} é ímpar", num1);
            }

            Console.ReadKey();
        }
    }
}
