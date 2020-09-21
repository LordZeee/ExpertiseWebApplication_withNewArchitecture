using OA.Domain.Core.Entitys;
using System.Data.Entity;

namespace OA.Infrastructure.Data.DbContext
{
    public class ExpertContext : System.Data.Entity.DbContext
    {
        public ExpertContext()
                   : base("name=ExpertContext")
        {
        }

        public virtual DbSet<tbExpertizy> tbExpertizy { get; set; }
        public virtual DbSet<tbIndexVD> tbIndexVD { get; set; }
        public virtual DbSet<tbIspolnitel> tbIspolnitel { get; set; }
        public virtual DbSet<tbNapravlenieER> tbNapravlenieER { get; set; }
        public virtual DbSet<tbOrganizatsiya> tbOrganizatsiya { get; set; }
        public virtual DbSet<tbOtdelenie> tbOtdelenie { get; set; }
        public virtual DbSet<tbRamDogovor> tbRamDogovor { get; set; }
        public virtual DbSet<tbSoispolniteli> tbSoispolniteli { get; set; }
        public virtual DbSet<tbStatusD> tbStatusD { get; set; }
        public virtual DbSet<tbStatusE> tbStatusE { get; set; }
        public virtual DbSet<tbTipDogovora> tbTipDogovora { get; set; }
        public virtual DbSet<tbVidER> tbVidER { get; set; }
        public virtual DbSet<tbVidRS> tbVidRS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbOrganizatsiya>()
                .HasMany(e => e.tbExpertizys)
                .WithOptional(e => e.tbOrganizatsiya)
                .HasForeignKey(e => e.nZayavitel);

            modelBuilder.Entity<tbOrganizatsiya>()
                .HasMany(e => e.tbExpertizys2)
                .WithOptional(e => e.tbOrganizatsiyaZak)
                .HasForeignKey(e => e.nZakazchik);

            modelBuilder.Entity<tbOtdelenie>()
                .HasMany(e => e.tbExpertizys)
                .WithOptional(e => e.tbOtdelenie)
                .HasForeignKey(e => e.nOtdelenie);

            modelBuilder.Entity<tbIspolnitel>()
               .HasMany(e => e.tbExpertizys)
               .WithOptional(e => e.tbIspolnitel)
               .HasForeignKey(e => e.nIspolnitel);

            modelBuilder.Entity<tbOtdelenie>()
               .HasMany(e => e.tbIspolnitels)
               .WithOptional(e => e.tbOtdelenie)
               .HasForeignKey(e => e.nOtdelenie);

            modelBuilder.Entity<tbNapravlenieER>()
              .HasMany(e => e.tbExpertizys)
              .WithOptional(e => e.tbNapravlenieER)
              .HasForeignKey(e => e.nNapravlenieER);

            modelBuilder.Entity<tbIndexVD>()
              .HasMany(e => e.tbExpertizys)
              .WithOptional(e => e.tbIndexVD)
              .HasForeignKey(e => e.nIndexVD);

            modelBuilder.Entity<tbVidRS>()
              .HasMany(e => e.tbExpertizys)
              .WithOptional(e => e.tbVidRS)
              .HasForeignKey(e => e.nVidRS);

            modelBuilder.Entity<tbVidER>()
              .HasMany(e => e.tbExpertizys)
              .WithOptional(e => e.tbVidER)
              .HasForeignKey(e => e.nVidER);

            modelBuilder.Entity<tbIspolnitel>()
               .HasMany(e => e.tbSoispolnitelis)
               .WithOptional(e => e.tbIspolnitel)
               .HasForeignKey(e => e.nIspolnitel);

            modelBuilder.Entity<tbExpertizy>()
               .HasMany(e => e.tbSoispolnitelis)
               .WithOptional(e => e.tbExpertizy)
               .HasForeignKey(e => e.nExpertiza);

            modelBuilder.Entity<tbStatusE>()
               .HasMany(e => e.tbExpertizys)
               .WithOptional(e => e.tbStatusE)
               .HasForeignKey(e => e.nStatusE);

            modelBuilder.Entity<tbStatusD>()
               .HasMany(e => e.tbExpertizys)
               .WithOptional(e => e.tbStatusD)
               .HasForeignKey(e => e.nStatusD);

            modelBuilder.Entity<tbTipDogovora>()
               .HasMany(e => e.tbExpertizys)
               .WithOptional(e => e.tbTipDogovora)
               .HasForeignKey(e => e.nTipDogovora);

            modelBuilder.Entity<tbExpertizy>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

            modelBuilder.Entity<tbSoispolniteli>()
                .Property(e => e.upsize_ts)
                .IsFixedLength();

        }
    }
}
