using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tarefa_POO_231120_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar lista para conter todas as contas
            List<Conta> list = new List<Conta>();

            // Popular a lista com contas Poupança e Juridica
            list.Add(new ContaPoupanca(1001, "Terry", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Andy", 500.0, 400.0));
            list.Add(new ContaPoupanca(1003, "Joe", 500.0, 0.01));
            list.Add(new ContaJuridica(1004, "Mae", 500.0, 400.0));

            // Variavel para somar saldo de todas as contas
            double soma = 0.0;

            // Somar todos os saldos de todas as contas
            foreach (Conta acc in list)
            {
                soma += acc.Saldo;
            }

            // Escrever o saldo total na tela
            Console.WriteLine("Total do saldo de todas as contas: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            // Para cada uma das contas na lista chamar o metodo de Saque
            foreach (Conta acc in list)
            {
                acc.Saque(10.0);
            }

            // Para cada conta na lista escrever seu numero de conta e seu saldo
            foreach (Conta acc in list)
            {
                Console.WriteLine("Total do saldo de todas as contas:" 
                    + acc.Numero + ": "
                    + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
