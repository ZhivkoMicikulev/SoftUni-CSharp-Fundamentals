using System;

namespace ZigZagArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] redLine = new string[n];
            string[] blueLine = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    redLine[i] = input[0];
                    blueLine[i] = input[1];
                }
                else
                {
                    {
                        redLine[i] = input[1];
                        blueLine[i] = input[0];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", redLine));
            Console.WriteLine(string.Join(" ", blueLine));
        }
    }
}
