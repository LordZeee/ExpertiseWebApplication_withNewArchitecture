using OA.Domain.Core;
using OA.Domain.Core.Entitys;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.DbContext;
using System.Collections.Generic;
using System.Linq;

namespace OA.Infrastructure.Data.Repository
{
    public class tbOrganizatsiyaRepository : IRepository<tbOrganizatsiya>
    {
        private ExpertContext db;
        public tbOrganizatsiyaRepository(ExpertContext expertContext)
        {
            this.db = expertContext;
        }
        public IEnumerable<tbOrganizatsiya> GetExpertizyList()
        {
            return db.tbOrganizatsiya.ToList();
        }
        public tbOrganizatsiya GetExpertizy(int id)
        {
            return db.tbOrganizatsiya.Find(id);
        }
        public void Create(tbOrganizatsiya tbOrganizatsiya)
        {
            db.tbOrganizatsiya.Add(tbOrganizatsiya);
        }
        public void Update(tbOrganizatsiya tbOrganizatsiya)
        {
            db.Entry(tbOrganizatsiya).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            tbOrganizatsiya tbOrganizatsiya = db.tbOrganizatsiya.Find(id);
            if (tbOrganizatsiya != null)
            {
                db.tbOrganizatsiya.Remove(tbOrganizatsiya);
            }
        }
    }
}
