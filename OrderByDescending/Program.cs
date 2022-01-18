using System;

namespace OrderByDescending
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Rank { get; set; }

    }


    public class Program
    {
        static void Main(string[] args)
        {
           List<Student> list = new List<Student>();
            list.Add(new Student { Id = 1, Name = "Süleyman", Rank = 2, Age = 23 });
            list.Add(new Student { Id = 2, Name = "Elif", Rank = 1, Age = 18 });
            list.Add(new Student { Id = 3, Name = "Deniz", Rank = 1, Age = 46 });
            list.Add(new Student { Id = 4, Name = "Mehmet", Rank = 2, Age = 52 });


            var studentsOrderById = list.OrderByDescending(x => x.Id);
            Console.WriteLine("Sorted Students");
            foreach (var student in studentsOrderById)
            {
                Console.WriteLine(student.Name);
            }
            Console.ReadKey();
        }
    }
}