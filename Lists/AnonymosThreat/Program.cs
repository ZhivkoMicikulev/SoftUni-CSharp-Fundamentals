using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymosThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine().Split().ToList();
            
            string comand;
            while ((comand = Console.ReadLine()) != "3:1")
            {
                string[] comandArr = comand.Split().ToArray();
                string cmdArg = comandArr[0];
                int counter = line.Count;
                if (cmdArg=="merge")
                {
                    Merge(line, comandArr, counter);
                }
                else if(cmdArg=="divide")
                {
                    int index = int.Parse(comandArr[1]);
                    int partition = int.Parse(comandArr[2]);
                    char[] word= line[index].ToCharArray();
                    int times = word.Length / partition;
                    List<string> empty = new List<string>();

                    for (int i = 0; i < partition; i+=partition)
                    {

                    }
                   
                    
                }

            }
            Console.WriteLine(string.Join(' ',line));
        }

        private static void Merge(List<string> line, string[] comandArr, int counter)
        {
            int startIndex = int.Parse(comandArr[1]);
            int finalIndex = int.Parse(comandArr[2]);
            for (int i = startIndex; i < finalIndex; i++)
            {
                if (i + 1 >= counter) break;
                line[startIndex] += line[startIndex + 1];
                line.RemoveAt(startIndex + 1);
            }
        }
    }
}
