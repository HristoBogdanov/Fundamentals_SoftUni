using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', ',',':','-' };
            List<string> phones = Console.ReadLine()
                .Split(separators)
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();
            List<string> pom = new List<string>();
            string commandName = "";
            

            string input = Console.ReadLine();
            while (input != "End")
            {
                pom = input
                    .Split(separators)
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .ToList();
                foreach (string x in pom)
                {
                    x.Trim();
                    if (x == " ") pom.Remove(x);
                }

                commandName = pom[0];

                if (commandName == "Add")
                {
                    if(!phones.Contains(pom[1]))
                    phones.Add(pom[1]);
                }
                else if (commandName == "Remove")
                {
                    if (phones.Contains(pom[1]))
                    {
                        phones.Remove(pom[1]);
                    }
                }
                else if (commandName == "Bonus")
                {
                    int index = 0;
                    if (phones.Contains(pom[2]))
                    {
                        for (int i = 0; i < phones.Count; i++)
                        {
                            if (phones[i] == pom[2])
                            {
                                index = i;
                                break;
                            }
                        }
                        phones.Insert(index + 1, pom[3]);
                    }
                }
                else if (commandName == "Last")
                {
                    string lastPhone = pom[1];
                    if (phones.Contains(lastPhone))
                    {
                        phones.Remove(lastPhone);
                        phones.Add(lastPhone);
                    }
                }

                input = Console.ReadLine();
                
            }

            Console.WriteLine(string.Join(", ",phones));
        }
    }
}
