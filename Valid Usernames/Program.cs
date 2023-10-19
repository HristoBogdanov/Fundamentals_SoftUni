using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string st in users)
            {
                if (st.Length < 3 || st.Length > 16)
                {
                    continue;
                }
                bool flag = false;
                foreach (var ch in st)
                {
                    if (!char.IsDigit(ch) && !char.IsLetter(ch) && ch!='_' && ch!='-')
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine(st);
                }
            }
        }
    }
}
