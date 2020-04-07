using System;
using System.Collections.Generic;
using System.Linq;

namespace Aug._03.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            var followers = new Dictionary<string, int>();
            string comand;
            while ((comand = Console.ReadLine()) != "Log out")
            {
                string[] cmdArgs = comand.Split(':',StringSplitOptions.RemoveEmptyEntries);
                string cmd = cmdArgs[0].Trim();
                if (cmd== "New follower")
                {
                    string username  = cmdArgs[1].Trim();
                    if(!followers.ContainsKey(username))
                    {
                        followers[username] = 0;
                    }
                }
                else if (cmd== "Like")
                {
                    string username = cmdArgs[1].Trim();
                    int count = int.Parse(cmdArgs[2]);
                    if (!followers.ContainsKey(username))
                    {
                        followers[username] =0;
                    }
                    followers[username]+=count;
                }
                else if (cmd== "Comment")
                {
                    string username = cmdArgs[1].Trim();
                    if (!followers.ContainsKey(username))
                    {
                        followers[username] = 0;
                    }
                    followers[username]++;
                }
                else if (cmd== "Blocked")
                {
                    string username = cmdArgs[1].Trim();
                    if (followers.ContainsKey(username))
                    {
                        followers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }
            }
            Console.WriteLine($"{followers.Count} followers");
            foreach (var follower in followers.OrderByDescending(l=>l.Value).ThenBy(f=>f.Key))
            {
                Console.WriteLine($"{follower.Key}: {follower.Value}");
            }
        }
    }
}
