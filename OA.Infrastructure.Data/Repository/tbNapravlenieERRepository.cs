using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;


namespace OA.Infrastructure.Data.Repository
{
    public class tbNapravlenieERRepository : IRepository<tbNapravlenieER>
    {
        private ExpertContext db;

        public tbNapravlenieERRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbNapravlenieER> GetExpertizyList()
        {
            return db.tbNapravlenieER.ToList();
        }
        public tbNapravlenieER GetExpertizy(int id)
        {
            return db.tbNapravlenieER.Find(id);
        }
        public void Create(tbNapravlenieER tbNapravlenieER)
        {
            db.tbNapravlenieER.Add(tbNapravlenieER);
        }
        public void Update(tbNapravlenieER tbNapravlenieER)
        {
            db.Entry(tbNapravlenieER).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbNapravlenieER tbNapravlenieER = db.tbNapravlenieER.Find(id);
            if (tbNapravlenieER != null)
            {
                db.tbNapravlenieER.Remove(tbNapravlenieER);

            }
        }
    }
}

