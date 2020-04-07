using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string tex = Console.ReadLine().ToLower();
            string text = Console.ReadLine();
            while(text.Contains(tex))
            {
                int start = text.IndexOf(tex);
              text =  text.Remove(start, tex.Length);

            }
            Console.WriteLine(text);
        }
    }
}
