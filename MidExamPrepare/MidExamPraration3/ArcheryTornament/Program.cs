using System;
using System.Collections.Generic;
using System.Linq;

namespace ArcheryTornament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split('|').Select(int.Parse).ToArray();
            string cmd;
            int points = 0;
            while ((cmd = Console.ReadLine()) != "Game over")
            {
                string[] cmdArg = cmd.Split('@').ToArray();
                string comand = cmdArg[0];
                if(comand=="Shoot Right")
                {
                    int index = int.Parse(cmdArg[1]);
                    int lenght = int.Parse(cmdArg[2]);
                    if (index>=0 && index<=targets.Length-1)
                    {
                        
                        int indexTarger = (lenght - (targets.Length - (index))) % targets.Length;
                        if(targets[indexTarger]>0)
                        {
                            if(targets[indexTarger] < 5)
                            {
                                points += targets[indexTarger];
                                targets[indexTarger] = 0;
                                
                            }
                            else
                            {
                                points += 5;
                                targets[indexTarger] -= 5;
                                
                            }
                               
                        }
                        
                       
                    }
                }
                else if(comand == "Shoot Left")
                {
                    int index = int.Parse(cmdArg[1]);
                    int lenght = int.Parse(cmdArg[2]);
                    if (index >= 0 && index <= targets.Length - 1)
                    {
                        
                        int indexTarger=((lenght-(targets.Length-(targets.Length-index)))%targets.Length)+1;
                        if (targets[indexTarger] > 0)
                        {
                            if (targets[indexTarger] < 5)
                            {
                                points += targets[indexTarger];
                                targets[indexTarger] = 0;
                                
                            }
                            else
                            {
                                targets[indexTarger] -= 5;
                                points += 5;
                            }

                        }
                    }
                }
                else
                {
                    Array.Reverse(targets, 0, targets.Length);
                }
            }
            
            Console.WriteLine(string.Join(" - ",targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
