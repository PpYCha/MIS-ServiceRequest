namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ssss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceProvidedBies",
                c => new
                    {
                        SP_ID = c.Int(nullable: false, identity: true),
                        spName = c.String(),
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
                        TS_ID = c.Int(nullable: false),
                        RequestedBy = c.String(),
                        OD_ID = c.Int(nullable: false),
                        DateRequested = c.DateTime(),
                        TimeLeft = c.String(),
                        DateAccomplished = c.DateTime(),
                        Remark_ID = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SR_ID)
                .ForeignKey("dbo.OfficeDepartments", t => t.OD_ID, cascadeDelete: true)
                .ForeignKey("dbo.RemarkInfoes", t => t.Remark_ID, cascadeDelete: true)
                .ForeignKey("dbo.TypeOfServices", t => t.TS_ID, cascadeDelete: true)
                .Index(t => t.TS_ID)
                .Index(t => t.OD_ID)
                .Index(t => t.Remark_ID);
            
            CreateTable(
                "dbo.OfficeDepartments",
                c => new
                    {
                        OD_ID = c.Int(nullable: false, identity: true),
                        OfficeDepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.OD_ID);
            
            CreateTable(
                "dbo.RemarkInfoes",
                c => new
                    {
                        Remark_ID = c.Int(nullable: false, identity: true),
                        Remars = c.String(),
                    })
                .PrimaryKey(t => t.Remark_ID);
            
            CreateTable(
                "dbo.TypeOfServices",
                c => new
                    {
                        TS_ID = c.Int(nullable: false, identity: true),
                        TypeOfServiceProvided = c.String(),
                    })
                .PrimaryKey(t => t.TS_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TechnicianRequests", "SR_ID", "dbo.ServiceRequestInfoes");
            DropForeignKey("dbo.ServiceRequestInfoes", "TS_ID", "dbo.TypeOfServices");
            DropForeignKey("dbo.ServiceRequestInfoes", "Remark_ID", "dbo.RemarkInfoes");
            DropForeignKey("dbo.ServiceRequestInfoes", "OD_ID", "dbo.OfficeDepartments");
            DropForeignKey("dbo.TechnicianRequests", "SP_ID", "dbo.ServiceProvidedBies");
            DropIndex("dbo.ServiceRequestInfoes", new[] { "Remark_ID" });
            DropIndex("dbo.ServiceRequestInfoes", new[] { "OD_ID" });
            DropIndex("dbo.ServiceRequestInfoes", new[] { "TS_ID" });
            DropIndex("dbo.TechnicianRequests", new[] { "SR_ID" });
            DropIndex("dbo.TechnicianRequests", new[] { "SP_ID" });
            DropTable("dbo.TypeOfServices");
            DropTable("dbo.RemarkInfoes");
            DropTable("dbo.OfficeDepartments");
            DropTable("dbo.ServiceRequestInfoes");
            DropTable("dbo.TechnicianRequests");
            DropTable("dbo.ServiceProvidedBies");
        }
    }
}
