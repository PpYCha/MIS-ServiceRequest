namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SSSS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemDevelopments", "Accomplishment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemDevelopments", "Accomplishment");
        }
    }
}
