using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class SubjectRepository : IRepository<ISubject>
    {
        public SubjectRepository()
        {
            this.models = new();
        }

        private List<ISubject> models;
        public IReadOnlyCollection<ISubject> Models => models;

        public void AddModel(ISubject subject)
        {
            models.Add(subject);
        }

        public ISubject FindById(int id)
        {
            return models.FirstOrDefault(i => i.Id == id);
        }

        public ISubject FindByName(string name)
        {
            return models.FirstOrDefault(x => x.Name == name);
        }
    }
}
