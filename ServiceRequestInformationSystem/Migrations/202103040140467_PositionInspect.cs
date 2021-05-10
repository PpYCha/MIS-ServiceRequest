namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PositionInspect : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InspectionInfoes", "Position", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.InspectionInfoes", "Position");
        }
    }
}
