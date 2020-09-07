using System;

namespace Tarefa_POO_070920_1
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = (Largura + Altura) * 2;
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = MathF.Sqrt(MathF.Pow((float)Largura, 2) + MathF.Pow((float)Altura, 2));
            return diagonal;
        }
    }
}
