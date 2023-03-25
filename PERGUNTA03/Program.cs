using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Faturamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // ler o arquivo JSON com o faturamento diário
            var faturamentoJson = File.ReadAllText("dados.json");

            // desserializar o JSON para um array de objetos com dia e valor
            var faturamento = JsonConvert.DeserializeObject<FaturamentoDiario[]>(faturamentoJson);

            // inicializar variáveis para armazenar menor e maior faturamento e soma do faturamento diário
            double menorFaturamento = Double.MaxValue;
            double maiorFaturamento = Double.MinValue;
            double somaFaturamento = 0;
            int diasComFaturamentoAcimaDaMedia = 0;

            // iterar sobre os objetos do array de faturamento
            foreach (var f in faturamento)
            {
                // ignorar os dias sem faturamento
                if (f.valor == 0) continue;

                // atualizar menor e maior faturamento, se necessário
                if (f.valor < menorFaturamento)
                {
                    menorFaturamento = f.valor;
                }
                if (f.valor > maiorFaturamento)
                {
                    maiorFaturamento = f.valor;
                }

                // somar o faturamento do dia
                somaFaturamento += f.valor;
            }

            // calcular a média do faturamento diário (considerando apenas os dias com faturamento)
            double mediaFaturamento = somaFaturamento / faturamento.Count(f => f.valor > 0);

            // contar o número de dias em que o faturamento diário foi superior à média
            foreach (var f in faturamento)
            {
                if (f.valor > mediaFaturamento)
                {
                    diasComFaturamentoAcimaDaMedia++;
                }
            }

            // exibir os resultados
            Console.WriteLine("Menor faturamento: " + menorFaturamento.ToString("C2"));
            Console.WriteLine("Maior faturamento: " + maiorFaturamento.ToString("C2"));
            Console.WriteLine("Dias com faturamento acima da média: " + diasComFaturamentoAcimaDaMedia);

            // aguardar usuário pressionar alguma tecla para encerrar o programa
            Console.ReadKey();
        }
    }

    // classe auxiliar para desserializar o JSON
    public class FaturamentoDiario
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }
}
