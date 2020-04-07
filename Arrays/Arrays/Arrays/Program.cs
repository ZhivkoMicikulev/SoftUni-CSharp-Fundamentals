using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;
            for (int i = 0; i <wagons.Length; i++)
            {
                wagons[i] = i;
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            for (int i = 0; i < wagons.Length; i++)
            {
                Console.Write($"{wagons[i]}" + " ");
                
            }
            Console.WriteLine($"\n{sum}");
        }
    }
}
