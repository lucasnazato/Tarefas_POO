using System;
using System.Globalization;

namespace Tarefa_POO_210920
{
    class Produto
    {
        // Definir vari�veis
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

        // M�todo para calcular o valor total do estoque
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        // M�todo para adicionar produtos ao estoque
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        // M�todo para remover produtos do estoque
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        // M�todo ToString (Retornar todas as informa��es do produto)
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