using System;
using System.Security.Cryptography.X509Certificates;

namespace Tarefa_POO_231120_2
{
    class ContaPoupanca : Conta
    {
        // Declara��o das vari�veis e uso do encapsulamento
        public double TaxaJuros { get; set; }

        // Cria��o do construtor padr�o
        public ContaPoupanca()
        {
        }

        // Cria��o do construtor com par�metros utilizando o da Classe Conta
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        // M�todo de Saque
        public sealed override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }

        // M�todo de Atualiza��o de Saldo
        public void atualizacaoSaldo ()
        {
            Saldo += Saldo * TaxaJuros;

        }
    }
}