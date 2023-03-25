using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERGUNTA02
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número que deseja buscar na sequência de Fibonacci: ");
            int numeroProcurado = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int a = 0;
            int b = 1;

            while (a <= numeroProcurado)
            {
                if (a == numeroProcurado)
                {
                    Console.WriteLine(numeroProcurado + " pertence à sequência de Fibonacci.");
                    break;
                }

                int temp = b;
                b = a + b;
                a = temp;
            }

            if (a > numeroProcurado)
            {
                Console.WriteLine(numeroProcurado + " não pertence à sequência de Fibonacci.");
            }

            Console.ReadKey();
        }
    }
}