using System;

namespace Tarefa_POO_021120_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário para definir tamanho da matriz
            Console.Write("Número de linhas: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Número de colunas: ");
            int m = int.Parse(Console.ReadLine());

            // Criar matriz
            int[,] mat = new int[n, m];

            // Entrada do usuário para preencher a matriz
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Entrar valor [" + i + ", " + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Imprimir a matriz
            Console.WriteLine("\nMatriz [" + n + ", " + m + "]");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mat[i,j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }

            // Pegar valor para procurar na matriz
            Console.Write("\nNúmero para procura: ");
            int x = int.Parse(Console.ReadLine());

            // Iterar pela matriz
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Se achar o valor imprimir os valores ao redor, desde que estejam dentro da matriz
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("-Posição [" + i + ", " + j + "]: ");
                        // Esquerda
                        if ((j - 1) >= 0) Console.WriteLine("--Esquerda: " + mat[i, j-1]);

                        // Direita
                        if ((j + 1) < m) Console.WriteLine("--Direita: " + mat[i, j + 1]);

                        // Acima
                        if ((i - 1) >= 0) Console.WriteLine("--Acima: " + mat[i - 1, j]);

                        // Abaixo
                        if ((i + 1) < n) Console.WriteLine("--Abaixo: " + mat[i + 1, j]);

                        Console.WriteLine();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
