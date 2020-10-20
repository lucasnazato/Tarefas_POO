using System;
using System.Globalization;

namespace Tarefa_POO_121020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir tamanho do array
            Console.Write("Entre com um número de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            // Criar array
            double[] vect = new double[n];

            // Adicionar valores no array
            for (int i = 0; i < n; i++)
            {
                Console.Write("Altura da Pessoa (" + (i+1) + "): ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            // Somar valores do array
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            // Calcular a média e escrever resultado
            double avg = sum / vect.Length;
            Console.WriteLine("A média de altura das pessoas inseridas é: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
