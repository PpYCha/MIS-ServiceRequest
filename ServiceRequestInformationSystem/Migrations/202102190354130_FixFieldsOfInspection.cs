namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixFieldsOfInspection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FindingParticulars", "Particulars", c => c.String());
            AddColumn("dbo.FindingParticulars", "Status", c => c.String());
            AddColumn("dbo.Recommendations", "RecommendationDetails", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recommendations", "RecommendationDetails");
            DropColumn("dbo.FindingParticulars", "Status");
            DropColumn("dbo.FindingParticulars", "Particulars");
        }
    }
}
