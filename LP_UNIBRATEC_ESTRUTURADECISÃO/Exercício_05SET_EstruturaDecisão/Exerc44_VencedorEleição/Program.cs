using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc44_VencedorEleição
{
    class Program
    {
        static void Main(string[] args)
        {
            string cand1, cand2, cand3;
            int votosCand1, votosCand2, votosCand3;


            Console.Write("Digite o nome do primeiro candidato: ");
            cand1 = Console.ReadLine();
            Console.Write("Digite os votos obtidos pelo candidato 1: ");
            votosCand1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do segundo candidato: ");
            cand2 = Console.ReadLine();
            Console.Write("Digite os votos obtidos pelo candidato 2: ");
            votosCand2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do terceiro candidato: ");
            cand3 = Console.ReadLine();
            Console.Write("Digite os votos obtidos pelo candidato 3: ");
            votosCand3 = Convert.ToInt32(Console.ReadLine());


            if ((votosCand1 > votosCand2) && (votosCand1 > votosCand3))
            {
                Console.WriteLine("O candidato vencedor é: " + cand1);
            }

            else if ((votosCand2 > votosCand1) && (votosCand2 > votosCand3))
            {
                Console.WriteLine("O candidato vencedor é: " + cand2);
            }

            else
            {
                Console.WriteLine("O candidato vencedor é: " + cand3);
            }

            Console.ReadKey();



        }
    }
}
