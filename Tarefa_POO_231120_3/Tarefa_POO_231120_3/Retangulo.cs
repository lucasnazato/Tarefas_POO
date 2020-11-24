using System;
using Tarefa_POO_231120_3.Entities.Enums;

namespace Tarefa_POO_231120_3.Entities
{
    class Retangulo : Forma
    {
        // Declaração das variaveis e uso do encapsulamento
        public double Largura { get; set; }
        public double Altura { get; set; }

        // Construtor com parametros
        public Retangulo( double largura, double altura, Cor cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        // Método para calcular a area
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}