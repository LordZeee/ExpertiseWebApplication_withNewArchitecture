using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class ExpertizyRepository : IRepository<tbExpertizy>
    {
        private ExpertContext db;
        public ExpertizyRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbExpertizy> GetExpertizyList()
        {
            return db.tbExpertizy.ToList();
        }
        public tbExpertizy GetExpertizy(int id)
        {
            return db.tbExpertizy.Find(id);
        }
        public void Create(tbExpertizy tbExpertizy)
        {
            db.tbExpertizy.Add(tbExpertizy);
        }
        public void Update(tbExpertizy tbExpertizy)
        {
            db.Entry(tbExpertizy).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbExpertizy tbExpertizy = db.tbExpertizy.Find(id);
            if(tbExpertizy != null)
            {
                db.tbExpertizy.Remove(tbExpertizy);
            }
        }
    }
}
