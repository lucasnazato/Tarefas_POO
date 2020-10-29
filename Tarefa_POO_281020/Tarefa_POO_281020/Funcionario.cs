using System;

namespace Tarefa_POO_281020
{
    class Funcionario
    {
        // Inicializar vari�veis
        private int _id;
        private string _nome;
        private double _salario;

        // Construtor
        public Funcionario(int id, string nome, double salario)
        {
            _id = id;
            _nome = nome;
            _salario = salario;
        }

        // M�todo para alterar sal�rio baseado na porcentagem
        public void aumentarSalario(double porcentagem)
        {
            _salario += (_salario * porcentagem / 100);
        }

        // _id Properties
        public int ID
        {
            get { return _id;  }
        }

        // _nome Properties
        public string Nome
        {
            get { return _nome; }
        }

        // _salario Properties
        public double Salario
        {
            get { return _salario; }
        }
    }
}