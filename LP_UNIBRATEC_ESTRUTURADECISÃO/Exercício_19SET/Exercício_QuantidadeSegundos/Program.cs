using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_QuantidadeSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            string horario="";
            int hora=0, minuto=0, segundo=0 ,segundoTotal;
           
          

            while (true)
            {   
                Console.Write("Digite um horário no formato HH:MM:SS ");
                horario = Console.ReadLine();

                if (horario.Length != 8)
                {
                    Console.WriteLine("Digite o horário no formato correto");
                    continue;
                }

                try
                {

                    hora = Convert.ToInt32(horario.Substring(0, 2));
                    minuto = Convert.ToInt32(horario.Substring(3, 2));
                    segundo = Convert.ToInt32(horario.Substring(6, 2));

                }

                catch
                {
                    Console.WriteLine("Horário Inválido! Digite valores numéricos");
                    continue;
                }

                      
                if (hora < 00 || hora > 23 )
                {
                    Console.WriteLine("Digite a hora no formato correto");
                    continue;
                }

                else if(minuto < 00 || minuto > 59)
                {
                    Console.WriteLine("Digite os minutos no formato correto");
                    continue;

                }
                
                else if(segundo < 00 || segundo > 59)
                {
                    Console.WriteLine("Digite os segundos no formato correto");
                    continue;

                }
                else if(horario.Substring(3,1)!=":" || horario.Substring(6, 1) != ":")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Digite o dígito no formato correto");
                    continue;

                }
                segundoTotal = (hora * 3600) + (minuto * 60) + segundo;
                Console.WriteLine("A quantidade de horas em segundos {0}", segundoTotal);
                break;
            
            }
            
            Console.ReadKey();
            

        }
    }
}
