using System;
using System.Linq;

namespace Aug._01.Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string comand;
            while ((comand = Console.ReadLine()) != "Sign up")
            {
                string[] cmdArgs = comand.Split();
                string cmd = cmdArgs[0];
                if (cmd == "Case")
                {
                    string size = cmdArgs[1];
                    if(size=="lower")
                    {
                        username = username.ToLower();
                        Console.WriteLine(username);
                    }
                    else if(size=="upper")
                    {
                        username = username.ToUpper();
                        Console.WriteLine(username);
                    }
                }
                else if(cmd=="Reverse")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                   if(startIndex<=endIndex && startIndex>=0 && startIndex<=username.Length-1 && endIndex>=0 && endIndex<=username.Length-1)
                    {
                        string take = username.Substring(startIndex, ((endIndex + 1) - startIndex));
                        char[] reversed = take.Reverse().ToArray();
                        Console.WriteLine(string.Join("",reversed)); 
                    }
                    
                }
                else if(cmd== "Replace")
                {
                    char symbol = char.Parse(cmdArgs[1]);
                    username = username.Replace(symbol, '*');
                    Console.WriteLine(username);
                }
                else if (cmd=="Check")
                {
                    char symbol = char.Parse(cmdArgs[1]);
                    if(username.Contains(symbol))
                    {
                        Console.WriteLine("Valid");
                    }
                    else 
                    {
                        Console.WriteLine($"Your username must contain {symbol}.");
                    }
                }
                else if (cmd=="Cut")
                {
                    string sub= cmdArgs[1];
                    if (username.Contains(sub))
                    {
                        username = username.Replace(sub,"");
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {sub}.");
                    }
                }
            }
        }
    }
}
