using System;
using System.Globalization;

namespace Tarefa_POO_020920
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos (int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

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