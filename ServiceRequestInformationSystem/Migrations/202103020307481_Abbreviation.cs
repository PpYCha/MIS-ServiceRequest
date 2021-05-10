namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Abbreviation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OfficeDepartments", "Abbreviation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OfficeDepartments", "Abbreviation");
        }
    }
}
