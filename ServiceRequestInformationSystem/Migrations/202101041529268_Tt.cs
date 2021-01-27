namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemDevelopments", "TT_ID", c => c.Int());
            CreateIndex("dbo.SystemDevelopments", "TT_ID");
            AddForeignKey("dbo.SystemDevelopments", "TT_ID", "dbo.SystemTitles", "TT_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SystemDevelopments", "TT_ID", "dbo.SystemTitles");
            DropIndex("dbo.SystemDevelopments", new[] { "TT_ID" });
            DropColumn("dbo.SystemDevelopments", "TT_ID");
        }
    }
}
