using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            int health = int.Parse(Console.ReadLine());
            string cmd;
            while ((cmd = Console.ReadLine()) != "Retire")
            {
                string[] cmdArgs = cmd.Split().ToArray();
                string comand = cmdArgs[0];
                if(comand== "Fire")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int damage =int.Parse(cmdArgs[2]);
                    if(index>=0 &&index<warShip.Count)
                    {
                        warShip[index] -= damage;
                        if(warShip[index]<=0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            break;
                        }
                    }
                   
                }
                else if(comand=="Defend")
                {
                    int startIndex =int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int damage = int.Parse(cmdArgs[3]);
                    if(startIndex>=0 &&startIndex<pirateShip.Count && endIndex>=0 &&endIndex<pirateShip.Count)
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if(pirateShip[i]<=0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                break;
                            }
                        }
                        
                    }
                }
                else if(comand== "Repair")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int heal = int.Parse(cmdArgs[2]);
                    if(index>=0 && index<pirateShip.Count)
                    {
                        pirateShip[index] += heal;
                        if ((pirateShip[index] + heal) > health) pirateShip[index] = health;
                    }
                }
                else if (comand=="Status")
                {
                    int count = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < health * 0.2) count++;
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
            }
            if(cmd=="Retire")
            {
                int sumPirate = 0;
                int sumWar = 0;
                for (int i = 0; i < pirateShip.Count; i++)
                {
                    sumPirate += pirateShip[i];
                }
                for (int i = 0; i < warShip.Count; i++)
                {
                    sumWar += warShip[i];
                }
                Console.WriteLine($"Pirate ship status: {sumPirate}");
                Console.WriteLine($"Warship status: {sumWar}");
            }

        }
    }
}
