using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Secao6
{
    internal class Employee(int id, string name, double salary)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public double Salary { get; set; } = salary;

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }
    }
}
