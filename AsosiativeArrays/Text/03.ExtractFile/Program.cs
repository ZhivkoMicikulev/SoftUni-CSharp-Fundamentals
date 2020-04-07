using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] location = Console.ReadLine().Split((char)92);
            string[] file = location[location.Length - 1].Split('.');
            string name = file[0].ToString();
            string kind = file[1].ToString();
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {kind}");
        }
    }
}
