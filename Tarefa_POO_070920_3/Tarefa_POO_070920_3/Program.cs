using System;
using System.Globalization;

namespace Tarefa_POO_070920_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Aluno: ");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Digite as notas do aluno:");
            x.primeiraNota = double.Parse(Console.ReadLine());
            x.segundaNota = double.Parse(Console.ReadLine());
            x.terceiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: " + x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.Aprovado());

            Console.ReadKey();
        }
    }
}
