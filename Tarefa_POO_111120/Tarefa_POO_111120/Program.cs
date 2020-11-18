using System;
using System.Globalization;

namespace Tarefa_POO_111120
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Goku", 0.0);
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0);

            // Upcasting de ...
            // Conta para Conta Juridica
            Conta acc1 = bacc;
            // Conta para Conta Juridica
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);
            // Conta para Conta Poupança
            Conta acc3 = new ContaPoupanca(1004, "Vegeta", 0.0, 0.01);

            // Downcasting
            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100.0);

            // Verficar se acc3 é uma Conta Juridica ou Poupança
            // Em seguida criar nova conta usando downcasting, chamar método da classe e dar print na tela
            if (acc3 is ContaJuridica)
            {
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is ContaPoupanca)
            {
                ContaPoupanca acc5 = (ContaPoupanca)acc3;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }

            Console.ReadKey();
        }
    }
}
