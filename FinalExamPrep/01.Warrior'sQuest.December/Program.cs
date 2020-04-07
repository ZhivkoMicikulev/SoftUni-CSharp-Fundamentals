using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Warrior_sQuest.December
{
    class Program
    {
        static void Main(string[] args)
        {
            string gladiator = Console.ReadLine();
            string comand;
            while ((comand = Console.ReadLine()) != "For Azeroth")
            {
                string[] cmdArg = comand.Split();
                string cmd = cmdArg[0];
                if (cmd == "GladiatorStance")
                {
                    gladiator = gladiator.ToUpper();
                    Console.WriteLine(gladiator);   
                }
                else if (cmd == "DefensiveStance")
                {
                    gladiator = gladiator.ToLower();
                    Console.WriteLine(gladiator);
                }
                else if (cmd == "Dispel")
                {
                    int index = int.Parse(cmdArg[1]);
                    if (index >= 0 && index <= gladiator.Length - 1)
                    {
                        char letter = char.Parse(cmdArg[2]);
                        char[] temp = gladiator.ToCharArray();
                        temp[index] = letter;

                        gladiator = new string(temp);
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (cmd== "Target")
                {
                    string arg = cmdArg[1];
                    if(arg=="Change")
                    {
                        string firstSub = cmdArg[2];
                        string secondSub = cmdArg[3];
                        if (gladiator.Contains(firstSub))
                        {
                            gladiator = gladiator.Replace(firstSub, secondSub);
                            Console.WriteLine(gladiator);
                        }
                    }
                   else if(arg=="Remove")
                    {
                        string sub = cmdArg[2];
                        if (gladiator.Contains(sub))
                        {
                            int startIndex = gladiator.IndexOf(sub);
                            gladiator = gladiator.Remove(startIndex, sub.Length);
                            Console.WriteLine(gladiator);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                    
                }
                else Console.WriteLine("Command doesn't exist!");
            }
           
        }
    }
}

      
    
