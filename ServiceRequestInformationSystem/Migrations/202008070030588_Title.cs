namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Title : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemDevelopments", "SystemTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemDevelopments", "SystemTitle");
        }
    }
}
