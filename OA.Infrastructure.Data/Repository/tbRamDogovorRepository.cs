using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbRamDogovorepository : IRepository<tbRamDogovor>
    {
        private ExpertContext db;
        public tbRamDogovorepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbRamDogovor> GetExpertizyList()
        {
            return db.tbRamDogovor.ToList();
        }
        public tbRamDogovor GetExpertizy(int id)
        {
            return db.tbRamDogovor.Find(id);
        }
        public void Create(tbRamDogovor tbRamDogovor)
        {
            db.tbRamDogovor.Add(tbRamDogovor);
        }
        public void Update(tbRamDogovor tbRamDogovor)
        {
            db.Entry(tbRamDogovor).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbRamDogovor tbRamDogovor = db.tbRamDogovor.Find(id);
            if (tbRamDogovor != null)
            {
                db.tbRamDogovor.Remove(tbRamDogovor);
            }
        }
    }
}
