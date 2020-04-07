using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string comand;
            while ((comand = Console.ReadLine())!="Generate")
            {
                string[] cmdArg = comand.Split(">>>");
                string cmd = cmdArg[0];
                if (cmd=="Contains")
                {
                    string substring = cmdArg[1];
                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (cmd=="Flip")
                {
                    string size = cmdArg[1];
                    int startIndex = int.Parse(cmdArg[2]);
                    int endIndex = int.Parse(cmdArg[3]);
                   
                    if (size=="Upper")
                    {
                        string formalKey = string.Empty;
                        for (int i = 0; i < key.Length; i++)
                        {
                            if (char.IsLetter(key[i]) && i >=startIndex && i<endIndex)
                            {
                                formalKey += key[i].ToString().ToUpper();
                            }
                            else
                            {
                                formalKey += key[i].ToString();
                            }
                        }
                        key = formalKey;
                        Console.WriteLine(key);
                    }
                   else if (size == "Lower")
                   {
                        string formalKey = string.Empty;
                        for (int i = 0; i < key.Length; i++)
                        {
                            
                            if (char.IsLetter(key[i]) && i >= startIndex && i < endIndex)
                            {
                                formalKey += key[i].ToString().ToLower();
                            }
                            else
                            {
                                formalKey += key[i].ToString();
                            }
                        }
                        key = formalKey;
                        Console.WriteLine(key);
                   }
                }
                else if (cmd=="Slice")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    key = key.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(key);
                }
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
