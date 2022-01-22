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

            var result = employees.Where(e => e.Name.Length == 5)
                                        .OrderByDescending(e => e.Name)
                                        .Select(e => e);
                                        

            foreach (var employee in result)
            {
                Console.WriteLine(employee.Name);
            }

        }
    }
}