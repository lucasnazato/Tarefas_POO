using System;

namespace Tarefa_POO_181120
{
    class FuncionarioTercerizado : Funcionario
    {
        //Declara��o das variaveis e uso do encapsulamento
        public double Adicional { get; set; }

        // Cria��o do construtor padr�o e construtor com parametros
        public FuncionarioTercerizado()
        {
        }

        public FuncionarioTercerizado(string nome, int horas, double valorHora, double adicional) : base(nome, horas, valorHora)
        {
            Adicional = adicional;
        }

        // M�todo para calcular o pagamento do funcion�rio tercerizado
        public override double Pagamento()
        {
            return Horas * ValorHora + Adicional * 1.1;
        }
    }
}