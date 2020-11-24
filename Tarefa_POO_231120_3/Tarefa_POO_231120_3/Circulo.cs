using System;
using Tarefa_POO_231120_3.Entities.Enums;

namespace Tarefa_POO_231120_3.Entities
{
    class Circulo : Forma
    {
        // Declaração das variaveis e uso do encapsulamento
        public double Raio { get; set; }

        // Construtor com parametros
        public Circulo( double raio, Cor cor) : base(cor)
        {
            Raio = raio;
        }

        // Método para calcular a area
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}