namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Techinicinasss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ServiceRequestInfoes", "Techinicians", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ServiceRequestInfoes", "Techinicians");
        }
    }
}
