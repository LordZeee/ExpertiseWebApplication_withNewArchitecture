using OA.Infrastructure.Data.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Infrastructure.Data
{
    public class UnitOfWork : IDisposable
    {
        private ExpertContext db = new ExpertContext();
        private ExpertizyRepository expertizyRepository;
        public ExpertizyRepository tbExpertizy
        {
            get
            {
                if (expertizyRepository == null)
                    expertizyRepository = new ExpertizyRepository(db);
                return expertizyRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
