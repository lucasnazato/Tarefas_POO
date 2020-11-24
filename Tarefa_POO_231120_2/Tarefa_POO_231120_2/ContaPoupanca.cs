using System;
using System.Security.Cryptography.X509Certificates;

namespace Tarefa_POO_231120_2
{
    class ContaPoupanca : Conta
    {
        // Declaração das variáveis e uso do encapsulamento
        public double TaxaJuros { get; set; }

        // Criação do construtor padrão
        public ContaPoupanca()
        {
        }

        // Criação do construtor com parâmetros utilizando o da Classe Conta
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        // Método de Saque
        public sealed override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }

        // Método de Atualização de Saldo
        public void atualizacaoSaldo ()
        {
            Saldo += Saldo * TaxaJuros;

        }
    }
}