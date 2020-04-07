using System;
using System.Collections.Generic;
using System.Linq;

namespace Weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weapons = Console.ReadLine().Split('|').ToArray();
            string cmd;
            List<string> print = new List<string>();
            while ((cmd = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = cmd.Split().ToArray();
                string comand = cmdArgs[0];
                if (comand == "Move")
                {
                    Move(weapons, cmdArgs);
                }
                else if (comand=="Check")
                {
                    Check(weapons, print, cmdArgs);
                }
            }
            Console.Write("You crafted ");
            foreach (var item in weapons)
            {
                Console.Write(item);
            }
            Console.Write("!");
        }

        private static void Check(string[] weapons, List<string> print, string[] cmdArgs)
        {
            string kind = cmdArgs[1];
            if (kind == "Odd")
            {
                for (int i = 0; i < weapons.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        print.Add(weapons[i]);
                    }
                }
                Console.WriteLine(string.Join(' ', print));
                print.Clear();
            }
            else if (kind == "Even")
            {
                for (int i = 0; i < weapons.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        print.Add(weapons[i]);
                    }
                }
                Console.WriteLine(string.Join(' ', print));
                print.Clear();
            }
        }

        private static void Move(string[] weapons, string[] cmdArgs)
        {
            string direction = cmdArgs[1];
            int index = int.Parse(cmdArgs[2]);
            string temp = string.Empty;
            if (index >= 0 && index <= weapons.Length)
            {
                if (direction == "Right")
                {
                    if (index + 1 <= weapons.Length - 1)
                    {
                        temp = weapons[index];
                        weapons[index] = weapons[index + 1];
                        weapons[index + 1] = temp;
                    }
                }
                else if (direction == "Left")
                {
                    if (index - 1 >= 0)
                    {
                        temp = weapons[index];
                        weapons[index] = weapons[index - 1];
                        weapons[index - 1] = temp;
                    }
                }
            }
        }
    }
}
