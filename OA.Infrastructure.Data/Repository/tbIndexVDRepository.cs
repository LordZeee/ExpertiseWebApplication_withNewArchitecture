using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;


namespace OA.Infrastructure.Data.Repository
{
    public class tbIndexVDRepository : IRepository<tbIndexVD>
    {
        private ExpertContext db;
        public tbIndexVDRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbIndexVD> GetExpertizyList()
        {
            return db.tbIndexVD.ToList();
        }
        public tbIndexVD GetExpertizy(int id)
        {
            return db.tbIndexVD.Find(id);
        }
        public void Create(tbIndexVD tbIndexVD)
        {
            db.tbIndexVD.Add(tbIndexVD);
        }
        public void Update(tbIndexVD tbIndexVD)
        {
            db.Entry(tbIndexVD).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbIndexVD tbIndexVD = db.tbIndexVD.Find(id);
            if (tbIndexVD != null)
            {
                db.tbIndexVD.Remove(tbIndexVD);
            }
        }
    }
}
