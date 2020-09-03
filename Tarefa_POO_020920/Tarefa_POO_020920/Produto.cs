using System;

namespace Tarefa_POO_020920
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            double valorTotal = Preco * Quantidade;
            return valorTotal;
        }

        public void AdicionarProdutos (int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}