using System;
using System.Globalization;

namespace Tarefa_POO_231120_1
{
    class Produto
    {
        // Declaração das variaveis e uso do encapsulamento
        public string Nome { get; set; }
        public double Preco { get; set; }

        // Criação do construtor com parametros
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // Metodo para criar a etiqueta do produto
        public virtual string precoTag()
        {
            return Nome + " - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}