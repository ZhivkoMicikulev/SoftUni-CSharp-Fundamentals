using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            while(comand!="end")
            {
                string[] comandArr = comand.Split();
                if(comandArr[0]=="Add")
                {
                    string arrIndex = comandArr[1];
                    int index = int.Parse(arrIndex);
                    train.Add(index);
                }
                else
                {
                    int index = int.Parse(comand);
                    for (int i = 0; i <train.Count; i++)
                    {
                        if (index + train[i] <= capacity)
                        {
                            train[i] += index;
                            break;
                        }
                    }
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',train));
        }
    }
}
