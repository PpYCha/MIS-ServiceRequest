namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WeeklyMonthly : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemDevelopments", "WeeklyMonthly", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemDevelopments", "WeeklyMonthly");
        }
    }
}
