using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            string teste;
            int contador = 0;
         
            while (contador < 999)
            {
                Console.WriteLine("Digite um caracterer não numerico.");
                string letra = Console.ReadLine();
                teste = letra.ToUpper();
                if (letra.Length != 1)
                {
                    Console.WriteLine("Por favor, um caracter por vez.");
                    continue;
                }
                if (teste == "A" || teste == "E" || teste == "I" || teste == "O" || teste == "U")

                {
                    Console.WriteLine();
                    Console.WriteLine("O caracter é uma vogal");
                }

                else
                {
                    Console.WriteLine("Consoante, bom dia.");
                }
                contador++;
            }
            Console.ReadKey();
        }
    }
}
