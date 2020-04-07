using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int times = list.Count;
            string comand;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comandArr = comand.Split();
                string cmdArg = comandArr[0];
                int element = int.Parse(comandArr[1]);
                
                if(cmdArg=="Delete")
                {
                    list.RemoveAll(n=>n==element);
                }
                 if(cmdArg=="Insert")
                {
                    int position =int.Parse(comandArr[2]);
                    list.Insert(position, element);
                }



            }
            Console.WriteLine(string.Join(' ',list));
        }
   }
}
