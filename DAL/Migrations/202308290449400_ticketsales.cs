namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ticketsales : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketSales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PassengerId = c.Int(nullable: false),
                        PassengerName = c.String(),
                        VehicleType = c.String(),
                        VechileNo = c.Int(nullable: false),
                        VehicleName = c.String(),
                        PaymentId = c.Int(nullable: false),
                        PaymentAmount = c.String(),
                        TicketStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TicketSales");
        }
    }
}
