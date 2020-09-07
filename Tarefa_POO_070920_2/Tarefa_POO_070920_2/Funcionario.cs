using System;

namespace Tarefa_POO_070920_2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double salarioLiquido = SalarioBruto - Imposto;
            return salarioLiquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += ((SalarioBruto * porcentagem) / 100) - Imposto;
        }
    }
}