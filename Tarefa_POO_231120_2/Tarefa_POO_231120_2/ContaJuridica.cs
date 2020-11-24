using System;
using System.Security.Cryptography.X509Certificates;

namespace Tarefa_POO_231120_2
{
    class ContaJuridica : Conta
    {
        // Declara��o das vari�veis e uso do encapsulamento
        public double EmprestimoLimite { get; set; }

        // Cria��o do construtor padr�o
        public ContaJuridica()
        {
        }

        // Cria��o do construtor com par�metros utilizando o da Classe Conta
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        // M�todo de Empr�stimo
        public void Emprestimo (double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}