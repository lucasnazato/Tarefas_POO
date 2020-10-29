using System;
using System.Collections.Generic;
using System.Globalization;

namespace Tarefa_POO_281020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar lista de funcionários
            List<Funcionario> func = new List<Funcionario>();

            // Entrada do usuário determina qnt de funcionários
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            // Repetir código para cada funcionário
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");

                // Entrada do usuário para definir Id, Nome, e Salário
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------");

                // Criar objeto Funcionario usando as informações coletadas
                Funcionario temp = new Funcionario(id, nome, salario);

                // Adicionar obj na lista
                func.Add(temp);
            }

            // Verificar qual funcionário irá receber aumento
            Console.Write("\nId do funcionário que receberá aumento: ");
            int idRaise = int.Parse(Console.ReadLine());

            // Achar funcionário na lista
            Funcionario f = func.Find(x => x.ID == idRaise);

            // Se o funcionário existir...
            if (f != null)
            {
                // ... chamar o metodo para aumentar o salário baseado na porcentagem passada
                Console.Write("Porcentagem de aumento de salário: ");
                f.aumentarSalario(double.Parse(Console.ReadLine()));
            }
            // Se não existir avisar o usuário
            else
            {
                Console.WriteLine("Este funcionário não existe!");
            }

            // Imprimir lista atualizada de todos os funcionários
            Console.WriteLine("\nLista atualizada dos funcionários:");
            foreach (Funcionario obj in func)
            {
                Console.WriteLine(obj.ID.ToString("D3") + ", " +  obj.Nome + ", " + obj.Salario.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
