using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ex.Prep._02.SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string patern = @"^(?<art>[A-Z][a-z' ]+)[:](?<song>[A-Z ]+)$";
            while ((input=Console.ReadLine())!="end")
            {
                
                Match valid = Regex.Match(input, patern);
                if (valid.Success)
                {
                    List<char> encrypt = new List<char>();
                    for (int i = 0; i <input.Length; i++)
                    {
                        if (char.IsLetter(input[i]))
                        {
                            char temp =input[i];
                            char newChar = new char();
                            int key = valid.Groups["art"].Length;
                            if ((temp+key>=65 && temp+key<=90)|| (temp +key>= 97 && temp +key<=122))
                            {
                                if (temp >= 65 && temp<= 90)
                                {
                                    if (temp+key>90)
                                    {
                                        newChar = (char)(64 + ((temp + key) - 90));
                                    }
                                    else
                                    {
                                        newChar = (char)(temp + key);
                                    } 
                                }
                                else if (temp>= 97 && temp<= 122)
                                {
                                    if (temp + key > 122)
                                    {
                                        newChar = (char)(96 + ((temp + key) - 122));
                                    }
                                    else
                                    {
                                        newChar = (char)(temp + key);
                                    }
                                }
                               
                                
                            }
                            else
                            {
                                if (temp>= 65 && temp <= 90)
                                {
                                    newChar = (char)(64 + ((temp + key) - 90));
                                }
                                else if (temp>= 97 && temp<= 122)
                                {
                                    newChar = (char)(96 + ((temp + key) - 122));
                                }
                               
                            }
                            encrypt.Add(newChar);
                        }
                        if (input[i]==':'|| input[i]=='\''||input[i]==' ')
                        {
                            if (input[i]==':')
                            {
                                encrypt.Add('@');
                            }
                            else if(input[i]=='\'')
                            {
                                encrypt.Add('\'');
                            }
                            else
                            {
                                encrypt.Add(' ');
                            }
                        }
                    }
                    Console.WriteLine($"Successful encryption: {string.Join("",encrypt)}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
