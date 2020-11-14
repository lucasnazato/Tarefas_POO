using System;
using System.Globalization;

namespace Tarefa_POO_111120
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar conta
            ContaJuridica conta = new ContaJuridica(8010, "Lara Croft", 100.0, 500.0);

            // Dados da conta
            Console.WriteLine("Conta: " + conta.Numero);
            Console.WriteLine("Titular: " + conta.Titular);
            Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Empréstimo Limite: R$ " + conta.EmprestimoLimite.ToString("F2", CultureInfo.InvariantCulture));

            // Realizar saque da conta
            Console.WriteLine("\nSaque de R$ 50.00");
            conta.Saque(50);
            Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            // Realizar depósito na conta
            Console.WriteLine("\nDepósito de R$ 200.00");
            conta.Deposito(200);
            Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            // Empréstimo acima do valor permitido
            Console.WriteLine("\nEmpréstimo de R$ 600.00");
            conta.Emprestimo(600);
            Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            // Empréstimo abaixo do valor permitido
            Console.WriteLine("\nEmpréstimo de R$ 450.00");
            conta.Emprestimo(450);
            Console.WriteLine("Saldo: R$ " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
