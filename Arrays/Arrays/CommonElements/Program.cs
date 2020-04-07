using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string[] first = firstLine.Split();
            string[] second = secondLine.Split();
            var inspect = first.Intersect(second);
            foreach (var value in inspect)
            {
                Console.Write(value+" ");
            }
        }
    }
}
