using System;

namespace DecRe._01.Nikulden_sCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string comand;
            while ((comand=Console.ReadLine())!="Finish")
            {
                string[] cmdArgs = comand.Split();
                string cmd = cmdArgs[0];
                if(cmd== "Replace")
                {
                    char currChar = char.Parse(cmdArgs[1]);
                    char newChar = char.Parse(cmdArgs[2]);
                    input = input.Replace(currChar, newChar);
                    Console.WriteLine(input);
                }
                else if(cmd== "Cut")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    
                    if(endIndex>=startIndex&&startIndex>=0&&startIndex<=input.Length-1&&endIndex<=input.Length-1)
                    {
                        input = input.Remove(startIndex, (endIndex+1) - startIndex);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if(cmd=="Make")
                {
                    string argS = cmdArgs[1];
                    if (argS == "Upper")
                    {
                        input = input.ToUpper();
                        Console.WriteLine(input);
                    }
                    else if (argS == "Lower")
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }
                }
                else if(cmd=="Check")
                {
                    string checkedString = cmdArgs[1];
                    if(input.Contains(checkedString))
                    {
                        Console.WriteLine($"Message contains {checkedString}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {checkedString}");
                    }
                }
                else if(cmd=="Sum")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    if (endIndex >= startIndex && startIndex >= 0 && startIndex <=input.Length - 1 && endIndex <= input.Length - 1)
                    {
                        string sumString = input.Substring(startIndex, (endIndex+1) - startIndex);
                        int sum = 0;
                        for (int i = 0; i < sumString.Length; i++)
                        {
                            sum += (char)sumString[i];
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
            }
        }
    }
}
