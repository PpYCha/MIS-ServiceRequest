namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Accounts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServiceRequestInfoes", "Remark_ID", "dbo.RemarkInfoes");
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        USER_ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        AccessLevel = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.USER_ID);
            
            AddForeignKey("dbo.ServiceRequestInfoes", "Remark_ID", "dbo.RemarkInfoes", "Remark_ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceRequestInfoes", "Remark_ID", "dbo.RemarkInfoes");
            DropTable("dbo.Accounts");
            AddForeignKey("dbo.ServiceRequestInfoes", "Remark_ID", "dbo.RemarkInfoes", "Remark_ID");
        }
    }
}
