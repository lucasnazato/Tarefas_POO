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

            double valorTotal = x.ValorTotalEstoque();
            Console.WriteLine("Dados Atualizados: " + x.Nome + ", R$ " + x.Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + x.Quantidade + " unidades, " + "Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("\nDigite o número a ser adicionado no estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(quantity);
            valorTotal = x.ValorTotalEstoque();
            Console.WriteLine("Dados Atualizados: " + x.Nome + ", R$ " + x.Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + x.Quantidade + " unidades, " + "Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("\nDigite o número a ser removido do estoque: ");
            quantity = int.Parse(Console.ReadLine());
            x.RemoverProdutos(quantity);
            valorTotal = x.ValorTotalEstoque();
            Console.WriteLine("Dados Atualizados: " + x.Nome + ", R$ " + x.Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + x.Quantidade + " unidades, " + "Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
