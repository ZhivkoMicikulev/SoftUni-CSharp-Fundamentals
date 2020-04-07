using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static int trueCounter = 0;
        static void Main(string[] args)
        {
            string pass = Console.ReadLine().ToLower();
            Passlenght(pass);
            OnlyLetersAndDigits(pass);
            FindDigits(pass);
            
            if (trueCounter == 2) Console.WriteLine("Password is valid");
            

        }

        static void Passlenght(string pass)
        {
            int passLenght= 0;
            for (int i = 1; i <= pass.Length; i++)
            {
                passLenght++;
            }
            if (passLenght < 6 || passLenght > 10) Console.WriteLine("Password must be between 6 and 10 characters");
            else
            {
                trueCounter++;
                return;
            }
        }

        static void FindDigits(string pass)
        {
            int digitCounter = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >=49 && pass[i] <= 57) digitCounter++;
            }
            if (digitCounter < 2) Console.WriteLine("Password must have at least 2 digits");
            else
            {
                trueCounter++;
                return;
            }
        }

        static void OnlyLetersAndDigits(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i]<97 || pass[i]>122)
                {
                    if (pass[i] < 48 || pass[i] > 57)
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        trueCounter = 0;
                        return;
                    }
                }

            }

        }
    }
}
