using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverteString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário que informe uma string
            Console.Write("Informe uma string: ");

            // Recebe a string informada pelo usuário
            string input = Console.ReadLine();

            // Converte a string para um array de caracteres
            char[] charArray = input.ToCharArray();

            // Define a variável de índice do início do array
            int start = 0;

            // Define a variável de índice do final do array
            int end = charArray.Length - 1;

            // Enquanto o índice do início for menor que o índice do final
            while (start < end)
            {
                // Define a variável temporária para armazenar o valor do índice do início
                char temp = charArray[start];

                // Define o valor do índice do início como o valor do índice do final
                charArray[start] = charArray[end];

                // Define o valor do índice do final como o valor armazenado na variável temporária
                charArray[end] = temp;

                // Incrementa o índice do início
                start++;

                // Decrementa o índice do final
                end--;
            }

            // Converte o array de caracteres de volta para uma string
            string output = new string(charArray);

            // Exibe a string invertida na tela
            Console.WriteLine("String invertida: " + output);

            Console.ReadLine();
        }
    }
}
