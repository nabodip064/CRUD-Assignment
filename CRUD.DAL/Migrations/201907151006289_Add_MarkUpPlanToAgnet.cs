namespace CRUD.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_MarkUpPlanToAgnet : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.AgentInfoModels", "MarkUpPlanId");
            AddForeignKey("dbo.AgentInfoModels", "MarkUpPlanId", "dbo.MarkUpPlans", "MarkUpPlanId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AgentInfoModels", "MarkUpPlanId", "dbo.MarkUpPlans");
            DropIndex("dbo.AgentInfoModels", new[] { "MarkUpPlanId" });
        }
    }
}
