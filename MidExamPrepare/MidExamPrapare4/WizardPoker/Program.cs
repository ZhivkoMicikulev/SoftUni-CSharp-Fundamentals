using System;
using System.Collections.Generic;
using System.Linq;

namespace WizardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(':').ToList();
            List<string> print = new List<string>();
            string cmd;
            while ((cmd=Console.ReadLine())!="Ready")
            {
                string[] cmdArgs = cmd.Split().ToArray();
                string comand = cmdArgs[0];
                if (comand == "Add")
                {
                    string cardName = cmdArgs[1];
                    if (cards.Contains(cardName)) print.Add(cardName);
                    else Console.WriteLine("Card not found.");
                }
                else if (comand == "Insert")
                {
                    string cardName = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);
                    if (!cards.Contains(cardName) || index > print.Count - 1) Console.WriteLine("Error!");
                    else print.Insert(index, cardName);
                }
                else if (comand == "Remove")
                {
                    string cardName = cmdArgs[1];
                    if (print.Contains(cardName)) print.Remove(cardName);
                    else Console.WriteLine("Card not found.");
                }
                else if (comand == "Swap")
                {
                    string cardName1 = cmdArgs[1];
                    string cardName2 = cmdArgs[2];
                    int index1 = print.IndexOf(cardName1);
                    int index2 = print.IndexOf(cardName2);
                    string temp1 = print[index1];
                    string temp2 = print[index2];
                    print.Remove(cardName1);
                    print.Remove(cardName2);
                    print.Insert(index1, temp2);
                    print.Insert(index2, temp1);
                }
                else if (comand == "Shuffle") print.Reverse();
            }
            Console.WriteLine(string.Join(' ',print));

        }
    }
}
