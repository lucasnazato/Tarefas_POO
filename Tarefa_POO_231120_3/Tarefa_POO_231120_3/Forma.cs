using System;
using Tarefa_POO_231120_3.Entities.Enums;

namespace Tarefa_POO_231120_3.Entities
{
    abstract class Forma
    {
        // Declaração das variaveis e uso do encapsulamento
        public Cor Color { get; set; }

        // Construtor com parametros
        public Forma(Cor color)
        {
            Color = color;
        }

        // Método abstrato
        public abstract double Area();
    }
}