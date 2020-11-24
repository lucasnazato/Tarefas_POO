using System;
using System.Globalization;
using System.Collections.Generic;
using Tarefa_POO_231120_3.Entities;
using Tarefa_POO_231120_3.Entities.Enums;

namespace Tarefa_POO_231120_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de lista para as formas
            List<Forma> list = new List<Forma>();

            // Pegar entrada do usuário para o numero de formas a serem adicionadas na lista
            Console.Write("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            // Para cada forma...
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Forma #{i}:");

                // Definir se é um Retângulo ou Círculo
                Console.Write("Retângulo ou Círculo (R/C)? ");
                char ch = char.Parse(Console.ReadLine());

                // Qual a sua cor
                Console.Write("Cor (Preto/Azul/Vermelho): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                // Se for retângulo...
                if (ch == 'R')
                {
                    // ... Pegar largura e altura e adicionar na lista
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(largura, altura, cor));
                }
                // Se for Círculo ...
                else
                {
                    // Pegar o raio e adicionar na lista
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }
            }

            // Para cada forma na lista chamar seu metódo para calcular a area e escrever na tela
            Console.WriteLine();
            Console.WriteLine("Área de cada forma: ");
            foreach (Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
