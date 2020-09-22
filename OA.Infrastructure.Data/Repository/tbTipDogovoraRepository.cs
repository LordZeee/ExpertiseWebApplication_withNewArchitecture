using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbTipDogovoraRepository : IRepository<tbTipDogovora>
    {
        private ExpertContext db;
        public tbTipDogovoraRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbTipDogovora> GetExpertizyList()
        {
            return db.tbTipDogovora.ToList();
        }
        public tbTipDogovora GetExpertizy(int id)
        {
            return db.tbTipDogovora.Find(id);
        }
        public void Create(tbTipDogovora tbTipDogovora)
        {
            db.tbTipDogovora.Add(tbTipDogovora);
        }
        public void Update(tbTipDogovora tbTipDogovora)
        {
            db.Entry(tbTipDogovora).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbTipDogovora tbTipDogovora = db.tbTipDogovora.Find(id);
            if (tbTipDogovora != null)
            {
                db.tbTipDogovora.Remove(tbTipDogovora);
            }
        }
    }
}
