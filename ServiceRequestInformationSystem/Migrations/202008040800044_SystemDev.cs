namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SystemDev : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemDevelopments",
                c => new
                    {
                        SD_ID = c.Int(nullable: false, identity: true),
                        USER_ID = c.Int(nullable: false),
                        DateAccomplishment = c.DateTime(),
                        Memo = c.String(),
                    })
                .PrimaryKey(t => t.SD_ID)
                .ForeignKey("dbo.Accounts", t => t.USER_ID, cascadeDelete: true)
                .Index(t => t.USER_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SystemDevelopments", "USER_ID", "dbo.Accounts");
            DropIndex("dbo.SystemDevelopments", new[] { "USER_ID" });
            DropTable("dbo.SystemDevelopments");
        }
    }
}
