using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ServiceRequestInformationSystem.Models
{
    public class SrisContext : DbContext
    {
        public SrisContext()
           : base("SrisContext")
        {
            Database.SetInitializer<SrisContext>(new SrisDbInitializer());

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SrisContext, Migrations.Configuration>(useSuppliedContext: true));
        }

        public DbSet<ServiceRequestInfo> ServiceRequestInfo { get; set; }
        public DbSet<ServiceProvidedBy> ServiceProvidedBy { get; set; }
        public DbSet<TechnicianRequest> TechnicianRequest { get; set; }
        public DbSet<Account> Account { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceRequestInfo>().HasKey(k => k.SR_ID)
                .Property(p => p.SR_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ServiceProvidedBy>().HasKey(k => k.SP_ID)
              .Property(p => p.SP_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TypeOfService>().HasKey(k => k.TS_ID)
             .Property(p => p.TS_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<OfficeDepartment>().HasKey(k => k.OD_ID)
           .Property(p => p.OD_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<RemarkInfo>().HasKey(k => k.Remark_ID)
          .Property(p => p.Remark_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<TechnicianRequest>().HasKey(k => k.TR_ID)
          .Property(p => p.TR_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Account>().HasKey(k => k.USER_ID)
          .Property(p => p.USER_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ServiceRequestInfo>()
              .HasRequired<TypeOfService>(k => k.TypeOfService)
              .WithMany(p => p.ServiceRequestInfo)
              .HasForeignKey<int>(k => k.TS_ID);

            modelBuilder.Entity<ServiceRequestInfo>()
              .HasRequired<OfficeDepartment>(k => k.OfficeDepartment)
              .WithMany(p => p.ServiceRequestInfo)
              .HasForeignKey<int>(k => k.OD_ID);


            modelBuilder.Entity<TechnicianRequest>()
             .HasRequired<ServiceProvidedBy>(k => k.ServiceProvidedBy)
             .WithMany(p => p.TechnicianRequest)
             .HasForeignKey<int>(k => k.SP_ID);

            modelBuilder.Entity<TechnicianRequest>()
                .HasRequired<ServiceRequestInfo>(k => k.ServiceRequestInfo)
                .WithMany(p => p.TechnicianRequest)
                .HasForeignKey<int>(k => k.SR_ID);

            modelBuilder.Entity<ServiceRequestInfo>()          
            .HasRequired<RemarkInfo>(k => k.RemarkInfo)
            .WithMany(p => p.ServiceRequestInfo)
            .HasForeignKey<int>(k => k.Remark_ID);
        }
    }

}