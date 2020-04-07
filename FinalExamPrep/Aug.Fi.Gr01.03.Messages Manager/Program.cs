using System;
using System.Collections.Generic;
using System.Linq;

namespace Aug.Fi.Gr01._03.Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Dictionary<string, List<int>>();
            string comand;
            int capacity = int.Parse(Console.ReadLine());
            while ((comand = Console.ReadLine()) != "Statistics")
            {
                string[] cmdArgs = comand.Split('=');
                string cmd = cmdArgs[0];
                if (cmd == "Add")
                {
                    string username = cmdArgs[1];
                    int send = int.Parse(cmdArgs[2]);
                    int received = int.Parse(cmdArgs[3]);
                    if (!message.ContainsKey(username))
                    {
                        message[username] = new List<int>();
                        message[username].Add(send);
                        message[username].Add(received);
                    }

                }
                else if (cmd == "Message")
                {
                    string sender = cmdArgs[1];
                    string receiver = cmdArgs[2];
                    if (message.ContainsKey(sender) && message.ContainsKey(receiver))
                    {
                        message[sender][0]++;
                        message[receiver][1]++;

                        if (message[sender][0]+message[sender][1] >= capacity)
                        {
                            message.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (message[receiver][1]+message[receiver][0] >= capacity)
                        {
                            message.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }

                    }

                }
                else if (cmd == "Empty")
                {
                    string user = cmdArgs[1];
                    if (message.ContainsKey(user))
                    {
                        message.Remove(user);
                    }
                    else if (user == "All")
                    {
                        foreach (var item in message)
                        {
                            message.Remove(item.Key);
                        }
                    }
                }
            }
            Console.WriteLine($"Users count: {message.Count}");
            foreach (var user in message.OrderByDescending(m=>m.Value[1]).ThenBy(u=>u.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value[0]+user.Value[1]}");
            }
        }
    }
}
