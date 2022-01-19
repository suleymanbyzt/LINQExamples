using System;

namespace Path
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\windows";
            ShowLargeFilesWithLinq(path);

            List<string> files = new List<string>();    
        }

        private static void ShowLargeFilesWithLinq(string path)
        {
            var query = new DirectoryInfo(path).GetFiles()
                .OrderByDescending(f => f.Length)
                .Take(10);

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name,-20} : {item.Length , 10}");
            }
        }
    }
}