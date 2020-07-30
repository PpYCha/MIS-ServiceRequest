namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FIXConnection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TechnicianRequests", "SP_ID", "dbo.ServiceProvidedBies");
            DropIndex("dbo.TechnicianRequests", new[] { "SP_ID" });
            RenameColumn(table: "dbo.TechnicianRequests", name: "SP_ID", newName: "ServiceProvidedBy_SP_ID");
            AddColumn("dbo.TechnicianRequests", "USER_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.TechnicianRequests", "ServiceProvidedBy_SP_ID", c => c.Int());
            CreateIndex("dbo.TechnicianRequests", "USER_ID");
            CreateIndex("dbo.TechnicianRequests", "ServiceProvidedBy_SP_ID");
            AddForeignKey("dbo.TechnicianRequests", "USER_ID", "dbo.Accounts", "USER_ID", cascadeDelete: true);
            AddForeignKey("dbo.TechnicianRequests", "ServiceProvidedBy_SP_ID", "dbo.ServiceProvidedBies", "SP_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TechnicianRequests", "ServiceProvidedBy_SP_ID", "dbo.ServiceProvidedBies");
            DropForeignKey("dbo.TechnicianRequests", "USER_ID", "dbo.Accounts");
            DropIndex("dbo.TechnicianRequests", new[] { "ServiceProvidedBy_SP_ID" });
            DropIndex("dbo.TechnicianRequests", new[] { "USER_ID" });
            AlterColumn("dbo.TechnicianRequests", "ServiceProvidedBy_SP_ID", c => c.Int(nullable: false));
            DropColumn("dbo.TechnicianRequests", "USER_ID");
            RenameColumn(table: "dbo.TechnicianRequests", name: "ServiceProvidedBy_SP_ID", newName: "SP_ID");
            CreateIndex("dbo.TechnicianRequests", "SP_ID");
            AddForeignKey("dbo.TechnicianRequests", "SP_ID", "dbo.ServiceProvidedBies", "SP_ID", cascadeDelete: true);
        }
    }
}
