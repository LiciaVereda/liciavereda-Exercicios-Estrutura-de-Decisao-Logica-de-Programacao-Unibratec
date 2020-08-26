using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício45_SituaçãoVoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Qual a idade da pessoa: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if(idade < 16)
            {
                Console.WriteLine(" Não pode votar");
            }

            else if( idade >= 18 && idade <= 65)
            {
                Console.WriteLine("Voto Obrigatório");
            }

            else
            {
                Console.WriteLine("Voto Opcional");
            }

            Console.ReadKey();
        }
    }
}
