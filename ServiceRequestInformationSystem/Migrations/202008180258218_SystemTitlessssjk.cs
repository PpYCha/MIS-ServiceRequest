namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SystemTitlessssjk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemTitles",
                c => new
                    {
                        TT_ID = c.Int(nullable: false, identity: true),
                        TitleName = c.String(),
                    })
                .PrimaryKey(t => t.TT_ID);
            
            AddColumn("dbo.SystemDevelopments", "TT_ID", c => c.Int());
            CreateIndex("dbo.SystemDevelopments", "TT_ID");
            AddForeignKey("dbo.SystemDevelopments", "TT_ID", "dbo.SystemTitles", "TT_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SystemDevelopments", "TT_ID", "dbo.SystemTitles");
            DropIndex("dbo.SystemDevelopments", new[] { "TT_ID" });
            DropColumn("dbo.SystemDevelopments", "TT_ID");
            DropTable("dbo.SystemTitles");
        }
    }
}
