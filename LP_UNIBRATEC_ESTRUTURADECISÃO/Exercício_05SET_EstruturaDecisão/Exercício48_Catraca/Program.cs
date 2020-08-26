using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício48_Catraca
{
    class Program
    {
        static void Main(string[] args)
        {
            const double passagem = 4.50;
            double valorApurado=0;
            int numeroInicialCatraca, numeroFinalCatraca, qtdePassageiros=0;

            Console.Write("Digite o número inicial da catraca: ");
            numeroInicialCatraca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número final da catraca: ");
            numeroFinalCatraca = Convert.ToInt32(Console.ReadLine());

            if (numeroFinalCatraca < 999999)
            {
                qtdePassageiros = (numeroFinalCatraca - numeroInicialCatraca);
                    if (qtdePassageiros < 0)
                    {
                        qtdePassageiros = (numeroFinalCatraca - numeroInicialCatraca) + numeroInicialCatraca; 
                    }
             
                valorApurado = qtdePassageiros * passagem;
            }

            Console.WriteLine("A quantidade de passageiros é: {0:d}", qtdePassageiros);
            Console.WriteLine("O valor apurado com as passagens foi de: {0,4:N2}",valorApurado);
            Console.ReadKey();



        }
    }
}
