using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbStatusERepository : IRepository<tbStatusE>
    {
        private ExpertContext db;
        public tbStatusERepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbStatusE> GetExpertizyList()
        {
            return db.tbStatusE.ToList();
        }
        public tbStatusE GetExpertizy(int id)
        {
            return db.tbStatusE.Find(id);
        }
        public void Create(tbStatusE tbStatusE)
        {
            db.tbStatusE.Add(tbStatusE);
        }
        public void Update(tbStatusE tbStatusE)
        {
            db.Entry(tbStatusE).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbStatusE tbStatusE = db.tbStatusE.Find(id);
            if (tbStatusE != null)
            {
                db.tbStatusE.Remove(tbStatusE);
            }
        }
    }
}
