using System;
using System.Collections.Generic;
using System.Linq;

namespace DecGr1._03.InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> mailbox = new Dictionary<string, List<string>>(); 
            string comand;
            while ((comand=Console.ReadLine())!= "Statistics")
            {
                string[] cmdArgs = comand.Split("->");
                string cmd = cmdArgs[0];
                if (cmd == "Add")
                {
                    string username = cmdArgs[1];
                    if(mailbox.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        mailbox[username] = new List<string>();
                    }
                }
                else if(cmd=="Send")
                {
                    string username = cmdArgs[1];
                    string email = cmdArgs[2];
                    mailbox[username].Add(email);
                }
                else if(cmd=="Delete")
                {
                    string username = cmdArgs[1];
                    if(mailbox.ContainsKey(username))
                    {
                        mailbox.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }

                }
            }
            Console.WriteLine($"Users count: {mailbox.Keys.Count}");
            foreach (var mail in mailbox.OrderByDescending(m=>m.Value.Count).ThenBy(u=>u.Key))
            {
                Console.WriteLine(mail.Key);
                foreach (var item in mail.Value)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }
    }
}
