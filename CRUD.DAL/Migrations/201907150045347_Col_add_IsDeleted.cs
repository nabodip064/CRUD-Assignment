namespace CRUD.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Col_add_IsDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AgentInfoModels", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.AgentWithFlightAPIS", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AgentWithFlightAPIS", "IsDeleted");
            DropColumn("dbo.AgentInfoModels", "IsDeleted");
        }
    }
}
