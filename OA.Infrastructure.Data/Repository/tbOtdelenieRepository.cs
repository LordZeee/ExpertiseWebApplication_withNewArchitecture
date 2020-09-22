using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbOtdelenieRepository : IRepository<tbOtdelenie>
    {
        private ExpertContext db;
        public tbOtdelenieRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbOtdelenie> GetExpertizyList()
        {
            return db.tbOtdelenie.ToList();
        }
        public tbOtdelenie GetExpertizy(int id)
        {
            return db.tbOtdelenie.Find(id);
        }
        public void Create(tbOtdelenie tbExpertizy)
        {
            db.tbOtdelenie.Add(tbExpertizy);
        }
        public void Update(tbOtdelenie tbOtdelenie)
        {
            db.Entry(tbOtdelenie).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbOtdelenie tbOtdelenie = db.tbOtdelenie.Find(id);
            if (tbOtdelenie != null)
            {
                db.tbOtdelenie.Remove(tbOtdelenie);
            }
        }
    }
}
