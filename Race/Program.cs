using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternLetters = @"[A-Za-z]*";
            string patternDigits = @"(\d)";
            Dictionary<string, int> participantResults = new Dictionary<string, int>();
            Regex regexLetters = new Regex(patternLetters);
            Regex regexDigits = new Regex(patternDigits);

            string[] participants = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string input;

            while ((input = Console.ReadLine()) != "end of race")
            {
                int sum = 0;
                MatchCollection matchLetters = regexLetters.Matches(input);
                MatchCollection matchDigits = regexDigits.Matches(input);
                string nameParticipant = string.Join("", matchLetters);

                foreach (Match match in matchDigits)
                {
                    sum += int.Parse(match.Groups[1].Value);
                }

                for (int i = 0; i < participants.Length; i++)
                {
                    if (nameParticipant == participants[i])
                    {
                        if (!participantResults.ContainsKey(nameParticipant))
                        {
                            participantResults.Add(nameParticipant, sum);
                        }
                        else
                        {
                            participantResults[nameParticipant] += sum;
                        }
                    }
                }
            }
            string[] sortedResults = participantResults.OrderByDescending(x => x.Value).Select(n => n.Key).ToArray();
            Console.WriteLine($"1st place: {sortedResults[0]}");
            Console.WriteLine($"2nd place: {sortedResults[1]}");
            Console.WriteLine($"3rd place: {sortedResults[2]}");
        }
    }
}
