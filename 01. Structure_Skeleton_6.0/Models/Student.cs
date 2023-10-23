using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Models
{
    public class Student : IStudent
    {
        public Student(int studentId, string firstName, string lastName)
        {
            Id= studentId;
            FirstName= firstName;
            LastName= lastName;
            coveredExams = new List<int>();
        }
        private string firstName;
        private string lastName;
        private List<int> coveredExams;
        public int Id { get; private set; }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                this.lastName = value;
            }
        }

        public IReadOnlyCollection<int> CoveredExams => this.coveredExams.AsReadOnly();

    public IUniversity University { get; private set; }

        public void CoverExam(ISubject subject)
        {
            coveredExams.Add(subject.Id);
        }

        public void JoinUniversity(IUniversity university)
        {
            this.University = university;
        }
    }
}
