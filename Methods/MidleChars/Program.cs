using System;

namespace MidleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line = Console.ReadLine();
            TheMidle(line);
        }
        static void TheMidle(string line)
        {

            if (line.Length % 2 != 0)
            {
                char  midle =line[(line.Length - 1) / 2];
                Console.WriteLine(midle);
            }
            else
            {
                char midle1 = (line[line.Length/2]);
                char midle2 = (line[(line.Length/2)-1]);
                Console.WriteLine($"{midle2}{midle1}");
                
            }
        }
    }
}
