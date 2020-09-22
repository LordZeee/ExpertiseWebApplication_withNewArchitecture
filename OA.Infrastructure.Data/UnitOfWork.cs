using OA.Domain.Core.Entitys;
using OA.Infrastructure.Data.DbContext;
using OA.Infrastructure.Data.Repository;
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
        private tbIndexVDRepository tbIndexVDRepository;
        private tbIspolnitelRepository tbIspolnitelRepository;
        private tbNapravlenieERRepository tbNapravlenieERRepository;
        private tbOrganizatsiyaRepository tbOrganizatsiyaRepository;
        private tbOtdelenieRepository tbOtdelenieRepository;
        private tbSoispolniteliRepository tbSoispolniteliRepository;
        private tbStatusDRepository tbStatusDRepository;
        private tbStatusERepository tbStatusERepository;
        private tbTipDogovoraRepository tbTipDogovoraRepository;
        private tbVidERRepository tbVidERRepository;
        private tbVidRSRepository tbVidRSRepository;
        public ExpertizyRepository tbExpertizy
        {
            get
            {
                if (expertizyRepository == null)
                    expertizyRepository = new ExpertizyRepository(db);
                return expertizyRepository;
            }
        }
        public tbIndexVDRepository tbIndexVD
        {
            get
            {
                if (tbIndexVDRepository == null)
                    tbIndexVDRepository = new tbIndexVDRepository(db);
                return tbIndexVDRepository;
            }
        }

        public tbIspolnitelRepository tbIspolnitel
        {
            get
            {
                if (tbIspolnitelRepository == null)
                    tbIspolnitelRepository = new tbIspolnitelRepository(db);
                return tbIspolnitelRepository;
            }
        }
        public tbNapravlenieERRepository tbNapravlenieER
        {
            get
            {
                if (tbNapravlenieERRepository == null)
                tbNapravlenieERRepository = new tbNapravlenieERRepository(db);
                return tbNapravlenieERRepository;
            }
        }
        public tbOrganizatsiyaRepository tbOrganizatsiya
        {
            get
            {
                if (tbOrganizatsiyaRepository == null)
                    tbOrganizatsiyaRepository = new tbOrganizatsiyaRepository(db);
                return tbOrganizatsiyaRepository;
            }
        }
        public tbOtdelenieRepository tbOtdelenie
        {
            get
            {
                if (tbOtdelenieRepository == null)
                    tbOtdelenieRepository = new tbOtdelenieRepository(db);
                return tbOtdelenieRepository;
            }
        }
        public tbSoispolniteliRepository tbSoispolniteli
        {
            get
            {
                if (tbSoispolniteliRepository == null)
                    tbSoispolniteliRepository = new tbSoispolniteliRepository(db);
                return tbSoispolniteliRepository;
            }
        }
        public tbStatusDRepository tbStatusD
        {
            get
            {
                if (tbStatusDRepository == null)
                    tbStatusDRepository = new tbStatusDRepository(db);
                return tbStatusDRepository;
            }
        }

        public tbStatusERepository tbStatusE
        {
            get
            {
                if (tbStatusERepository == null)
                    tbStatusERepository = new tbStatusERepository(db);
                return tbStatusERepository;
            }
        }
        public tbTipDogovoraRepository tbTipDogovora
        {
            get {
                if (tbTipDogovoraRepository == null)
                    tbTipDogovoraRepository = new tbTipDogovoraRepository(db);
                return tbTipDogovoraRepository;
                }
        }
        public tbVidERRepository tbVidER
        {
            get
            {
                if (tbVidERRepository == null)
                    tbVidERRepository = new tbVidERRepository(db);
                return tbVidERRepository;
            }
        }

        public tbVidRSRepository tbVidRS
        {
            get
            {
                if (tbVidRSRepository == null)
                    tbVidRSRepository = new tbVidRSRepository(db);
                return tbVidRSRepository;
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
