using System;
using System.Globalization;

namespace Tarefa_POO_070920_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("\nFuncionário: " + x.Nome + ", R$ " + x.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            x.AumentarSalario(porcentagem);

            Console.WriteLine("\nDados Atualizados: " + x.Nome + ", R$ " + x.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
