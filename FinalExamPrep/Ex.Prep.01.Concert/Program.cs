using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex.Prep._01.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand;
            Dictionary<string, List<string>> concert = new Dictionary<string, List<string>>();
            Dictionary<string, int> time = new Dictionary<string, int>();
            int totalTime = 0;
            while ((comand=Console.ReadLine())!= "start of concert")
            {
                string[] cmdArg = comand.Split(';',StringSplitOptions.RemoveEmptyEntries);
                string[] members = cmdArg[2].Split(',', StringSplitOptions.RemoveEmptyEntries);
                string cmd = cmdArg[0];
              
                if (cmd=="Add")
                {
                    string bandName = cmdArg[1].Trim();
                    if (!concert.ContainsKey(bandName))
                    {
                        concert[bandName] = new List<string>();
                        time[bandName] = 0;
                    }
                    for (int i = 0; i < members.Length; i++)
                    {
                        string member = members[i].Trim();
                        if (!concert[bandName].Contains(member))
                        {
                            concert[bandName].Add(member);
                        }
                    }
                }
                else if (cmd=="Play")
                {
                    string bandName = cmdArg[1].Trim();
                    int timeSong = int.Parse(cmdArg[2].Trim());
                    if (!concert.ContainsKey(bandName))
                    {
                        concert[bandName] = new List<string>();
                        time[bandName] = 0;
                    }
                    time[bandName] += timeSong;
                    totalTime += timeSong;
                }
            }
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var timeSongs in time.OrderByDescending(t=>t.Value).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{timeSongs.Key} -> {timeSongs.Value}");
            }
            string bandNameInput = Console.ReadLine();
            Console.WriteLine(bandNameInput);
            for (int i = 0; i < concert[bandNameInput].Count; i++)
            {
                Console.WriteLine($"=> {concert[bandNameInput][i]}");
            }
        }
    }
}
