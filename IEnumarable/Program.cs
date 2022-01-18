using System;
using System.Collections;

namespace IEnumrable 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14
            };

            IEnumerable<int> list= from x in numbers
                                   where x>5
                                   select x;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}