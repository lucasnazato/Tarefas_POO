using System;

namespace Tarefa_POO_210920
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pegar entrada do usuário para todos os parametros da classe
            Console.WriteLine("Entre com os produtos: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Instanciar um produto
            Produto x = new Produto(nome, preco, quantidade);

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
