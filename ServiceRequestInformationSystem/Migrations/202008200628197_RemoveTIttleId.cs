namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTIttleId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SystemDevelopments", "TT_ID", "dbo.SystemTitles");
            DropIndex("dbo.SystemDevelopments", new[] { "TT_ID" });
            DropColumn("dbo.SystemDevelopments", "TT_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SystemDevelopments", "TT_ID", c => c.Int());
            CreateIndex("dbo.SystemDevelopments", "TT_ID");
            AddForeignKey("dbo.SystemDevelopments", "TT_ID", "dbo.SystemTitles", "TT_ID");
        }
    }
}
