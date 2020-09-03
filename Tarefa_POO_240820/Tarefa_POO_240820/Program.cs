using System;
using System.Globalization;

namespace Tarefa_POO_240820
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verificar a idade e media salarial dos funcionários
            
            // Criar os funcionários x e y
            Employee x, y;

            x = new Employee();
            y = new Employee();

            // Adicionar informações do func. x
            Console.WriteLine("Entre as informações do funcionário X:");
            Console.Write("Nome: ");
            x.name = Console.ReadLine();
            Console.Write("Idade: ");
            x.age = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            x.wage = float.Parse(Console.ReadLine());

            // Adicionar informações do func. y
            Console.WriteLine("\nEntre as informações do funcionário Y:");
            Console.Write("Nome: ");
            y.name = Console.ReadLine();
            Console.Write("Idade: ");
            y.age = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            y.wage = float.Parse(Console.ReadLine());

            // Ver qual funcionário é o mais velho
            Console.Write("\nA pessoa mais velha é: ");
            string oldest = x.Oldest(y);
            Console.WriteLine(oldest);

            // Verficar a média salarial
            float avg = x.Average(y);
            Console.Write("\nA média salarial é: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
