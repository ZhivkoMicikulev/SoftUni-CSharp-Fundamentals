using System;

namespace _02.CharacterMultiplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];
            int shortest= Math.Min(first.Length, second.Length);
            int biger = Math.Max(first.Length, second.Length);
            int totalSum = 0;
           
            for (int i = 0; i <shortest; i++)
            {
                totalSum += first[i] * second[i];
            }
            for (int i = shortest; i < biger; i++)
            {
                if (first.Length > second.Length) totalSum += first[i];
                else totalSum += second[i];
            }
            Console.WriteLine(totalSum);
        }
    }
}
