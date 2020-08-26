using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício38_JurosDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            const double juros = 0.004, desconto = 0.05;
            const int diaVencimento = 5;
            double valorParcela, valorJuros, valorDesconto, valorPagamento;
            int diaPagamento, diaAtrasado;


            Console.Write("Qual o valor da parcela a ser paga: R$ ");
            valorParcela = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual o dia que o pagamento foi efetuado: ");
            diaPagamento = Convert.ToInt32(Console.ReadLine());

            if (diaPagamento > diaVencimento)
            {
                diaAtrasado = diaPagamento - diaVencimento;
                valorJuros = juros * diaAtrasado;
                valorPagamento = valorParcela + valorJuros;

                Console.WriteLine("Os dias em atraso foram de: {0:D} dias ", diaAtrasado);
                Console.WriteLine("O valor dos juros foi de: R$ {0,7:F4}", valorJuros);
                Console.WriteLine("O novo valor da parcela será de: R$ {0,7:F4}", valorPagamento);

            }

            else 
            {
                valorDesconto = desconto * valorParcela;
                valorPagamento = valorParcela - valorDesconto;
                Console.WriteLine("O valor do desconto foi de: R$ {0,7:F4}", valorDesconto);
                Console.WriteLine("O novo valor da parcela será de: R$ {0,7:F4}", valorPagamento);

            }

            Console.ReadKey();
        }
    }
}
