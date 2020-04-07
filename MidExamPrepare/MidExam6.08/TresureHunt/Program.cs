using System;
using System.Collections.Generic;
using System.Linq;

namespace TresureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> loots = Console.ReadLine().Split('|').ToList();
            string cmd;
            while((cmd=Console.ReadLine())!= "Yohoho!")
            {
                string[] cmdArgs = cmd.Split().ToArray();
                string comand = cmdArgs[0];
                if(comand=="Loot")
                {
                    for (int i = 1; i <cmdArgs.Length; i++)
                    {
                        string name = cmdArgs[i];
                        if(!loots.Contains(name))
                        {
                            loots.Insert(0, name);
                        }
                    }
                   
                }
                else if(comand== "Drop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    
                    if (index >= 0 && index < loots.Count)
                    {
                        string name = loots[index];
                        loots.RemoveAt(index);

                        loots.Add(name);
                    }
                }
                else if(comand== "Steal")
                {
                    int count = int.Parse(cmdArgs[1]);
                    List<string> stealedItems = new List<string>();
                    if (count > loots.Count) count = loots.Count;
                    for (int i = 0; i < count; i++)
                    {
                        stealedItems.Add(loots[loots.Count - 1 ]);
                        loots.RemoveAt(loots.Count - 1 );
                    }
                    stealedItems.Reverse();
                    Console.WriteLine(string.Join(", ",stealedItems));
                }

            }
            double sum = 0;
            for (int i = 0; i < loots.Count; i++)
            {
                char[] price=loots[i].ToArray();
                sum += price.Length;
            }
            double finalSum = sum / loots.Count;
            if(loots.Count>0) Console.WriteLine($"Average treasure gain: {(decimal)finalSum:f2} pirate credits.");
            else Console.WriteLine("Failed treasure hunt.");
        }
    }
}
