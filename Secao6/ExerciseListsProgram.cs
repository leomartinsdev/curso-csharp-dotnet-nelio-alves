using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;

namespace Secao6
{
    internal class ExerciseListsProgram
    {
        public static void Run()
        {
            List<Employee> employees = new List<Employee>();
            Console.WriteLine("Digite o número de funcionários: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                int employeeNumber = i + 1;
                Console.WriteLine("Employee #" + employeeNumber + ":");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());

                int listSize = employees.Count;

                bool idAlreadyExists = false;
                if (listSize > 0)
                {
                    idAlreadyExists = employees.Find(x => x.Id == id) != null;
                }

                if (idAlreadyExists)
                {
                    Console.WriteLine("The id already exists. Please try a different one.");
                    i--;
                    continue;
                }

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee newEmployee = new Employee(id, name, salary);
                employees.Add(newEmployee);
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int employeeIdToIncreaseSalary = int.Parse(Console.ReadLine());

            Employee? foundEmployee = employees.Find(x => x.Id == employeeIdToIncreaseSalary);

            if (foundEmployee != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                foundEmployee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employee in employees) {
                Console.WriteLine(employee.Id + ", " + employee.Name + ", " + employee.Salary.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
