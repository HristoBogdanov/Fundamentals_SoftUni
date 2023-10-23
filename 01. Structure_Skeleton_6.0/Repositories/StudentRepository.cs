using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class StudentRepository : IRepository<IStudent>
    {
        private List<IStudent> models;
        public StudentRepository()
        {
            models = new();
        }
        public IReadOnlyCollection<IStudent>Models=>this.models.AsReadOnly();

        public void AddModel(IStudent student)
        {
            models.Add(student);
        }

        public IStudent FindById(int id)
        {
            return models.FirstOrDefault(i=>i.Id == id);
        }

        public IStudent FindByName(string name)
        {
            string[] names=name.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string firstName = names[0];
            string lastName = names[1];

            return models.FirstOrDefault(n=>n.FirstName== firstName && n.LastName == lastName);
        }
    }
}
