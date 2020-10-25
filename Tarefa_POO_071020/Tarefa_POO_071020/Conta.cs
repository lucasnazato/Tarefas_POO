using System;
using System.Globalization;

namespace Tarefa_POO_071020
{
    struct Conta
    {
        // Declarar variáveis
        private int _numero;
        public string Nome;
        private double? _saldo;

        // Contrutor
        public Conta (int numero, string nome, double? saldo)
        {
            _numero = numero;
            Nome = nome;
            _saldo = saldo;
        }

        // Metodo para realizar deposito
        public void Deposito(double quantidade)
        {
            double valor = _saldo ?? 0;
            _saldo = valor + quantidade;
        }

        // Metodo para realizar saque
        public void Saque(double quantidade)
        {
            double valor = _saldo ?? 0;
            _saldo = valor - quantidade - 5;
        }

        // Retornar informações da conta
        public override string ToString()
        {
            return "Dados da Conta: Conta " + _numero 
                + ", Titular: " + Nome 
                + ", Saldo R$ " + _saldo.GetValueOrDefault().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}