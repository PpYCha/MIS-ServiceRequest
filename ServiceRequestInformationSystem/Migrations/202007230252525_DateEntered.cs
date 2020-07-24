namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateEntered : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ServiceRequestInfoes", "DateEntered", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ServiceRequestInfoes", "DateEntered");
        }
    }
}
