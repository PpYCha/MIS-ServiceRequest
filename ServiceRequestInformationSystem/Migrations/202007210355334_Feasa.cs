namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Feasa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        USER_ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        AccessLevel = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.USER_ID);
            
            CreateTable(
                "dbo.ServiceProvidedBies",
                c => new
                    {
                        SP_ID = c.Int(nullable: false, identity: true),
                        spName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SP_ID);
            
            CreateTable(
                "dbo.TechnicianRequests",
                c => new
                    {
                        TR_ID = c.Int(nullable: false, identity: true),
                        SP_ID = c.Int(nullable: false),
                        SR_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TR_ID)
                .ForeignKey("dbo.ServiceProvidedBies", t => t.SP_ID, cascadeDelete: true)
                .ForeignKey("dbo.ServiceRequestInfoes", t => t.SR_ID, cascadeDelete: true)
                .Index(t => t.SP_ID)
                .Index(t => t.SR_ID);
            
            CreateTable(
                "dbo.ServiceRequestInfoes",
                c => new
                    {
                        SR_ID = c.Int(nullable: false, identity: true),
                        TypeOfServiceProvided = c.String(),
                        RequestedBy = c.String(),
                        OfficeDepartmentName = c.String(),
                        DateRequested = c.DateTime(),
                        TimeLeft = c.String(),
                        DateAccomplished = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                        Techinicians = c.String(),
                        RemarkDeatails = c.String(),
                    })
                .PrimaryKey(t => t.SR_ID);
            
            CreateTable(
                "dbo.TypeOfServices",
                c => new
                    {
                        TS_ID = c.Int(nullable: false, identity: true),
                        TypeOfServiceProvided = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TS_ID);
            
            CreateTable(
                "dbo.OfficeDepartments",
                c => new
                    {
                        OD_ID = c.Int(nullable: false, identity: true),
                        OfficeDepartmentName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OD_ID);
            
            CreateTable(
                "dbo.RemarkInfoes",
                c => new
                    {
                        Remark_ID = c.Int(nullable: false, identity: true),
                        Remars = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Remark_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TechnicianRequests", "SR_ID", "dbo.ServiceRequestInfoes");
            DropForeignKey("dbo.TechnicianRequests", "SP_ID", "dbo.ServiceProvidedBies");
            DropIndex("dbo.TechnicianRequests", new[] { "SR_ID" });
            DropIndex("dbo.TechnicianRequests", new[] { "SP_ID" });
            DropTable("dbo.RemarkInfoes");
            DropTable("dbo.OfficeDepartments");
            DropTable("dbo.TypeOfServices");
            DropTable("dbo.ServiceRequestInfoes");
            DropTable("dbo.TechnicianRequests");
            DropTable("dbo.ServiceProvidedBies");
            DropTable("dbo.Accounts");
        }
    }
}
