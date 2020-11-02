using System;

namespace Tarefa_POO_021120_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário para definir ordem da matriz
            Console.Write("Definir ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());

            // Criar matriz
            int[,] mat = new int[n, n];

            // Entrada do usuário para preencher a matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Entrar valor [" + i + ", " + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Iterar pela matriz para...
            Console.WriteLine("\nDiagonal Principal: ");
            int negative = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // ...Imprimir valores da diagonal e...
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " ");
                    }

                    // ...Contar quantos valores negativos estão na matriz
                    if (mat[i, j] < 0)
                    {
                        negative++;
                    }
                }
            }

            // Imprimir quantidade de valores negativos na matriz
            Console.WriteLine("\nNúmeros Negativos: \n" + negative);

            Console.ReadKey();
        }
    }
}
