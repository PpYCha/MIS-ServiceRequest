namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationShip : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FindingParticulars", "II_ID", c => c.Int());
            AddColumn("dbo.Recommendations", "II_ID", c => c.Int());
            CreateIndex("dbo.FindingParticulars", "II_ID");
            CreateIndex("dbo.Recommendations", "II_ID");
            AddForeignKey("dbo.Recommendations", "II_ID", "dbo.InspectionInfoes", "II_ID");
            AddForeignKey("dbo.FindingParticulars", "II_ID", "dbo.InspectionInfoes", "II_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FindingParticulars", "II_ID", "dbo.InspectionInfoes");
            DropForeignKey("dbo.Recommendations", "II_ID", "dbo.InspectionInfoes");
            DropIndex("dbo.Recommendations", new[] { "II_ID" });
            DropIndex("dbo.FindingParticulars", new[] { "II_ID" });
            DropColumn("dbo.Recommendations", "II_ID");
            DropColumn("dbo.FindingParticulars", "II_ID");
        }
    }
}
