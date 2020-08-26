using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_05SET
{
    class Program
    {
        static void Main(string[] args)
        {
            int votosCand1, votosCand2, votosCand3;

            Console.Write("Digite os votos obtidos pelo candidato 1: ");
            votosCand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite os votos obtidos pelo candidato 2: ");
            votosCand2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite os votos obtidos pelo candidato 3: ");
            votosCand3 = Convert.ToInt32(Console.ReadLine());


            if ((votosCand1 < (votosCand2 + votosCand3)) && (votosCand2 < (votosCand1 + votosCand3)) && (votosCand3 < (votosCand1 + votosCand2)))
            {
                Console.WriteLine("Haverá segundo turno!!");

            }

            else
            {
                Console.WriteLine("Não haverá segundo turno!!");
            }
           
            Console.ReadKey();

        }
    }
}
