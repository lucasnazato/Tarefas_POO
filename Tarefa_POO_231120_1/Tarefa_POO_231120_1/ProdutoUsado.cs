using System;
using System.Globalization;

namespace Tarefa_POO_231120_1
{
    class ProdutoUsado : Produto
    {
        // Declaração da variavel e uso do encapsulamento
        public DateTime Fabricacao { get; set; }

        // Criação do construtor com parametros
        public ProdutoUsado(string nome, double preco, DateTime fabricacao) : base(nome, preco)
        {
            Fabricacao = fabricacao;
        }

        // Metodo para criar a etiqueta do produto
        public override string precoTag()
        {
            return Nome + " (usado) - R$ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + "(fabricado: " + Fabricacao.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + ")";
        }
    }
}