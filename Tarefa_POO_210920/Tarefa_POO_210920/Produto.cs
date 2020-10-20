using System;
using System.Globalization;

namespace Tarefa_POO_210920
{
    class Produto
    {
        // Definir variáveis
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Método para calcular o valor total do estoque
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        // Método para adicionar produtos ao estoque
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        // Método para remover produtos do estoque
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        // Método ToString (Retornar todas as informações do produto)
        public override string ToString()
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}