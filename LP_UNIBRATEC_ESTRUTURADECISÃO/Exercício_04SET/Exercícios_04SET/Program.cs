using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_04SET
{
    class Program
    {
        static void Main(string[] args)
        {
            const double juros = 0.004;
            double valorParcela, valorJuros, valorTotalPagamento;
            int diaVencimento, diaPagamento, diaAtrasado;


            Console.Write("Digite o valor da parcela: R$ ");
            valorParcela = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o dia do vencimento: ");
            diaVencimento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o dia do pagamento: ");
            diaPagamento = Convert.ToInt32(Console.ReadLine());

            if (diaVencimento < diaPagamento)
            {
                diaAtrasado = diaPagamento - diaVencimento;
                valorJuros = juros * diaAtrasado;
                valorTotalPagamento = valorParcela + valorJuros;

                Console.WriteLine("");
                Console.WriteLine("Os dias de atraso desta parcela foi de : {0:D} dias",diaAtrasado);
                Console.WriteLine("Os juros a serem pagos é de : R$ {0,7:F4}",valorJuros);
                Console.WriteLine("O valor total deste pagamento é : R${0,7:F4}  ", valorTotalPagamento);

            }

            else
            {
                valorTotalPagamento = valorParcela;
                Console.WriteLine("O valor total deste pagamento é : R${0,7:F4}  ", valorTotalPagamento);
            }

            Console.ReadKey();
            
        }
    }
}
