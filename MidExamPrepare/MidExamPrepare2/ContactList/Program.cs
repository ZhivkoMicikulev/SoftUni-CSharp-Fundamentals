using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split().ToList();
            List<string> print = new List<string>();
            string[] cmdArgs = Console.ReadLine().Split().ToArray();
            while (cmdArgs[0]!="Print")
            {
                
                string comand = cmdArgs[0];
                if (comand == "Add")
                {
                    int index = int.Parse(cmdArgs[2]);
                    string name = cmdArgs[1];
                    if (!contacts.Contains(name)) contacts.Add(name);
                    else
                    {
                        if (index >= 0 && index <= contacts.Count - 1)
                        {
                            contacts.Insert(index, name);

                        }
                    }

                }
                else if(comand=="Remove")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index <= contacts.Count - 1) contacts.RemoveAt(index);
                }
                else if(comand=="Export")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                        int count = int.Parse(cmdArgs[2]);
                    if(startIndex>=0 && startIndex<=contacts.Count-1 && count>0)
                    {
                        if (count > contacts.Count-1) count = contacts.Count-1;
                    }
                    print = contacts.Skip(startIndex).Take(count).Select(x => x).ToList();
                    Console.WriteLine(string.Join(' ',print));
                    print.Clear();
                }
                cmdArgs = Console.ReadLine().Split().ToArray();
            }
            if (cmdArgs[1] == "Reversed") contacts.Reverse();
            Console.WriteLine($"Contacts: {string.Join(' ',contacts)}");
        }
    }
}


