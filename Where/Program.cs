using System;

namespace Where // Note: actual namespace depends on the project name.
{

    public class Course
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int Rank { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
           List<Course> list = new List<Course>();
            list.Add(new Course { Id = 1, Subject = "LINQ Tutorials", Rank = 5 });
            list.Add(new Course { Id = 2, Subject = ".Net Tutorials", Rank = 4 });
            list.Add(new Course { Id = 3, Subject = "C# Tutorials", Rank = 3 });
            list.Add(new Course { Id = 4, Subject = "For Test", Rank = 1 });

            //var result = from course in list
            //             where course.Rank >3
            //             select course;

            //var result = list.Where(r => r.Rank > 3);

            var result = list.Where(x => x.Rank > 3 || x.Subject.Contains("Test"));

            foreach (var item in result)
            {
                Console.WriteLine(item.Subject);
            }
            
            Console.ReadKey();
        }
    }
}