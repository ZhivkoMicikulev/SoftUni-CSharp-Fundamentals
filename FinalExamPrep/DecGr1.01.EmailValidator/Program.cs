using System;
using System.Collections.Generic;

namespace DecGr1._01.EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string comand;
            while ((comand=Console.ReadLine())!="Complete")
            {
                string[] cmdArgs = comand.Split();
                string cmd = cmdArgs[0];
                if(cmd=="Make")
                {
                    string size = cmdArgs[1];
                    if(size=="Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }
                    else
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }
                }
                else if(cmd=="GetDomain")
                {
                    int count = int.Parse(cmdArgs[1]);
                    
                    Console.WriteLine(email.Substring(email.Length-count,count));
                }
                else if(cmd=="GetUsername")
                {
                    if (email.Contains('@'))
                    {
                        int indexOfkl = email.IndexOf('@');
                        Console.WriteLine(email.Substring(0,indexOfkl));
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }  
                }
                else if (cmd=="Replace")
                {
                    char symbol = char.Parse(cmdArgs[1]);
                   email= email.Replace(symbol, '-');
                    Console.WriteLine(email);
                }
                else if (cmd=="Encrypt")
                {
                    List<int> cryptemMail = new List<int>();
                    for (int i = 0; i < email.Length; i++)
                    {
                        cryptemMail.Add(email[i]);
                    }
                    Console.WriteLine(string.Join(' ',cryptemMail));
                }

                   

                
            }
        }
    }
}
