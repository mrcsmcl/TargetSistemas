using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número que deseja buscar na sequência de Fibonacci: ");
            int numeroProcurado = int.Parse(Console.ReadLine()); // lê o número informado pelo usuário

            Console.WriteLine();

            int a = 0; // primeiro número da sequência
            int b = 1; // segundo número da sequência

            while (a <= numeroProcurado) // enquanto não ultrapassar o número procurado
            {
                if (a == numeroProcurado) // se o número procurado for encontrado
                {
                    Console.WriteLine(numeroProcurado + " pertence à sequência de Fibonacci.");
                    break;
                }

                int temp = b;
                b = a + b; // calcula o próximo número da sequência
                a = temp; // atualiza o valor de a com o valor anterior de b
            }

            if (a > numeroProcurado) // se ultrapassar o número procurado
            {
                Console.WriteLine(numeroProcurado + " não pertence à sequência de Fibonacci.");
            }

            Console.ReadKey(); // aguarda o usuário pressionar uma tecla para encerrar o programa
        }
    }
}
