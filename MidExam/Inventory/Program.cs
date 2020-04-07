using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string cmd;
            while ((cmd = Console.ReadLine()) != "Craft!")
            {
                string[] cmdArgs = cmd.Split(" - ").ToArray();
                string comand = cmdArgs[0];
                
                if(comand == "Collect")
                {
                    string item = cmdArgs[1];
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }
                }
                else if (comand== "Drop")
                {
                    string item = cmdArgs[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if(comand== "Combine Items")
                {
                    string[] combineItems = cmdArgs[1].Split(':').ToArray();
                    string oldItem = combineItems[0];
                    string newItem = combineItems[1];
                    if(items.Contains(oldItem))
                    {
                        int index = items.IndexOf(oldItem);
                        items.Insert(index + 1, newItem);
                    }
                }
                else if (comand== "Renew")
                {
                    string item = cmdArgs[1];
                    if(items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                }

            }
            Console.WriteLine(string.Join(", ",items));
        }
    }
}
