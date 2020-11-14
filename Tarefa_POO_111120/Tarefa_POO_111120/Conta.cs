using System;
using System.Security.Cryptography.X509Certificates;

namespace Tarefa_POO_111120
{
    class Conta
    {
        // Declara��o da variaveis e uso do encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; private set; }

        // utiliza��o do protected para altera��o de valores entre classes
        public double Saldo { get; protected set; }

        // Cria��o do construtor padr�o e construtor com par�metros
        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        // M�todo de Saque
        public void Saque (double saldoTotal)
        {
            Saldo -= saldoTotal;
        }

        // M�todo de Dep�sito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}