using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Core.Contracts;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Core
{
    public class Controller : IController
    {
        public Controller()
        {
            subjects = new();
            students = new();
            universities = new();
        }

        private SubjectRepository subjects;
        private StudentRepository students;
        private UniversityRepository universities;

        private int subjectId = 1;
        private int studentId = 1;
        private int universityId = 1;

        public string AddStudent(string firstName, string lastName)
        {
            if(students.FindByName($"{firstName} {lastName}")!=null)
            {
                return String.Format(OutputMessages.AlreadyAddedStudent, firstName, lastName);
            }
            Student student = new(studentId, firstName, lastName);
            studentId++;
            students.AddModel(student);
            return String.Format(OutputMessages.StudentAddedSuccessfully, firstName, lastName, students.GetType().Name);
        }

        public string AddSubject(string subjectName, string subjectType)
        {
            string result = String.Empty;
            if(subjectType!="EconomicalSubject" &&  subjectType!= "HumanitySubject" && subjectType!= "TechnicalSubject")
            {
                result = String.Format(OutputMessages.SubjectTypeNotSupported, subjectType);
            }
            
            else if(subjects.FindByName(subjectName)!= null) 
            {
                result = String.Format(OutputMessages.AlreadyAddedSubject, subjectName);
            }
            else 
            { 
                switch(subjectType)
                {
                    case "EconomicalSubject":
                        EconomicalSubject economicalSubject = new(subjectId,subjectName);
                        subjectId++;
                        subjects.AddModel(economicalSubject);
                            result = String.Format(OutputMessages.SubjectAddedSuccessfully, subjectType, subjectName, subjects.GetType().Name);
                            break;
                    case "HumanitySubject":
                        EconomicalSubject humanitySubject = new(subjectId, subjectName);
                        subjectId++;
                        subjects.AddModel(humanitySubject);
                            result = String.Format(OutputMessages.SubjectAddedSuccessfully, subjectType, subjectName, subjects.GetType().Name);
                            break;
                    case "TechnicalSubject":
                        EconomicalSubject technicalSubject = new(subjectId, subjectName);
                        subjectId++;
                        subjects.AddModel(technicalSubject);
                            result = String.Format(OutputMessages.SubjectAddedSuccessfully, subjectType, subjectName, subjects.GetType().Name);
                            break;
                }
            }

            return result;
        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            if(universities.FindByName(universityName)!= null)
            {
                return String.Format(OutputMessages.AlreadyAddedUniversity,universityName);
            }

            List<int> subjectIds = new();

            foreach(string subjectName in requiredSubjects)
            {
                subjectIds.Add(subjects.FindByName(subjectName).Id);
            }

            University university = new(universityId, universityName, category, capacity, subjectIds);
            universityId++;
            universities.AddModel(university);
            return String.Format(OutputMessages.UniversityAddedSuccessfully, universityName, universities.GetType().Name);
        }

        public string ApplyToUniversity(string studentName, string universityName)
        {
            string[] names = studentName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string firstName = names[0];
            string lastName = names[1];

            if(students.FindByName(studentName)==null)
            {
                return String.Format(OutputMessages.StudentNotRegitered,firstName,lastName);
            }
            if(universities.FindByName(universityName)==null) 
            {
                return String.Format(OutputMessages.UniversityNotRegitered, universityName);
            }
            if (!universities.FindByName(universityName).RequiredSubjects.All(x => students.FindByName(studentName).CoveredExams.Any(e => e == x)))
            {
                return string.Format(OutputMessages.StudentHasToCoverExams, studentName, universityName);
            }
            if(students.FindByName(studentName).University== universities.FindByName(universityName))
            {
                return string.Format(OutputMessages.StudentAlreadyJoined, firstName, lastName,universityName);
            }
            students.FindByName(studentName).JoinUniversity(universities.FindByName(universityName));
            return string.Format(OutputMessages.StudentSuccessfullyJoined, firstName, lastName, universityName);

        }

        public string TakeExam(int studentId, int subjectId)
        {
            if(students.FindById(studentId)==null)
            {
                return String.Format(OutputMessages.InvalidStudentId);
            }
            if (subjects.FindById(subjectId) == null)
            {
                return String.Format(OutputMessages.InvalidSubjectId);
            }

            IStudent student = students.FindById(studentId);
            ISubject subject = subjects.FindById(subjectId);

            if (student.CoveredExams.Contains(subjectId))
            {
                return String.Format(OutputMessages.StudentAlreadyCoveredThatExam, student.FirstName, student.LastName,subject.Name);
            }

            student.CoverExam(subject);
            return String.Format(OutputMessages.StudentSuccessfullyCoveredExam, student.FirstName, student.LastName, subject.Name);
        }

        public string UniversityReport(int universityId)
        {
            IUniversity university = universities.FindById(universityId);
            StringBuilder sb = new();

            int studentsCount = students.Models.Where(x => x.University == university).Count();

            
            sb.AppendLine($"*** {university.Name} ***");
            sb.AppendLine($"Profile: {university.Category}");
            sb.AppendLine($"Students admitted: {studentsCount}");
            sb.AppendLine($"University vacancy: {university.Capacity - studentsCount}");

            return sb.ToString().TrimEnd();
        }
    }
}
