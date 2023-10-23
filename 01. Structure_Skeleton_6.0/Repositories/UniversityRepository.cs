using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories
{
    public class UniversityRepository:IRepository<IUniversity>
    {
        public UniversityRepository()
        {
            this.models = new();
        }

        private List<IUniversity> models;

        public IReadOnlyCollection<IUniversity>Models=>this.models.AsReadOnly();

        public void AddModel(IUniversity university)
        {
            this.models.Add(university);
        }

        public IUniversity FindById(int id)
        {
            return models.FirstOrDefault(i => i.Id == id);
        }

        public IUniversity FindByName(string name)
        {
            return models.FirstOrDefault(x=>x.Name == name);
        }
    }
}
