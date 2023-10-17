using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = arr[0];
                string lastName = arr[1];
                double grade = double.Parse(arr[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students = students
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (Student x in students)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }

    public class Student
    { 
        public string First_name { get; set; }
        public string Last_name { get; set; }

        public double Grade { get; set; }
        public Student(string fn,string ln,double grade)
        {
            First_name = fn;
            Last_name = ln;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{First_name} {Last_name}: {Grade:f2}";
        }
    }
}
