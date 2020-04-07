using System;
using System.Collections.Generic;
using System.Linq;

namespace FoggySqad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogNames = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] cmd = Console.ReadLine().Split().ToArray();
            List<string> empty = new List<string>();
            while (cmd[0]!="Print")
            {
                if (cmd[0] == "Join")
                {
                    string name = cmd[1];
                    if (!frogNames.Contains(name)) frogNames.Add(name);
                    
                }
                else if (cmd[0] == "Jump")
                {
                    string name = cmd[1];
                    int index = int.Parse(cmd[2]);
                    if (index < frogNames.Count - 1 && index>=0) frogNames.Insert(index, name);
                     
                }
                else if (cmd[0] == "Dive")
                {
                    int index = int.Parse(cmd[1]);
                    if (index < frogNames.Count - 1 && index>=0) frogNames.RemoveAt(index);
                   
                }
                else if (cmd[0] == "First")
                {
                    
                    int count = int.Parse(cmd[1]);
                    if (count > frogNames.Count) count = frogNames.Count;
                    empty=frogNames.Take(count).Select(x=>x).ToList();
                    Console.WriteLine(string.Join(' ', empty));
                }
                else if (cmd[0] == "Last")
                {
                    
                    int count = int.Parse(cmd[1]);
                    if (count > frogNames.Count) count = frogNames.Count;
                    frogNames.Reverse();
                    empty =frogNames.Take(count).Select(x=>x).ToList();
                    empty.Reverse();
                    frogNames.Reverse();
                    Console.WriteLine(string.Join(' ', empty));
                }
                cmd = Console.ReadLine().Split().ToArray();
            }
            if (cmd[1]=="Reversed")
            {
                frogNames.Reverse();
            }
         
            Console.WriteLine($"Frogs: {string.Join(' ', frogNames)}");

        }
    }
}
