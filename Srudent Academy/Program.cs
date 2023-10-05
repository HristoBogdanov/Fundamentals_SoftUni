using System;
using System.Collections.Generic;

namespace Srudent_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                }
                students[student].Add(grade);
            }
            foreach (var kvp in students)
            {
                double average = CalcAverage(kvp.Value);
                if (average >= 4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {average:f2}");
                }
            }
        }
        public static double CalcAverage(List<double> list)
        {
            double sum = 0;
            foreach (var x in list)
            {
                sum += x;
            }
            return sum / list.Count;
        }
    }
}
