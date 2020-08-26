using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício39_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisorMedia = 2;
            double nota1, nota2, nota3, media, maiorValor, segundoMaiorValor;
            maiorValor = 0;
            segundoMaiorValor = 0;

            Console.Write("Digite a primeira nota do aluno: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            nota2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite a terceira nota do aluno: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

      
             if((nota1>nota2) && (nota1 > nota3)) 
              {
                  if (nota2 > nota3)
                  {
                      segundoMaiorValor = nota2;
                  }

                maiorValor = nota1;
             }

             if((nota2>nota1) && (nota2 > nota3))
             {
                  if (nota1 > nota3)
                  {
                      segundoMaiorValor = nota1;
                  }
                maiorValor = nota2;
             }

              if((nota3>nota1) && (nota3 > nota2)) 
  
              {
                  maiorValor = nota3;

                  if (nota1 > nota2)
                  {
                      segundoMaiorValor = nota1;
                  }

                else
                {
                    segundoMaiorValor = nota2;
                }

              }
             
            media = (maiorValor + segundoMaiorValor) / divisorMedia;
            Console.WriteLine(media);
            Console.ReadKey();



        }
    }
}
