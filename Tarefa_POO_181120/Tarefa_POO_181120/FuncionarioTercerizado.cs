using System;

namespace Tarefa_POO_181120
{
    class FuncionarioTercerizado : Funcionario
    {
        //Declaração das variaveis e uso do encapsulamento
        public double Adicional { get; set; }

        // Criação do construtor padrão e construtor com parametros
        public FuncionarioTercerizado()
        {
        }

        public FuncionarioTercerizado(string nome, int horas, double valorHora, double adicional) : base(nome, horas, valorHora)
        {
            Adicional = adicional;
        }

        // Método para calcular o pagamento do funcionário tercerizado
        public override double Pagamento()
        {
            return Horas * ValorHora + Adicional * 1.1;
        }
    }
}