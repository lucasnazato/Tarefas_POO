using System;
using System.Collections.Generic;

namespace Tarefa_POO_261020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tema: Exemplo Listas

            //Criando lista de strings
            List<string> list = new List<string>();

            // Adicionar elementos na lista
            list.Add("Fábio"); list.Add("Wilson"); list.Add("Angelina"); list.Add("Eliney"); list.Add("Andre");

            // Adicionar elemento na posição sugerida
            list.Insert(2, "Lucas");

            // Loop de leitura dos elementos inseridos
            foreach (string obj in list)
            {
                // Imprime os elementos na tela
                Console.WriteLine(obj);
            }

            // Quantos elementos tem na lista
            Console.WriteLine("Qnt de elementos na Lista: " + list.Count);

            // Encontrar primeiro elemento que inicia com a letra A, com função lambda
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);

            // Encontrar último elemento que inicia com a letra A, com função lambda
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último elemento que começa com a letra A: " + s2);

            // Buscar elementos pela sua posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posição de 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última Posição de 'A': " + pos2);

            // Buscar todos elementos com tamanho igual a 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remover elementos da lista
            list.Remove("Andre");
            Console.WriteLine("===========================");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Remover determinado elemento da lista
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("+++++++++++++++++++++++++++");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Remover elemento de determinada posição
            list.RemoveAt(3);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Remover elementos da lista a partir da posição e quantos elementos
            list.RemoveRange(1, 2);
            Console.WriteLine("___________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
