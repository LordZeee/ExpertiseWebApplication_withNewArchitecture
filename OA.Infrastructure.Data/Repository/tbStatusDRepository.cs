using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbStatusDRepository : IRepository<tbStatusD>
    {
        private ExpertContext db;
        public tbStatusDRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbStatusD> GetExpertizyList()
        {
            return db.tbStatusD.ToList();
        }
        public tbStatusD GetExpertizy(int id)
        {
            return db.tbStatusD.Find(id);
        }
        public void Create(tbStatusD tbStatusD)
        {
            db.tbStatusD.Add(tbStatusD);
        }
        public void Update(tbStatusD tbStatusD)
        {
            db.Entry(tbStatusD).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbStatusD tbStatusD = db.tbStatusD.Find(id);
            if (tbStatusD != null)
            {
                db.tbStatusD.Remove(tbStatusD);
            }
        }
    }
}
