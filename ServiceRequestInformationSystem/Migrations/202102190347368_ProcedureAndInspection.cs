namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProcedureAndInspection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FindingParticulars",
                c => new
                    {
                        FP_ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.FP_ID);
            
            CreateTable(
                "dbo.InspectionInfoes",
                c => new
                    {
                        II_ID = c.Int(nullable: false, identity: true),
                        RequestingOffice = c.String(),
                        RequestedBy = c.String(),
                        ReceiveBy = c.String(),
                        ReceiveDate = c.DateTime(),
                        TypeOfUnit = c.String(),
                        ComplaintOnUnit = c.String(),
                        PropertyNumber = c.String(),
                    })
                .PrimaryKey(t => t.II_ID);
            
            CreateTable(
                "dbo.ProcedureTests",
                c => new
                    {
                        PT_ID = c.Int(nullable: false, identity: true),
                        ProcedureTestDetails = c.String(),
                        II_ID = c.Int(),
                    })
                .PrimaryKey(t => t.PT_ID)
                .ForeignKey("dbo.InspectionInfoes", t => t.II_ID)
                .Index(t => t.II_ID);
            
            CreateTable(
                "dbo.Recommendations",
                c => new
                    {
                        R_ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.R_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProcedureTests", "II_ID", "dbo.InspectionInfoes");
            DropIndex("dbo.ProcedureTests", new[] { "II_ID" });
            DropTable("dbo.Recommendations");
            DropTable("dbo.ProcedureTests");
            DropTable("dbo.InspectionInfoes");
            DropTable("dbo.FindingParticulars");
        }
    }
}
