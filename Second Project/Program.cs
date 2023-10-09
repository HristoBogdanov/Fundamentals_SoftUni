using System;

namespace Second_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input;

            while((input=Console.ReadLine())!="Complete")
            {
                string[] commands = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdName = commands[0];

                if(cmdName=="Make")
                {
                    int index = int.Parse(commands[2]);
                    string letter = password.Substring(index,1);
                    password=password.Remove(index, 1);
                    if (commands[1]=="Upper")
                    {
                        password = password.Insert(index, letter.ToUpper());
                    }
                    else if(commands[1] == "Lower")
                    {
                        password = password.Insert(index, letter.ToLower());
                    }
                    Console.WriteLine(password);
                }
                else if(cmdName=="Insert")
                {
                    int index = int.Parse(commands[1]);
                    string insert = commands[2];

                    if(index<password.Length)
                    {
                        password = password.Insert(index, insert);
                    }
                    Console.WriteLine(password);
                }
                else if(cmdName=="Replace")
                {
                    char replace = char.Parse(commands[1]);
                    int value = int.Parse(commands[2]);

                    int replaceNew = (int)replace + value;
                    char newChar = (char)replaceNew;

                    while(password.Contains(replace))
                    {
                        password = password.Replace(replace, newChar);
                    }
                    Console.WriteLine(password);
                }
                else if(cmdName=="Validation")
                {
                    bool consitsOf = false;
                    bool containsDigit = false;
                    bool containsUpperLetter = false;
                    bool containsLowerLetter = false;

                    for (int i = 0; i < password.Length; i++)
                    {
                        int code = (int)password[i];
                        if(code>=65 && code<=90)
                        {
                            containsUpperLetter = true;
                        }
                        else if(code>=97 && code<=122)
                        {
                            containsLowerLetter = true;
                        }
                        else if(code>=48 && code<=57)
                        {
                            containsDigit = true;
                        }
                        else if(password[i]=='_')
                        {

                        }
                        else
                        {
                            consitsOf = true;
                        }
                    }
                    if(password.Length<8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    if(consitsOf)
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }
                    if(!containsUpperLetter)
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                    if(!containsLowerLetter)
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }
                    if(!containsDigit)
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                }
            }
        }
    }
}
