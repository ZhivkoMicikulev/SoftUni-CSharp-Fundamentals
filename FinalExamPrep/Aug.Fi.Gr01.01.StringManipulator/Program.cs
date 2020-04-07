using System;

namespace Aug.Fi.Gr01._01.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = comand.Split();
                string cmd = cmdArgs[0];
                if (cmd == "Translate")
                {
                    char symbol = char.Parse(cmdArgs[1]);
                    char reSymbol = char.Parse(cmdArgs[2]);
                    input = input.Replace(symbol, reSymbol);
                    Console.WriteLine(input);
                }
                else if (cmd == "Includes")
                {
                    string inputString = cmdArgs[1];
                    if (input.Contains(inputString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmd== "Start")
                {
                    string inputString = cmdArgs[1];
                    if (input.StartsWith(inputString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmd== "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (cmd== "FindIndex")
                {
                    char search =char.Parse(cmdArgs[1]);
                    int lastIndex = input.LastIndexOf(search);
                    Console.WriteLine(lastIndex);
                }
                else if (cmd== "Remove")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }
              

                   
            }
        }
    }
}
