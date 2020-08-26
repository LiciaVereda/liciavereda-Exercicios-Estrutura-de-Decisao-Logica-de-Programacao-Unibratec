using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício47_EscolaNataçãp
{
    class Program
    {
        static void Main(string[] args)
        {
            int diasAtrasado;
            double valorParcela, valorPagamento, valorJuros, percentualJuros = 0;

            Console.Write("Digite o valor da parcela: R$ ");
            valorParcela = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite os dias em atraso: ");
            diasAtrasado = Convert.ToInt32(Console.ReadLine());

            if (diasAtrasado <=30)
            {
                percentualJuros = 0.05;
            }
            else if (diasAtrasado <= 60)
            {
                percentualJuros = 0.10;
            }
            else
            {
                percentualJuros = 0.15;
            }

            valorJuros = valorParcela * percentualJuros;
            valorPagamento = valorParcela + valorJuros;

            Console.WriteLine("Os juros a serem pagos será de: R$ {0,6:F2}", valorJuros);
            Console.WriteLine("O pagamento a ser realizado será de: R$ {0,6:F2}", valorPagamento);
            Console.ReadKey();
        }
    }
}
