using System;
using System.Collections.Generic;
using System.Linq;

namespace WeaponSmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weapons = Console.ReadLine().Split('|').ToList();
            string cmd;
            while((cmd=Console.ReadLine())!="Done")
            {
                string[] cmdArgs = cmd.Split().ToArray();
                string comand = cmdArgs[0];
              if(comand=="Move")
                {
                    string direction = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);
                    if (index >= 0 && index <= weapons.Count)
                    {
                        if (direction == "Right")
                        {
                            if(index+1<=weapons.Count-1)
                            {
                                weapons.Insert(index + 1, weapons[index]);
                                weapons.RemoveAt(index);
                            }
                        }
                    }
                }
            }
        }
    }
}
