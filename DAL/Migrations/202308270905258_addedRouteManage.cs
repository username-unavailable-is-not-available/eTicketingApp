namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRouteManage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RouteManages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Route = c.String(),
                        TicketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TicketManages", t => t.TicketId, cascadeDelete: true)
                .Index(t => t.TicketId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RouteManages", "TicketId", "dbo.TicketManages");
            DropIndex("dbo.RouteManages", new[] { "TicketId" });
            DropTable("dbo.RouteManages");
        }
    }
}
