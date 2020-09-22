using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbVidERRepository : IRepository<tbVidER>
    {
        private ExpertContext db;
        public tbVidERRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbVidER> GetExpertizyList()
        {
            return db.tbVidER.ToList();
        }
        public tbVidER GetExpertizy(int id)
        {
            return db.tbVidER.Find(id);
        }
        public void Create(tbVidER tbVidER)
        {
            db.tbVidER.Add(tbVidER);
        }
        public void Update(tbVidER tbVidER)
        {
            db.Entry(tbVidER).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbVidER tbVidER = db.tbVidER.Find(id);
            if (tbVidER != null)
            {
                db.tbVidER.Remove(tbVidER);
            }
        }
    }
}
