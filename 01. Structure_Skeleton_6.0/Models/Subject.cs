using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Models
{
    public abstract class Subject : ISubject
    {
        protected Subject(int subjectId, string subjectName, double subjectRate)
        {
            Id= subjectId;
            Name= subjectName;
            Rate= subjectRate; 
        }

        private string name;
        public int Id { get; private set; }

        public string Name 
        {
            get => this.name;
            private set
            { 
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                this.name = value;
            }
        }

        public double Rate { get; private set; }
    }
}
