using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split('|').ToArray();
            List<string> list = new List<string>();
            for (int i = 0; i <line.Length; i++)
            {
                string[] newLine = line[line.Length-(1+i)].Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < newLine.Length; j++)
                {
                    list.Add(newLine[j]);
                }
            }
            Console.WriteLine(string.Join(' ', list));
          
        }
    }
}
