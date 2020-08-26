using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para receber o peso e a altura de 8 pessoas.
            Criticar para não receber valores negativos.

            Para cada pessoa mostrar:
            -IMC
            - Situação:

            ICM Situação
            Abaixo de 17 Muito abaixo do peso
            Entre 17 e 18,49 Abaixo do peso
            Entre 18,5 e 24,99 Peso normal
            Entre 25 e 29,99 Acima do peso
            Entre 30 e 34,99 Obesidade I
            Entre 35 e 39,99 Obesidade II (severa)
            Acima de 40 Obesidade III (mórbida)

            No final mostrar a quantidade de pessoas que estão com algum situação de obesidade e a quantidade de pessoas que estão em alguma situação de abaixo do peso.
            */

            double peso, altura, IMC;
            int situacaoObesidade, situacaoAbaixoPeso,contador=1,contadorAbaixoPeso=0, contadorObesidade=0;

            while(contador <= 8)
            {
                Console.WriteLine("");
                Console.Write("Digite o peso da pessa {0}° pessoa: ", contador);
                peso = Convert.ToDouble(Console.ReadLine());

                if (peso < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Peso inválido.Digite valores positivos");
                    continue;
                }

                Console.Write("Digite a altura da pessa {0}° pessoa: ", contador);
                altura = Convert.ToDouble(Console.ReadLine());

                if (peso < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Peso inválido.Digite valores positivos");
                    continue;
                }

                IMC = peso / (altura * altura);

                if (IMC <= 17)
                {
                    Console.WriteLine("SITUAÇÃO: Muito abaixo do peso");
                    Console.WriteLine("Seu IMC é: {0:F2}", IMC);
                    contadorAbaixoPeso++;
                }

                else if (IMC < 18.49)
                {
                    Console.WriteLine("SITUAÇÃO: abaixo do peso");
                    Console.WriteLine("Seu IMC é: {0:F2}", IMC);
                    contadorAbaixoPeso++;
                }

                else if (IMC < 24.99)
                {
                    Console.WriteLine("SITUAÇÃO: Peso normal");
                    Console.WriteLine("Seu IMC é: {0:F2}", IMC);
                }
                else if (IMC < 29.99)
                {
                    Console.WriteLine("SITUAÇÃO: Acima do peso");
                    Console.WriteLine("Seu IMC é: {0:F2}", IMC);
                }
                else if (IMC < 35.99)
                {
                    Console.WriteLine("SITUAÇÃO: Obesidade grau I");
                    Console.WriteLine("Seu IMC é: {0:F2}", IMC);
                    contadorObesidade++;
                }
                else if (IMC < 39.99)
                {
                    Console.WriteLine("SITUAÇÃO: Obesidade grau II (SEVERA)");
                    Console.WriteLine("Seu IMC é: {0:F2}", IMC);
                    contadorObesidade++;
                }
                else 
                {
                    
                    Console.WriteLine("SITUAÇÃO: Obesidade grau III (MÓRBIDA)");
                    Console.WriteLine("Seu IMC é: {0:F2}", IMC);
                    contadorObesidade++;
                }
                contador++;

            }
            Console.WriteLine("");
            Console.WriteLine("A quantidade de pessoas em situação ABAIXO DO PESO são {0}", contadorAbaixoPeso);
            Console.WriteLine("A quantidade de pessoas em situação ABAIXO DO PESO são {0}", contadorObesidade); ;
            Console.ReadKey();




















        }
    }
}
