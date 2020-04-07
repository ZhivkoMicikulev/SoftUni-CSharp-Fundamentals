using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> db = new Dictionary<string, string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string cmdArg = cmd[0];
                if(cmdArg=="register")
                {
                    string userName = cmd[1];
                    string plate = cmd[2];
                    if(!db.ContainsKey(userName))
                    {
                        db[userName] = plate;
                        Console.WriteLine($"{userName} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {db[userName]}");
                    }
                }
                else if(cmdArg == "unregister")
                {
                    string userName = cmd[1];
                    if(!db.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        db.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in db)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
