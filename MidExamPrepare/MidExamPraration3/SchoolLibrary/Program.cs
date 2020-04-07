using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split('&').ToList();
            string cmd;
            while ((cmd=Console.ReadLine())!="Done")
            {
                string[] cmdArgs = cmd.Split(" | ").ToArray();
                string comand =cmdArgs[0];
                if(comand=="Add Book")
                {
                    string name = cmdArgs[1];
                    if (!books.Contains(name)) books.Insert(0, name);
                }
                else if(comand == "Take Book")
                {
                    string name = cmdArgs[1];
                    if (books.Contains(name)) books.Remove(name);
                }
                else if(comand=="Swap Books")
                {
                    string name1 = cmdArgs[1];
                    string name2 = cmdArgs[2];
                    int index1 = books.IndexOf(name1);
                    int index2 = books.IndexOf(name2);
                    if(books.Contains(name1) && books.Contains(name2))
                    {
                        books[index1] = name2;
                        books[index2] = name1;
                    }
                }
                else if (comand == "Insert Book")
                {
                    string name = cmdArgs[1];
                    if (!books.Contains(name)) books.Add(name);
                }
                else if(comand=="Check Book")
                {
                    int index = int.Parse(cmdArgs[1]);
                   if(index>=0&&index<books.Count-1)
                    {  
                        Console.WriteLine(books[index]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ",books));
        }
    }
}
