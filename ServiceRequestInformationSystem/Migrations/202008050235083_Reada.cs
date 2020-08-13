namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemDevelopments", "Remarks", c => c.String());
            DropColumn("dbo.SystemDevelopments", "Memo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SystemDevelopments", "Memo", c => c.String());
            DropColumn("dbo.SystemDevelopments", "Remarks");
        }
    }
}
