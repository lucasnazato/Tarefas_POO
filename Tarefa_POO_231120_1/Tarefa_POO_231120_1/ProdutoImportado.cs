using System;
using System.Globalization;

namespace Tarefa_POO_231120_1
{
    class ProdutoImportado : Produto
    {
        // Declaração da variavel e uso do encapsulamento
        public double Taxa { get; set; }

        // Criação do construtor com parametros
        public ProdutoImportado(string nome, double preco, double taxa) : base (nome, preco)
        {
            Taxa = taxa;
        }

        // Metodo para calcular o preço total com base na taxa
        public double precoTotal()
        {
            return Preco + Taxa;
        }

        // Metodo para criar a etiqueta do produto
        public override string precoTag()
        {
            return Nome 
                + " - R$ " + precoTotal().ToString("F2", CultureInfo.InvariantCulture) 
                + " (Taxa: " + Taxa.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}