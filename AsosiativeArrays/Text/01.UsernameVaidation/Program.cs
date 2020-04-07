using System;

namespace _01.UsernameVaidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            for (int i = 0; i < usernames.Length; i++)
            {
                string currentName = usernames[i];
                bool valid = true;
                bool content = true;
                if(currentName.Length<3 || currentName.Length>16)
                {
                    valid = false;
                }
                for (int j = 0; j < currentName.Length; j++)
                {
                    char currSymbol = currentName[j];
                    if(!char.IsLetterOrDigit(currSymbol) && currSymbol !='-' && currSymbol != '_')
                    {
                        content = false;
                        break;
                    }
                }
                if(valid==true && content==true )
                {
                    Console.WriteLine(currentName);
                }
            }
        }
    }
}
