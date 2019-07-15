namespace CRUD.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpDateColMarkUpPlanIdAgentInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AgentInfoModels", "MarkUpPlanId", c => c.Int(nullable: false));
            DropColumn("dbo.AgentInfoModels", "MarkUpPlan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AgentInfoModels", "MarkUpPlan", c => c.String());
            DropColumn("dbo.AgentInfoModels", "MarkUpPlanId");
        }
    }
}
