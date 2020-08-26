using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_DiferençaDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            string data1, data2;
            int diferenca,diaData1, diaData2, mesData1, mesData2, anoData1, anoData2,totalData1, totalData2;

            Console.WriteLine("Digite data 1 ");
            data1 = Console.ReadLine();
            Console.WriteLine("Digite data 2 ");
            data2 = Console.ReadLine();

            diaData1 = Convert.ToInt32(data1.Substring(0, 2));
            diaData2 = Convert.ToInt32(data2.Substring(0, 2));
            mesData1 = Convert.ToInt32(data1.Substring(3, 2));
            mesData2 = Convert.ToInt32(data2.Substring(3, 2));
            anoData1 = Convert.ToInt32(data1.Substring(6, 4));
            anoData2 = Convert.ToInt32(data2.Substring(6, 4));

            totalData1 = diaData1 + (mesData1 + 30) + (anoData1 * 12 * 30);
            totalData2 = diaData2 + (mesData2 + 30) + (anoData2 * 12 * 30);

            if (totalData1 > totalData2)
            {
                diferenca = totalData1 - totalData2;
            }

            else
            {
                diferenca = totalData2 - totalData1;
            }

            Console.WriteLine("A diferença em dias entre as duas datas é:{0} ", diferenca);
            Console.ReadKey();
           



        }
    }
}
