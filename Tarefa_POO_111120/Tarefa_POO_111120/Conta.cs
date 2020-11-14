using System;
using System.Security.Cryptography.X509Certificates;

namespace Tarefa_POO_111120
{
    class Conta
    {
        // Declaração da variaveis e uso do encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; private set; }

        // utilização do protected para alteração de valores entre classes
        public double Saldo { get; protected set; }

        // Criação do construtor padrão e construtor com parâmetros
        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        // Método de Saque
        public void Saque (double saldoTotal)
        {
            Saldo -= saldoTotal;
        }

        // Método de Depósito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}