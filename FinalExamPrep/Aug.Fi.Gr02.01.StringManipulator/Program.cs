using System;

namespace Aug.Fi.Gr02._01.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string comand;
            while ((comand=Console.ReadLine())!="Done")
            {
                string[] cmdArg = comand.Split();
                string cmd = cmdArg[0];
                if (cmd=="Change")
                {
                    char symbol = char.Parse(cmdArg[1]);
                    char replace =char.Parse(cmdArg[2]);
                    input = input.Replace(symbol, replace);
                    Console.WriteLine(input);
                }
                else if (cmd=="Includes")
                {
                    string include = cmdArg[1];
                    if (input.Contains(include))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmd=="End")
                {
                    string end = cmdArg[1];
                    if(input.EndsWith(end))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmd=="FindIndex")
                {
                    char symbol = char.Parse(cmdArg[1]);
                    int first = input.IndexOf(symbol);
                    Console.WriteLine(first);
                }
                else if (cmd=="Cut")
                {
                    int start = int.Parse(cmdArg[1]);
                    int lenght = int.Parse(cmdArg[2]);
                    input = input.Substring(start, lenght);
                    Console.WriteLine(input);
                }
                else if (cmd=="Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
            }
        }
    }
}
