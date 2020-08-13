namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignTech : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ServiceRequestInfoes", "AssignedTechnician", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ServiceRequestInfoes", "AssignedTechnician");
        }
    }
}
