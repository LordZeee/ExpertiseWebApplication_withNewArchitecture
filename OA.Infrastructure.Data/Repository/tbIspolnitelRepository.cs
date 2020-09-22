using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbIspolnitelRepository : IRepository<tbIspolnitel>
    {
        private ExpertContext db;
        public tbIspolnitelRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbIspolnitel> GetExpertizyList()
        {
            return db.tbIspolnitel.ToList();
        }
        public tbIspolnitel GetExpertizy(int id)
        {
            return db.tbIspolnitel.Find(id);
        }
        public void Create(tbIspolnitel tbIspolnitel)
        {
            db.tbIspolnitel.Add(tbIspolnitel);
        }
        public void Update(tbIspolnitel tbIspolnitel)
        {
            db.Entry(tbIspolnitel).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbIspolnitel tbIspolnitel = db.tbIspolnitel.Find(id);
            if (tbIspolnitel != null)
            {
                db.tbIspolnitel.Remove(tbIspolnitel);
            }
        }
    }
}
