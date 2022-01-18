using System;

namespace Any
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Süleyman", Age = 23 });
            students.Add(new Student { Id = 2, Name = "Lokman", Age = 46 });
            students.Add(new Student { Id = 3, Name = "Emre", Age = 18 });
            students.Add(new Student { Id = 4, Name = "Deniz", Age = 33 });
            if (students.Any(x=>x.Age>47))
            {
                Console.WriteLine("There are people over 35");
            }
            else 
            { 
                Console.WriteLine("None"); 
            }
            
        }
    }
}