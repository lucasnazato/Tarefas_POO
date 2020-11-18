using System;

namespace Tarefa_POO_181120
{
    class Funcionario
    {
        //Declara��o das variaveis e uso do encapsulamento
        public string Nome { get; private set; }
        public int Horas { get; private set; }
        public double ValorHora { get; private set; }

        // Cria��o do construtor padr�o e construtor com parametros
        public Funcionario()
        {
        }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        // M�todo para calcular o pagamento do funcion�rio
        public virtual double Pagamento()
        {
            return Horas * ValorHora;
        }
    }
}