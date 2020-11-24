using System;
using System.Security.Cryptography.X509Certificates;

namespace Tarefa_POO_231120_2
{
    class ContaJuridica : Conta
    {
        // Declaração das variáveis e uso do encapsulamento
        public double EmprestimoLimite { get; set; }

        // Criação do construtor padrão
        public ContaJuridica()
        {
        }

        // Criação do construtor com parâmetros utilizando o da Classe Conta
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        // Método de Empréstimo
        public void Emprestimo (double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}