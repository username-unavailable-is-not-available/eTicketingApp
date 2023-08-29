namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusName = c.String(nullable: false),
                        BusNo = c.String(nullable: false),
                        BusRoute = c.String(),
                        BusType = c.String(),
                        TotalSeat = c.String(),
                        TicketPrice = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Buses");
        }
    }
}
