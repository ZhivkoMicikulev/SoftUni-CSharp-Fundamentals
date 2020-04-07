using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string comand;
            while((comand=Console.ReadLine())!="End")
            {
                string[] cmdArgs = comand.Split().ToArray();
                string cmdType = cmdArgs[0];
                    if (cmdType=="Add")
                {
                    int number = int.Parse(cmdArgs[1]);
                    list.Add(number);
                }
                    else if (cmdType=="Insert")
                {
                    Insert(list, cmdArgs);
                }
                else if (cmdType == "Remove")
                {
                    RemovAtIndex(list, cmdArgs);

                }
                else if (cmdType == "Shift")
                {
                    Shift(list, cmdArgs);
                }
            }
            Console.WriteLine(string.Join(' ',list));
        }

        private static void Insert(List<int> list, string[] cmdArgs)
        {
            int number = int.Parse(cmdArgs[1]);
            int index = int.Parse(cmdArgs[2]);
            if (index >= 0 && index < list.Count)
            {
                list.Insert(index, number);
            }
            else Console.WriteLine("Invalid index");
        }

        private static void Shift(List<int> list, string[] cmdArgs)
        {
            string direction = cmdArgs[1];
            int count = int.Parse(cmdArgs[2]);
            count = count % list.Count;
            if (direction == "left")
            {
                ShiftLeft(list, count);
            }
            else if (direction == "right")
            {
                ShiftRight(list, count);
            }
        }

        private static void ShiftLeft(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstEl = list[0];
                list.RemoveAt(0);
                list.Add(firstEl);
            }
        }

        private static void ShiftRight(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastEl = list[list.Count - 1 ];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, lastEl);
            }
        }

        private static void RemovAtIndex(List<int> list, string[] cmdArgs)
        {
            int index = int.Parse(cmdArgs[1]);
            if (index < 0 || index > list.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                list.RemoveAt(index);
            }
        }
    }
}
