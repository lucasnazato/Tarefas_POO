using System;
using System.Globalization;

namespace Tarefa_POO_070920_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
            
            Console.WriteLine("Entre com a altura e largura do retângulo:");
            Console.Write("Altura: ");
            x.Altura = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            x.Largura = double.Parse(Console.ReadLine());

            Console.Write("Area = ");
            Console.WriteLine(x.Area().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Perímetro = ");
            Console.WriteLine(x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Diagonal = ");
            Console.WriteLine(x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
