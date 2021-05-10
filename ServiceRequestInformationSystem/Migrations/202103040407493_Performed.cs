namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Performed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InspectedPerformedBies",
                c => new
                    {
                        IP_ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.String(),
                        II_ID = c.Int(),
                    })
                .PrimaryKey(t => t.IP_ID)
                .ForeignKey("dbo.InspectionInfoes", t => t.II_ID)
                .Index(t => t.II_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InspectedPerformedBies", "II_ID", "dbo.InspectionInfoes");
            DropIndex("dbo.InspectedPerformedBies", new[] { "II_ID" });
            DropTable("dbo.InspectedPerformedBies");
        }
    }
}
