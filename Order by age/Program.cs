using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arr = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string nameP = arr[0];
                string Id = arr[1];
                int age = int.Parse(arr[2]);

                if (!IdExists(Id, people))
                {
                    Person person = new Person(nameP, Id, age);
                    people.Add(person);
                }
                else
                {
                    foreach (Person x in people)
                    {
                        if (x.ID == Id)
                        {
                            x.NamePerson = nameP;
                            x.Age = age;
                            break;
                        }
                    }
                }
            }
            people = people.OrderBy(x => x.Age).ToList();

            foreach (Person x in people)
            {
                Console.WriteLine(x.ToString());
            }
        }

        public static bool IdExists(string Id, List<Person> people)
        {
            bool containsId = false;
            foreach (Person x in people)
            {
                if (x.ID == Id)
                {
                    containsId = true;
                    break;
                }
            }
            return containsId;
        }
    }
    public class Person
    { 
        public string NamePerson { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name,string id,int age)
        {
            NamePerson = name;
            ID = id;
            Age = age;
        }

        public override string ToString()
        {
            return $"{this.NamePerson} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
