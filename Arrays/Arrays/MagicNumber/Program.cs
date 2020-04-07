using System;
using System.Linq;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j <numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == result)
                    {
                         Console.WriteLine(numbers[i] + " " + numbers[j]);
                        
                    }
                }
            }
        }
    }
}
