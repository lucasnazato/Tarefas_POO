using System;

namespace Tarefa_POO_140920
{
    class Conversor
    {
        public static double cotacao;
        public static double valorCompra;
        public static double iof = 1.06;

        // Calcular valor em reais
        public static double ValorReais()
        {
            return cotacao * (valorCompra * iof);
        }
    }
}