using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            // 0 -> 48
            // 9 -> 57
            // A -> 65
            // Z -> 90
            // a -> 97
            // z -> 122

            if (!ContainsCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!ContainsLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!ContainsTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(ContainsCharacters(password)&& ContainsLettersAndDigits(password)&& ContainsTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ContainsCharacters(string password)
        {
            bool result;
            if (password.Length >= 6 && password.Length <= 10)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        static bool ContainsLettersAndDigits(string password)
        {
            bool result = true;
            foreach (char ch in password)
            {
                if ((int)ch < 48 ||
                    (int)ch>57 && (int)ch<65 ||
                    (int)ch>90 && (int)ch<97 ||
                    (int)ch > 122)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        static bool ContainsTwoDigits(string password)
        {
            bool result;
            int countDigits = 0;
            foreach (char ch in password)
            {
                if ((int)ch >= 48 && (int)ch <= 57)
                {
                    countDigits++;
                }
            }
            if (countDigits >= 2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
