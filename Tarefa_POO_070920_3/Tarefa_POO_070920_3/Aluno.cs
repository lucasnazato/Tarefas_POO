using System;
using System.Globalization;

namespace Tarefa_POO_070920_3
{
    class Aluno
    {
        public string Nome;
        public double primeiraNota;
        public double segundaNota;
        public double terceiraNota;
        public double notaFinal;

        public double NotaFinal()
        {
            notaFinal = primeiraNota + segundaNota + terceiraNota;
            return notaFinal;
        }

        public string Aprovado()
        {
            string mensagem;
            if (notaFinal >= 60)
            {
                mensagem = "Aprovado";
            }
            else
            {
                double faltaram = 60 - notaFinal;
                mensagem = "Reprovado \nFaltaram " + faltaram.ToString("F2", CultureInfo.InvariantCulture) + " Pontos";
            }

            return mensagem;
        }
    }
}