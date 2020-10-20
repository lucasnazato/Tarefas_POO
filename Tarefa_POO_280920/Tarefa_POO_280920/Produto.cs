using System;
using System.Globalization;

namespace Tarefa_POO_280920
{
    class Produto
    {
        // Definir variáveis
        private string _nome;
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
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

        // Utilização do properties
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
