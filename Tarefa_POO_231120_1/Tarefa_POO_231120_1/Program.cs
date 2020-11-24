using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tarefa_POO_231120_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar lista para conter os produtos
            List <Produto> prod = new List<Produto>();

            // Pegar entrada do usuário para definir o número de produtos
            Console.Write("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            // Para cada produto...
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nProduto #{i}:");

                // Definir se é Comum, Usado ou Importado
                Console.Write("Comum, Usado ou Importado (C/U/I)? ");
                char tipo = char.Parse(Console.ReadLine());

                // Definir nome do produto
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                // Definir preço do produto
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                // Se for usado...
                if (tipo == 'U')
                {
                    // Pegar a data de fabricação do produto e adicionar na lista
                    Console.Write("Fabricação (DD/MM/AA): ");
                    DateTime fabricacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yy", CultureInfo.InvariantCulture);
                    prod.Add(new ProdutoUsado(nome, preco, fabricacao));
                }
                // Se for importado...
                else if (tipo == 'I')
                {
                    // Pegar o valor da taxa do produto e adicionar na lista
                    Console.Write("Taxa: ");
                    double taxa = double.Parse(Console.ReadLine());
                    prod.Add(new ProdutoImportado(nome, preco, taxa));
                }
                // Se for comum adicionar na lista
                else
                {
                    prod.Add(new Produto(nome, preco));
                }
            }

            // Para cada produto na lista imprimir a sua etiqueta
            Console.WriteLine("\nEtiquetas:");
            foreach (Produto produto in prod)
            {
                Console.WriteLine(produto.precoTag());
            }

            Console.ReadKey();
        }
    }
}
