using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbVidRSRepository : IRepository<tbVidRS>
    {
        private ExpertContext db;
        public tbVidRSRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbVidRS> GetExpertizyList()
        {
            return db.tbVidRS.ToList();
        }
        public tbVidRS GetExpertizy(int id)
        {
            return db.tbVidRS.Find(id);
        }
        public void Create(tbVidRS tbVidRS)
        {
            db.tbVidRS.Add(tbVidRS);
        }
        public void Update(tbVidRS tbVidRS)
        {
            db.Entry(tbVidRS).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbVidRS tbVidRS = db.tbVidRS.Find(id);
            if (tbVidRS != null)
            {
                db.tbVidRS.Remove(tbVidRS);
            }
        }
    }
}
