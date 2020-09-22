using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbSoispolniteliRepository : IRepository<tbSoispolniteli>
    {
        private ExpertContext db;
        public tbSoispolniteliRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbSoispolniteli> GetExpertizyList()
        {
            return db.tbSoispolniteli.ToList();
        }
        public tbSoispolniteli GetExpertizy(int id)
        {
            return db.tbSoispolniteli.Find(id);
        }
        public void Create(tbSoispolniteli tbSoispolniteli)
        {
            db.tbSoispolniteli.Add(tbSoispolniteli);
        }
        public void Update(tbSoispolniteli tbSoispolniteli)
        {
            db.Entry(tbSoispolniteli).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbSoispolniteli tbSoispolniteli = db.tbSoispolniteli.Find(id);
            if (tbSoispolniteli != null)
            {
                db.tbSoispolniteli.Remove(tbSoispolniteli);
            }
        }
    }
}
