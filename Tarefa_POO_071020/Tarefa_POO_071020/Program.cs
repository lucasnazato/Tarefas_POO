using System;

namespace Tarefa_POO_071020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pegar informações para abertura da conta
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N): ");
            string boolDeposito = Console.ReadLine();

            // Criar variável de deposito inicial (null)
            double? deposito = null;

            // Caso tenha depósito inicial, pegar valor
            if (boolDeposito == "S")
            {
                Console.Write("Entre o valor de depósito: ");
                deposito = double.Parse(Console.ReadLine());
            }

            // Instanciar struct e imprimir dados da conta
            Conta n = new Conta(numero, titular, deposito);

            Console.WriteLine("\n" +n+ "\n");

            // Realizar depósito e imprimir dados da conta
            Console.Write("Entre com um valor para depósito: ");
            n.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine(n + "\n");

            // Realizar saque e imprimir dados da conta
            Console.Write("Entre com um valor para saque: ");
            n.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
