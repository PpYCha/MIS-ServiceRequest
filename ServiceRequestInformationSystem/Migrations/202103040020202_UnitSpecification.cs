namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnitSpecification : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UnitSpecifications",
                c => new
                    {
                        US_ID = c.Int(nullable: false, identity: true),
                        HardwareComponent = c.String(),
                        Remarks = c.String(),
                        II_ID = c.Int(),
                    })
                .PrimaryKey(t => t.US_ID)
                .ForeignKey("dbo.InspectionInfoes", t => t.II_ID)
                .Index(t => t.II_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UnitSpecifications", "II_ID", "dbo.InspectionInfoes");
            DropIndex("dbo.UnitSpecifications", new[] { "II_ID" });
            DropTable("dbo.UnitSpecifications");
        }
    }
}
