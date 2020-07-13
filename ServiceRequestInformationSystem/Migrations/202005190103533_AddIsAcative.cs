namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsAcative : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ServiceProvidedBies", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.OfficeDepartments", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.RemarkInfoes", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RemarkInfoes", "IsActive");
            DropColumn("dbo.OfficeDepartments", "IsActive");
            DropColumn("dbo.ServiceProvidedBies", "IsActive");
        }
    }
}
