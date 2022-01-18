using System;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 2, 3 , 4, 5, 6, 7};

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Reverse");

            var reverse = x.Reverse();

            foreach (var item2 in reverse)
            {
                Console.WriteLine(item2);
            }
        }
    }
}