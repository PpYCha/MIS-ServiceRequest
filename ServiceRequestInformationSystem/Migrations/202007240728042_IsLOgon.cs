namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsLOgon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "IsLogOn", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "IsLogOn");
        }
    }
}
