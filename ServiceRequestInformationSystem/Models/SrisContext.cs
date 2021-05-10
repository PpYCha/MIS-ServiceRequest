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
        public DbSet<SystemDevelopment> SystemDevelopment { get; set; }
        public DbSet<SystemTitles> SystemTitles { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<InspectionInfo> InspectionInfo { get; set; }
        public DbSet<ProcedureTest> ProcedureTest { get; set; }
        public DbSet<FindingParticular> FindingParticular { get; set; }
        public DbSet<Recommendation> Recommendation { get; set; }
        public DbSet<UnitSpecification> UnitSpecification { get; set; }
        public DbSet<InspectedPerformedBy> InspectedPerformedBy { get; set; }


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

            modelBuilder.Entity<SystemDevelopment>().HasKey(k => k.SD_ID)
         .Property(p => p.SD_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<SystemTitles>().HasKey(k => k.TT_ID)
       .Property(p => p.TT_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<InspectionInfo>().HasKey(k => k.II_ID)
                .Property(p => p.II_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ProcedureTest>().HasKey(k => k.PT_ID)
       .Property(p => p.PT_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<FindingParticular>().HasKey(k => k.FP_ID)
      .Property(p => p.FP_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Recommendation>().HasKey(k => k.R_ID)
        .Property(p => p.R_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<UnitSpecification>().HasKey(k => k.US_ID)
      .Property(p => p.US_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<InspectedPerformedBy>().HasKey(k => k.IP_ID)
   .Property(p => p.IP_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<ServiceRequestInfo>()
            //  .HasRequired<TypeOfService>(k => k.TypeOfService)
            //  .WithMany(p => p.ServiceRequestInfo)
            //  .HasForeignKey<int>(k => k.TS_ID);

            //modelBuilder.Entity<ServiceRequestInfo>()
            //  .HasRequired<OfficeDepartment>(k => k.OfficeDepartment)
            //  .WithMany(p => p.ServiceRequestInfo)
            //  .HasForeignKey<int>(k => k.OD_ID);


            modelBuilder.Entity<TechnicianRequest>()
             .HasRequired<Account>(k => k.Account)
             .WithMany(p => p.TechnicianRequest)
             .HasForeignKey<int>(k => k.USER_ID);

            modelBuilder.Entity<TechnicianRequest>()
                .HasRequired<ServiceRequestInfo>(k => k.ServiceRequestInfo)
                .WithMany(p => p.TechnicianRequest)
                .HasForeignKey<int>(k => k.SR_ID);

            modelBuilder.Entity<TypeOfService>()
                .HasRequired<ServiceRequestInfo>(k => k.ServiceRequestInfo)
                .WithMany(p => p.TypeOfServices)
                .HasForeignKey<int>(k => k.SR_ID);

            modelBuilder.Entity<SystemDevelopment>()
                .HasRequired<Account>(k => k.Account)
                .WithMany(p => p.SystemDevelopment)
                .HasForeignKey<int>(k => k.USER_ID);

            modelBuilder.Entity<SystemDevelopment>()
             .HasOptional<SystemTitles>(k => k.SystemTitles)
             .WithMany(p => p.SystemDevelopment)
             .HasForeignKey<int?>(k => k.TT_ID);


            modelBuilder.Entity<ProcedureTest>()
           .HasOptional<InspectionInfo>(k => k.InspectionInfo)
           .WithMany(p => p.ProcedureTest)
           .HasForeignKey<int?>(k => k.II_ID);

            modelBuilder.Entity<FindingParticular>()
          .HasOptional<InspectionInfo>(k => k.InspectionInfo)
          .WithMany(p => p.FindingParticular)
          .HasForeignKey<int?>(k => k.II_ID);


            modelBuilder.Entity<Recommendation>()
         .HasOptional<InspectionInfo>(k => k.InspectionInfo)
         .WithMany(p => p.Recommendation)
         .HasForeignKey<int?>(k => k.II_ID);

            modelBuilder.Entity<UnitSpecification>()
       .HasOptional<InspectionInfo>(k => k.InspectionInfo)
       .WithMany(p => p.UnitSpecification)
       .HasForeignKey<int?>(k => k.II_ID);

            modelBuilder.Entity<InspectedPerformedBy>()
     .HasOptional<InspectionInfo>(k => k.InspectionInfo)
     .WithMany(p => p.InspectedPerformedBy)
     .HasForeignKey<int?>(k => k.II_ID);
        }
    }

}