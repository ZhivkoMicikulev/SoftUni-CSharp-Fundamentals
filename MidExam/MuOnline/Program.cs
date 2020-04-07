using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|').ToArray();
            int health = 100;
            int bitcoins = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] things = rooms[i].Split().ToArray();
                string tokens = things[0];
                if (tokens == "potion")
                {
                    int heal = int.Parse(things[1]);
                    if (health + heal > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                        
                    }


                    else
                    {
                        health += heal;
                        Console.WriteLine($"You healed for {heal} hp.");
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (tokens == "chest")
                {
                    int coins = int.Parse(things[1]);
                    bitcoins += coins;
                    Console.WriteLine($"You found {coins} bitcoins.");
                }
                else
                {
                    int damage = int.Parse(things[1]);
                    health -= damage;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {tokens}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {tokens}.");
                        Console.WriteLine($"Best room: {i+1}");
                        break;
                    }
                }
            }
            if(health>0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
            
        }
    }
}
