using System;
using System.Globalization;

namespace Tarefa_POO_020920
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x = new Produto();

            Console.WriteLine("Entre com os produtos: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados Atualizados: " + x);

            Console.Write("\nDigite o número a ser adicionado no estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(quantity);
            Console.WriteLine("Dados Atualizados: " + x);

            Console.Write("\nDigite o número a ser removido do estoque: ");
            quantity = int.Parse(Console.ReadLine());
            x.RemoverProdutos(quantity);
            Console.WriteLine("Dados Atualizados: " + x);

            Console.ReadKey();
        }
    }
}
