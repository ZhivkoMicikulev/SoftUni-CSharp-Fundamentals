using System;

namespace SumChar
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= num; i++)
            {
                char sym= char.Parse(Console.ReadLine());
                sum += sym;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
