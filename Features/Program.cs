using System;
using System.Linq;

namespace Features
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee { Id=1, Name="Süleyman"},
                new Employee { Id=2, Name="Scott"},
                new Employee{ Id=3, Name="Barış"},
                new Employee { Id=4, Name="Derya"}
            };

            foreach (var employee in employees.Where(
                                     e=>e.Name.StartsWith("B")))
            {
                Console.WriteLine(employee.Name);
            }

        }
    }
}