using System;

namespace Tarefa_POO_280920
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um produto
            Produto x = new Produto("PS5", 5000.00, 10);

            // Escrever os dados iniciais do produto
            Console.WriteLine("Dados Iniciais: " + x);

            // Alterar os dados iniciais usando as entradas do usuário
            Console.WriteLine("\nAltere os dados do produto: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            // Escrever os dados do produto
            Console.WriteLine("Dados Atualizados: " + x);

            // Adicionar produtos no estoque e mostrar dados atualizados
            Console.Write("\nDigite o número a ser adicionado no estoque: ");
            int quantity = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(quantity);
            Console.WriteLine("Dados Atualizados: " + x);

            // Remover produtos do estoque e mostrar dados atualizados
            Console.Write("\nDigite o número a ser removido do estoque: ");
            quantity = int.Parse(Console.ReadLine());
            x.RemoverProdutos(quantity);
            Console.WriteLine("Dados Atualizados: " + x);

            Console.ReadKey();
        }
    }
}
