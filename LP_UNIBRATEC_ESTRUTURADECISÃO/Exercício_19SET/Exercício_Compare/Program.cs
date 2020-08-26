using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            int teste;
            
            string letra = Console.ReadLine();

            if (string.Compare(letra, "A") == 1 || string.Compare(letra, "Z") == -1)
             Console.WriteLine("Digite uma letra");
             
           /* Console.WriteLine(teste);*/
            Console.ReadKey();
        }
    }
}
