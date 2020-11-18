using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tarefa_POO_181120
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar lista de funcionários
            List<Funcionario> func = new List<Funcionario>();

            // Entrada do usuário determina qnt de funcionários
            Console.Write("Entre com número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            // Repetir código para cada funcionário
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + " data:");

                // Entrada do usuário para definir ...
                // Se ele é tercerizado
                Console.Write("Tercerizado (s/n)? ");
                string terc = Console.ReadLine();
                
                // Nome do funcionário
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                // Horas trabalhadas
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                // Se tercerizado...
                if (terc == "s")
                {
                    // Pegar valor do custo adicional
                    Console.Write("Adicional: ");
                    double adicional = double.Parse(Console.ReadLine());

                    // E do valor por hora
                    Console.Write("Valor por hora: ");
                    double valorHora = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    // Criar funcionário com upcasting para funcionário tercerizado
                    Funcionario temp1 = new FuncionarioTercerizado(nome, horas, valorHora, adicional);

                    // Adicionar funcionário na lista
                    func.Add(temp1);
                }
                // Se não tercerizado...
                else
                {
                    // Pegar apenas valor por hora
                    Console.Write("Valor por hora: ");
                    double valorHora = double.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    // Criar funcionário usando as informações coletadas
                    Funcionario temp = new Funcionario(nome, horas, valorHora);

                    // Adicionar funcionário na lista
                    func.Add(temp);
                }
            }

            // Escrever na tela o valor de pagamento de cada funcionário
            Console.WriteLine("Pagamentos:");
            foreach (Funcionario obj in func)
            {
                Console.WriteLine(obj.Nome +  " - R$ " + obj.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
