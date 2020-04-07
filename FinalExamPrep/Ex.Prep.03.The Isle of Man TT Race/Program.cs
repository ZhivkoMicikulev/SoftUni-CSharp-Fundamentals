using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex.Prep._03.The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isIt = false;
            while (isIt==false)
            {
                string input = Console.ReadLine();
                string patern = @$"([#|$|%|*|&])(?<name>[A-Za-z]+)\1=(?<len>\d+)!!(?<code>.+)";
                Match valid = Regex.Match(input, patern);
                if (valid.Success)
                {
                    int lenght = int.Parse(valid.Groups["len"].ToString());
                    if (lenght==valid.Groups["code"].Length)
                    {
                        string mess = valid.Groups["code"].ToString();
                        List<char> message = new List<char>();
                        foreach (var item in mess)
                        {
                            message.Add((char)(item + lenght));
                        }
                        Console.WriteLine($"Coordinates found! {valid.Groups["name"]} -> {string.Join("", message)}");
                        isIt = true;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
               
            }
            

                
                
        }
    }
}
