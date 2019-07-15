namespace CRUD.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inital_To_CRUD_DAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgentInfoModels",
                c => new
                    {
                        AgentInfoId = c.Int(nullable: false, identity: true),
                        AgentCode = c.String(nullable: false),
                        AgentName = c.String(),
                        MarkUpPlanId = c.Int(nullable: false),
                        Email = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        PostCode = c.String(),
                        JoiningDate = c.DateTime(),
                        Balance = c.Double(nullable: false),
                        AgentTypes = c.Int(),
                        FlightAPIS = c.Int(),
                        Status = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AgentInfoId);
            
            CreateTable(
                "dbo.AgentWithFlightAPIS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AgentInfoId = c.Int(nullable: false),
                        FlightAPIId = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AgentInfoModels", t => t.AgentInfoId, cascadeDelete: true)
                .Index(t => t.AgentInfoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AgentWithFlightAPIS", "AgentInfoId", "dbo.AgentInfoModels");
            DropIndex("dbo.AgentWithFlightAPIS", new[] { "AgentInfoId" });
            DropTable("dbo.AgentWithFlightAPIS");
            DropTable("dbo.AgentInfoModels");
        }
    }
}
