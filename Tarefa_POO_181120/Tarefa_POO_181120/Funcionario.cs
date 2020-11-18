using System;

namespace Tarefa_POO_181120
{
    class Funcionario
    {
        //Declaração das variaveis e uso do encapsulamento
        public string Nome { get; private set; }
        public int Horas { get; private set; }
        public double ValorHora { get; private set; }

        // Criação do construtor padrão e construtor com parametros
        public Funcionario()
        {
        }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        // Método para calcular o pagamento do funcionário
        public virtual double Pagamento()
        {
            return Horas * ValorHora;
        }
    }
}