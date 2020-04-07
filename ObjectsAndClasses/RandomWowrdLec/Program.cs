using System;
using System.Linq;

namespace RandomWowrdLec
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var list = Console.ReadLine().Split().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var randomIndex = random.Next(0, list.Count - 1);
                var randomElement = list[randomIndex];
                var el = list[i];
                list[randomIndex] = el;
                list[i] = randomElement;
            }
            foreach (var item in list)
            {
                Console.WriteLine(item );
            }
        }
    }
}
