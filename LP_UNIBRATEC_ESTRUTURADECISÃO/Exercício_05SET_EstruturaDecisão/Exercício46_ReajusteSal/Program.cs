using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício46_ReajusteSal
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoServiço;
            double salarioFunc, salarioReajustado, percentualAumento = 0;

            Console.Write("Digite o salário atual do funcionário: R$ ");
            salarioFunc = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tempo de serviço do funcionário em anos: ");
            tempoServiço = Convert.ToInt32(Console.ReadLine());

            if((tempoServiço > 10) && (salarioFunc > 3000))
            {
                percentualAumento = 0.10;
               
            }
            else if ((tempoServiço <= 9) && (salarioFunc > 3000))
            {
                percentualAumento = 0.08; 
            }
            else
            {
                percentualAumento = 0.05;  
            }
            salarioReajustado = salarioFunc + (salarioFunc * percentualAumento);
            Console.WriteLine();
            Console.WriteLine("O novo salário do funcionário é: R$ {0,6:F2}",salarioReajustado);
            Console.ReadKey();

        }
    }
}
