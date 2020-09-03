using System;
using System.Globalization;

namespace Tarefa_POO_240820
{
    public class Employee
    {
        public string name;
        public int age;
        public float wage;

        public string Oldest(Employee y)
        {
            string nameOld;
            if (age > y.age) nameOld = name;
            else nameOld = y.name;
            return nameOld;
        }

        public float Average(Employee y)
        {
            float avg = (wage + y.wage) / 2;
            return avg;
        }
    }
}