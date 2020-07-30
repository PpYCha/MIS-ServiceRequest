namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FIxxx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TypeOfServices", "USER_ID", c => c.Int(nullable: false));
            AddColumn("dbo.TypeOfServices", "SR_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.TypeOfServices", "USER_ID");
            CreateIndex("dbo.TypeOfServices", "SR_ID");
            AddForeignKey("dbo.TypeOfServices", "USER_ID", "dbo.Accounts", "USER_ID", cascadeDelete: true);
            AddForeignKey("dbo.TypeOfServices", "SR_ID", "dbo.ServiceRequestInfoes", "SR_ID", cascadeDelete: true);
            DropColumn("dbo.TypeOfServices", "TypeOfServiceProvided");
            DropColumn("dbo.TypeOfServices", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TypeOfServices", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.TypeOfServices", "TypeOfServiceProvided", c => c.String());
            DropForeignKey("dbo.TypeOfServices", "SR_ID", "dbo.ServiceRequestInfoes");
            DropForeignKey("dbo.TypeOfServices", "USER_ID", "dbo.Accounts");
            DropIndex("dbo.TypeOfServices", new[] { "SR_ID" });
            DropIndex("dbo.TypeOfServices", new[] { "USER_ID" });
            DropColumn("dbo.TypeOfServices", "SR_ID");
            DropColumn("dbo.TypeOfServices", "USER_ID");
        }
    }
}
