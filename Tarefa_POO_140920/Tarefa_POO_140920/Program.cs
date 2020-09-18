using System;
using System.Globalization;

namespace Tarefa_POO_140920
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é Cotação do Dólar? ");
            Conversor.cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos Dólares Você Irá Comprar? ");
            Conversor.valorCompra = double.Parse(Console.ReadLine());

            Console.Write("Valor a Ser Pago em Reais: " + Conversor.ValorReais().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
