using System;

namespace Tarefa_POO_211020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar array para os quartos
            Quarto[] vect = new Quarto[10];
            
            // Pegar entrada do usuário para quantidade de hospedes
            Console.Write("Quantos quartos estão alugados: ");
            int n = int.Parse(Console.ReadLine());

            // Adicionar todas as informações dos hospedes
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nHospede #" + i);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("\nQuarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto - 1] = new Quarto { Name = name, Email = email };

                Console.WriteLine("\n----------------------------------------------------");
            }

            // Imprimir relatório
            Console.WriteLine("\nQUARTOS OCUPADOS");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i+1 + ": " + vect[i].Name + ", " + vect[i].Email);
                }
            }

            Console.ReadKey();
        }
    }
}
