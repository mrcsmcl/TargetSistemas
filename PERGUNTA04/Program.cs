using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            (string estado, double valor)[] faturamentoMensal = {
                ("SP", 67836.43),
                ("RJ", 36678.66),
                ("MG", 29229.88),
                ("ES", 27165.48),
                ("Outros", 19849.53)
            };

            double total = 0;

            foreach (var item in faturamentoMensal)
            {
                total += item.valor;
            }

            foreach (var item in faturamentoMensal)
            {
                double percentual = (item.valor / total) * 100;

                if (item.estado == "Outros")
                {
                    Console.WriteLine("Outros estados representam {0:F2}% do faturamento mensal da distribuidora.", percentual);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"O estado {item.estado} representa {percentual:F2}% do faturamento total.");
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
