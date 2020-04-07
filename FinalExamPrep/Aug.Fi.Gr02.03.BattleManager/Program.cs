using System;
using System.Collections.Generic;
using System.Linq;

namespace Aug.Fi.Gr02._03.BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand;
            Dictionary<string, List<int>> book = new Dictionary<string, List<int>>();
            while ((comand=Console.ReadLine())!="Results")
            {
                string[] cmdArg = comand.Split(':');
                string cmd = cmdArg[0];
                if (cmd=="Add")
                {
                    string name = cmdArg[1];
                    int health = int.Parse(cmdArg[2]);
                    int energy = int.Parse(cmdArg[3]);
                    if (!book.ContainsKey(name))
                    {
                        book[name] = new List<int>();
                        book[name].Add(0);
                        book[name].Add(0);
                        book[name][0] += health;
                        book[name][1] += energy;
                    }
                    else
                    {
                        book[name][0] += health;
                    }
                }
                else if (cmd=="Attack")
                {
                    string attName = cmdArg[1];
                    string defName = cmdArg[2];
                    int damage = int.Parse(cmdArg[3]);
                    if (book.ContainsKey(attName) && book.ContainsKey(defName))
                    {
                        book[defName][0] -= damage;
                        book[attName][1] -= 1;
                        if (book[defName][0]<=0)
                        {
                            book.Remove(defName);
                            Console.WriteLine($"{defName} was disqualified!");
                        }
                        if (book[attName][1]<=0)
                        {
                            book.Remove(attName);
                            Console.WriteLine($"{attName} was disqualified!");
                        }
                    }
                }
                else if (cmd=="Delete")
                {
                    string username = cmdArg[1];
                    if (username=="All")
                    {
                        foreach (var item in book)
                        {
                            book.Remove(item.Key);
                        }
                    }
                    else
                    {
                        book.Remove(username);
                    }
                }
            }
            Console.WriteLine($"People count: {book.Count}");
            foreach (var item in book.OrderByDescending(h=>h.Value[0]).ThenBy(n=>n.Key) )
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");
            }
        }
    }
}
