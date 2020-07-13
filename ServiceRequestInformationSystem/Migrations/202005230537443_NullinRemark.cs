namespace ServiceRequestInformationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullinRemark : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServiceRequestInfoes", "Remark_ID", "dbo.RemarkInfoes");
            AddForeignKey("dbo.ServiceRequestInfoes", "Remark_ID", "dbo.RemarkInfoes", "Remark_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceRequestInfoes", "Remark_ID", "dbo.RemarkInfoes");
            AddForeignKey("dbo.ServiceRequestInfoes", "Remark_ID", "dbo.RemarkInfoes", "Remark_ID", cascadeDelete: true);
        }
    }
}
