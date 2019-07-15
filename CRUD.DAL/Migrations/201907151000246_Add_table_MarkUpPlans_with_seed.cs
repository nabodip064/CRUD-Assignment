namespace CRUD.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_table_MarkUpPlans_with_seed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarkUpPlans",
                c => new
                    {
                        MarkUpPlanId = c.Int(nullable: false, identity: true),
                        MarkUpPlanName = c.String(),
                    })
                .PrimaryKey(t => t.MarkUpPlanId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MarkUpPlans");
        }
    }
}
