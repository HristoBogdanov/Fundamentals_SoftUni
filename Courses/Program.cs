using System;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input;
            while ((input=Console.ReadLine())!="end")
            {
                string[] data = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string nameCourse = data[0];
                string student = data[1];

                if (!courses.ContainsKey(nameCourse))
                {
                    courses.Add(nameCourse, new List<string>());
                }
                courses[nameCourse].Add(student);
            }
            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var x in kvp.Value)
                {
                    Console.WriteLine($"-- {x}");
                }
            }

        }
    }
}
