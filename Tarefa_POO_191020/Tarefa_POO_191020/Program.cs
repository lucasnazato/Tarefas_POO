using System;
using System.Globalization;

namespace Tarefa_POO_191020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando a variável de entrada
            Console.Write("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            // Criando vetor com o número da var de entrada
            Produto[] vect = new Produto[n];

            // Utilização do comando for para percorrer o vetor
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Produto (" + (i + 1) + "): ");
                Console.Write("   Nome: ");
                string name = Console.ReadLine();
                Console.Write("   Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Name = name, Price = price };
            }

            // Váriavel soma
            double sum = 0.0;

            // Utilização do for para percorrer o vetor
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            // Calcular media dos preços
            double avg = sum / vect.Length;

            Console.WriteLine("A média de preço dos produtos inseridos é: R$ " + avg.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
